using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morningstar.Core.Foundation.FileOperations
{
    interface IUserFileOperations
    {
        /// <summary>
        /// Attempts loading selected file from user.
        /// </summary>        
        /// <returns>True if file was loaded, False if error.</returns>
        Task<string> Load();
    }
}
