using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morningstar.Core.Foundation.FileOperations
{
    abstract class Attributes : FileOperationConstants
    {
        /// <summary>
        /// File is read only.
        /// </summary>
        public string ReadOnly { get; set; }
        /// <summary>
        /// File is hidden.
        /// </summary>
        public string Hidden { get; set; }
        /// <summary>
        /// File is a system file.
        /// </summary>
        public string System { get; set; }
        /// <summary>
        /// Normal file.
        /// </summary>
        public string Normal { get; set; }
        /// <summary>
        /// Offline file.
        /// </summary>
        public string Offline { get; set; }
        /// <summary>
        /// Archive file.
        /// </summary>
        public string Archive { get; set; }
        /// <summary>
        /// File is encrypted.
        /// </summary>
        public string Encrypted { get; set; }


        public Attributes() { }

        /// <summary>
        /// Gets file attributes.
        /// </summary>
        /// <param name="file">User selected file.</param>
        /// <returns>A completed task.</returns>
        internal Task GetAttributes(string file)
        {
            FileAttributes attributes = File.GetAttributes(file);

            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) { this.ReadOnly = FileOperationConstants.FileAttributeIsTrue; } else { this.ReadOnly = FileOperationConstants.FileAttributeIsFalse; }
            if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden) { this.Hidden = FileOperationConstants.FileAttributeIsTrue; } else { this.Hidden = FileOperationConstants.FileAttributeIsFalse; }
            if ((attributes & FileAttributes.System) == FileAttributes.System) { this.System = FileOperationConstants.FileAttributeIsTrue; } else { this.System = FileOperationConstants.FileAttributeIsFalse; }
            if ((attributes & FileAttributes.Normal) == FileAttributes.Normal) { this.Normal = FileOperationConstants.FileAttributeIsTrue; } else { this.Normal = FileOperationConstants.FileAttributeIsFalse; }
            if ((attributes & FileAttributes.Offline) == FileAttributes.Offline) { this.Offline = FileOperationConstants.FileAttributeIsTrue; } else { this.Offline = FileOperationConstants.FileAttributeIsFalse; }
            if ((attributes & FileAttributes.Archive) == FileAttributes.Archive) { this.Archive = FileOperationConstants.FileAttributeIsTrue; } else { this.Archive = FileOperationConstants.FileAttributeIsFalse; }
            if ((attributes & FileAttributes.Encrypted) == FileAttributes.Encrypted) { this.Encrypted = FileOperationConstants.FileAttributeIsTrue; } else { this.Encrypted = FileOperationConstants.FileAttributeIsFalse; }

            return Task.CompletedTask;
        }
    }

    internal sealed class FileAttribute : Attributes
    {
        public async Task LoadAttributes(string file)
        {
            await GetAttributes(file);
        }
    }
}
