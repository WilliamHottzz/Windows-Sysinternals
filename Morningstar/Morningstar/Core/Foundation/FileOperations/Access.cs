using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morningstar.Core.Foundation.FileOperations
{
    abstract class Access
    {

        /// <summary>
        /// List of permissions the file has over the system.
        /// </summary>
        public List<string> SecurityAttributes = new List<string>();


        public Access() { }

        public abstract bool RemoveRule(string file, string account, FileSystemRights right);
        public abstract bool RemoveAllRules(string file, string account, FileSystemRights right);


        /// <summary>
        /// Checks what file system permissions a program has.
        /// </summary>
        /// <param name="file">user selected file.</param>
        /// <returns>Completed task.</returns>
        internal Task GetAccessControls(string file)
        {
         
            FileSecurity fileSecurity = File.GetAccessControl(path: file);
            fileSecurity.SetAccessRuleProtection(false, false);

            var identity = new SecurityIdentifier(WellKnownSidType.BuiltinUsersSid, null);           
            var rules = fileSecurity.GetAccessRules(true, true, typeof(NTAccount)).OfType<FileSystemAccessRule>();
            var referenceValue = ((NTAccount)identity.Translate(typeof(NTAccount))).Value;

            foreach (FileSystemAccessRule rule in rules)
            {                             
                if (rule.AccessControlType == AccessControlType.Allow && rule.IdentityReference.Value == referenceValue)
                {                    
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.Write)) { this.SecurityAttributes.Add("Write"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.WriteAttributes)) { this.SecurityAttributes.Add("WriteAttributes"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.WriteExtendedAttributes)) { this.SecurityAttributes.Add("WriteExtendedAttributes"); }                    
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.Read)) { this.SecurityAttributes.Add("Read"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.ReadAndExecute)) { this.SecurityAttributes.Add("ReadAndExecute"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.ReadAttributes)) { this.SecurityAttributes.Add("ReadAttributes"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.ReadPermissions)) { this.SecurityAttributes.Add("ReadPermissions"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.ListDirectory)) { this.SecurityAttributes.Add("ListDirectory"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.CreateFiles)) { this.SecurityAttributes.Add("CreateFile"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.CreateDirectories)) { this.SecurityAttributes.Add("CreateDirectories"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.Delete)) { this.SecurityAttributes.Add("Delete"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.DeleteSubdirectoriesAndFiles)) { this.SecurityAttributes.Add("DeleteSubdirectoriesAndFiles"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.Modify)) { this.SecurityAttributes.Add("Modify"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.AppendData)) { this.SecurityAttributes.Add("AppendData"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.ExecuteFile)) { this.SecurityAttributes.Add("ExecuteFile"); }
                    if (rule.FileSystemRights.HasFlag(FileSystemRights.FullControl)) { this.SecurityAttributes.Add("FullControl"); }
                }                
            }
            return Task.CompletedTask;            
        }
    }


    internal sealed class FileSystemAccess : Access
    {
        /// <summary>
        /// Removes a rule the file has.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="account">DomainName\AccountName </param>
        /// <param name="right">The system right the file has.</param>
        /// <returns>True if method completed appropriate stages, false if not.</returns>
        public override bool RemoveRule(string file, string account, FileSystemRights right)
        {
            
            FileSecurity fileSecurity = File.GetAccessControl(path: file);
            var rules = fileSecurity.GetAccessRules(includeExplicit: true, includeInherited: true, typeof(NTAccount)).OfType<FileSystemAccessRule>();                      

            foreach (FileSystemAccessRule rule in rules)
            {
                if(rule.FileSystemRights.HasFlag(right))
                {                               
                    fileSecurity.RemoveAccessRuleSpecific(new FileSystemAccessRule(identity: account, fileSystemRights: right, AccessControlType.Allow));                    
                    File.SetAccessControl(path: file, fileSecurity: fileSecurity);
                    return true;                    
                }
            }
            return false;
        }


        /// <summary>
        /// Removes a rule the file has.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="account">DomainName\AccountName </param>
        /// <param name="right">The system right the file has.</param>
        /// <returns>True if method completed appropriate stages, false if not.</returns>
        public override bool RemoveAllRules(string file, string account, FileSystemRights right)
        {

            FileSecurity fileSecurity = File.GetAccessControl(path: file);
            var rules = fileSecurity.GetAccessRules(includeExplicit: true, includeInherited: true, typeof(NTAccount)).OfType<FileSystemAccessRule>();

            foreach (FileSystemAccessRule rule in rules)
            {
                if (rule.FileSystemRights.HasFlag(right))
                {
                    fileSecurity.RemoveAccessRuleAll(new FileSystemAccessRule(identity: account, fileSystemRights: right, AccessControlType.Allow));
                    File.SetAccessControl(path: file, fileSecurity: fileSecurity);
                    return true;
                }
            }
            return false;
        }

        public async Task LoadAccessRights(string file)
        {
            await GetAccessControls(file: file);
        }
    }
}
