using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Morningstar.Core.Foundation.FileOperations
{
    internal sealed class UserFile : FileOperationConstants, IUserFileOperations
    {
        
        /// <summary>
        /// Loads a specific user file.
        /// </summary>
        /// <returns>File path of selected file if true, null string if false</returns>
        public Task<string> Load()
        {
            string file = string.Empty;

            var openFileDialog = new OpenFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory,
                Title = "Open File",
                Filter = FileOperationConstants.FileTypeFilter,
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog.FileName;
            }

            return Task.Run(() => file);
        }
    }
}
