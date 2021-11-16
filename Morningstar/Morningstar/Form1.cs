using Morningstar.Core.Foundation.FileOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using Morningstar.Core.Foundation.DotNetOperations;
using Morningstar.Core.Foundation.ProcessOperations;
using System.Diagnostics;
using System.Reflection;

namespace Morningstar
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string UserSelectedFile;
        private int UserStartedProcessPid;
        

        private async void menustrip_OpenFile_Click(object sender, EventArgs e)
        {
            listbox_DotNetClasses.Items.Clear();
            listbox_DotNetStrings.Items.Clear();

            var userfile = new UserFile();
            var userfileproperties = new FileProperty();
            var userfileattributes = new FileAttribute();
            var userfilesystemaccessrights = new FileSystemAccess();
            var assemblyclasses = new ClassNames();
            var assemblystrings = new AssemblyString();
           

            BindingSource userfileaccessrule = new BindingSource();
            

            string selectedfile = string.Empty;           
            selectedfile = await userfile.Load();
            this.UserSelectedFile = selectedfile;

            //  Load .NET classes.

            if (!string.IsNullOrEmpty(this.UserSelectedFile))
            {
                await Task.Run(() =>
                {
                    assemblyclasses.ReadAll(filename: UserSelectedFile);

                    foreach (var item in assemblyclasses.AssemblyClasses)
                    {
                        BackgroundWork.ControlInvoke(listbox_DotNetClasses, () => listbox_DotNetClasses.Items.Add(item));
                    }

                    assemblyclasses.AssemblyClasses = null;
                });
            }

            //  Load .NET strings.

            if (!string.IsNullOrEmpty(this.UserSelectedFile))
            {
                await Task.Run(() =>
                {
                    assemblystrings.ReadAll(filename: UserSelectedFile);

                    foreach (var item in assemblystrings.Strings)
                    {
                        BackgroundWork.ControlInvoke(listbox_DotNetStrings, () => listbox_DotNetStrings.Items.Add(item));                        
                    }

                    assemblystrings.Strings = null;
                });
            }
           

            if (!string.IsNullOrWhiteSpace(selectedfile))
            {
                await userfileproperties.LoadProperties(file: selectedfile);

                // Load file properties.

                label_FilePropertiesName.Text = userfileproperties.OriginalFileName;
                label_FilePropertiesCreationDate.Text = userfileproperties.CreationDate;
                label_FilePropertiesLastAccessed.Text = userfileproperties.AccessedDate;
                label_FilePropertiesLastModified.Text = userfileproperties.ModifiedDate;
                label_FilePropertiesOwner.Text = userfileproperties.Owner;
                label_FilePropertiesSize.Text  = userfileproperties.Size;                

                await userfileattributes.LoadAttributes(file: selectedfile);

                // Load file attributes.

                label_FileAttributeHidden.Text = userfileattributes.Hidden;
                label_FileAttributeNormal.Text = userfileattributes.Normal;
                label_FileAttributeSystem.Text = userfileattributes.System;
                label_FileAttributeOffline.Text  = userfileattributes.Offline;
                label_FileAttributeReadOnly.Text = userfileattributes.ReadOnly;                
                label_FileAttributeEncrypted.Text = userfileattributes.Encrypted;
                label_FileAttributeArchive.Text   = userfileattributes.Archive;

                await userfilesystemaccessrights.LoadAccessRights(file: selectedfile);

                // Load permissions access rights.

                await Task.Run(() => 
                {
                    userfileaccessrule.DataSource = userfilesystemaccessrights.SecurityAttributes;
                    combobox_FilesystemAccessControlList.DataSource = userfileaccessrule;
                });

                //  userfileaccessrule.Dispose();
            }

            if (!string.IsNullOrWhiteSpace(this.UserSelectedFile))
            {
                menuitem_RunUserFile.Enabled = true;
            }           
        }


        private void button_RemoveFileSystemPermission_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.UserSelectedFile))
            {
                var userfilesystemaccessrights = new FileSystemAccess();
                var fileoperationconstants = new FileOperationConstants();

                foreach (KeyValuePair<string, FileSystemRights> right in fileoperationconstants.stuff)
                {
                    if(combobox_FilesystemAccessControlList.SelectedItem.ToString() == right.Key)
                    {
                        MessageBox.Show(combobox_FilesystemAccessControlList.SelectedItem.ToString());

                        if (string.IsNullOrWhiteSpace(this.UserSelectedFile))
                        {
                            MessageBox.Show("name is null");
                            return;
                        }
                        else
                        {                           
                            if(userfilesystemaccessrights.RemoveRule(this.UserSelectedFile, $@"{Environment.UserDomainName}" + @"\" + $@"{Environment.UserName}", right.Value))
                            {
                               
                            }
                            if (!userfilesystemaccessrights.RemoveRule(this.UserSelectedFile, $@"{Environment.UserDomainName}" + @"\" + $@"{Environment.UserName}", right.Value))
                            {
                               
                            }
                        }
                    }
                }                   
            }
        }


        private void button_RemoveAllFileSystemPermission_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.UserSelectedFile))
            {
                var userfilesystemaccessrights = new FileSystemAccess();
                var fileoperationconstants = new FileOperationConstants();

                foreach (KeyValuePair<string, FileSystemRights> right in fileoperationconstants.stuff)
                {
                    if (combobox_FilesystemAccessControlList.SelectedItem.ToString() == right.Key)
                    {
                        MessageBox.Show(combobox_FilesystemAccessControlList.SelectedItem.ToString());

                        if (string.IsNullOrWhiteSpace(this.UserSelectedFile))
                        {
                            MessageBox.Show("name is null");
                            return;
                        }
                        else
                        {
                            if (userfilesystemaccessrights.RemoveAllRules(this.UserSelectedFile, $@"{Environment.UserDomainName}" + @"\" + $@"{Environment.UserName}", right.Value))
                            {

                            }
                            if (!userfilesystemaccessrights.RemoveAllRules(this.UserSelectedFile, $@"{Environment.UserDomainName}" + @"\" + $@"{Environment.UserName}", right.Value))
                            {

                            }
                        }
                    }
                }
            }            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            menuitem_TerminateUserProcess.Enabled = false;
            menuitem_RunUserFile.Enabled = false;
        }

        private async void menuitem_RunUserFile_Click(object sender, EventArgs e)
        {
            var startprocess = new ProcessEnviroment();
            int result = await startprocess.StartProcess(this.UserSelectedFile);
            UserStartedProcessPid = result;

            if (result == -1)
            {
                MessageBox.Show("Failed starting process!");
                return;
            }

            menuitem_TerminateUserProcess.Enabled = true;
            menuitem_RunUserFile.Enabled = false;
        }

        private void menuitem_TerminateUserProcess_Click(object sender, EventArgs e)
        {
            /*
            string asmname = typeof(ProcessEnviroment).AssemblyQualifiedName.ToString();
            var var1 = "Morningstar.Core.Foundation.ProcessOperations.ProcessEnviroment, Morningstar";
            //MessageBox.Show(asmname);
            var var2 = Type.GetType(var1);
            dynamic instance = Activator.CreateInstance(var2);
            */

            using (Process process = Process.GetProcessById(this.UserStartedProcessPid))
            {
                MessageBox.Show(this.UserStartedProcessPid.ToString());
                process.Kill();
            }

            menuitem_TerminateUserProcess.Enabled = false;
            menuitem_RunUserFile.Enabled = true;
        }
    }

    class BackgroundWork
    {
        delegate void UniversalVoidDelegate();

        public static void ControlInvoke(Control control, Action function)
        {
            if (control.IsDisposed || control.Disposing)
                return;

            if (control.InvokeRequired)
            {

                control.Invoke(new UniversalVoidDelegate(() => ControlInvoke(control, function)));
                return;

            }
            function();
        }
    }
}
