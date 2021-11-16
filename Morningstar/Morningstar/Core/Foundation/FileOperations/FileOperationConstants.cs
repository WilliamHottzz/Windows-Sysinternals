using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Morningstar.Core.Foundation.FileOperations
{
    internal class FileOperationConstants
    {
        public const string FileTypeFilter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
        public const string FileAttributeIsTrue  = "Yes";
        public const string FileAttributeIsFalse = "No";
        public const string FailedValueCatch = "N/A";


       public Dictionary<string, FileSystemRights> stuff = new Dictionary<string, FileSystemRights>()
            {
                { "Write", FileSystemRights.Write},
                { "Read" , FileSystemRights.Read},
                { "WriteData", FileSystemRights.WriteData},
                { "WriteAttributes", FileSystemRights.WriteAttributes},
                { "ReadData", FileSystemRights.ReadData},
                { "ReadAndExecute", FileSystemRights.ReadAndExecute},
                { "ReadPermissions", FileSystemRights.ReadPermissions},
                { "ChangePermissions", FileSystemRights.ChangePermissions},
                { "CreateFiles", FileSystemRights.CreateFiles},
                { "CreateDirectories", FileSystemRights.CreateDirectories},
                { "FullControl", FileSystemRights.FullControl},
                { "Delete", FileSystemRights.Delete}
            };
    }
}
