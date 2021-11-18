using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Morningstar.Core.Foundation.FileOperations
{
    abstract class Properties
    {

        /// <summary>
        /// Current working directory of the file.
        /// </summary>
        public string WorkingDirectory { get; set; }
        /// <summary>
        /// The original file name / module name.
        /// </summary>
        public string OriginalFileName { get; set; }
        /// <summary>
        /// Date the file was create, UTC.
        /// </summary>
        public string CreationDate { get; set; }
        /// <summary>
        /// Date the file was last accessed, UTC.
        /// </summary>
        public string AccessedDate { get; set; }
        /// <summary>
        /// Date the file was last modified, UTC.
        /// </summary>
        public string ModifiedDate { get; set; }
        /// <summary>
        /// Owner of the file.
        /// </summary>
        public string Owner { get; set; }
        /// <summary>
        /// File size in Kb.
        /// </summary>
        public string Size { get; set; }


        //public Properties() { }


        /// <summary>
        /// General file properties.
        /// </summary>
        /// <param name="file">User Selected file.</param>
        /// <returns>Completed task.</returns>
        internal Task GetGeneral(string file)
        {
            var generalfileinformation = new FileInfo(file);

            this.WorkingDirectory = generalfileinformation.DirectoryName;
            this.OriginalFileName = generalfileinformation.Name;
            this.CreationDate = generalfileinformation.CreationTimeUtc.ToString();
            this.AccessedDate = generalfileinformation.LastAccessTimeUtc.ToString();
            this.ModifiedDate = generalfileinformation.LastWriteTimeUtc.ToString();
            this.Owner = System.IO.File.GetAccessControl(file).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
            long size  = generalfileinformation.Length / 1024;
            this.Size  = size.ToString() + "Kb";

            return Task.CompletedTask;
        }
    }


    internal sealed class FileProperty : Properties
    {
        public async Task LoadProperties(string file)
        {
            await GetGeneral(file);           
        }

        private void Clean()
        {            
            PropertyInfo[] properties = typeof(Properties).GetProperties();            
            foreach(PropertyInfo property in properties)
            {
                //property.SetValue(var n, null);
            }
        }
    }
}

        

        
 
