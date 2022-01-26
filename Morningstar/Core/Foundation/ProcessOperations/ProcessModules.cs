using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morningstar.Core.Foundation.ProcessOperations
{
    abstract class ProcessModules
    {
        public List<string> ModuleNames = new List<string>();
        

        internal bool GetModules(int pid)
        {
            ProcessOperationConstants constants = new ProcessOperationConstants();
            Process process = null;

            try
            {
                process = Process.GetProcessById(pid);
            }
            catch (Exception)   //  Default
            {
                return false;
            }

            ProcessModule processModule = null;
            ProcessModuleCollection myProcessModuleCollection = null;

            try
            {
                myProcessModuleCollection = process.Modules;
            }
            catch (Win32Exception)
            {
                MessageBox.Show(constants.ErrorWin32Process);
                return false;
            }
            
            
            for (int i = 0; i < myProcessModuleCollection.Count; i++)
            {
                processModule = myProcessModuleCollection[i];

                //  [0] = Entry Adress
                //  [1] = Base Adress
                //  [2] = Name             
                ModuleNames.Add(processModule.EntryPointAddress.ToString() + "," + processModule.BaseAddress + "," + processModule.ModuleName);
            }
            
            return true;
        }
    }

    internal sealed class Modules : ProcessModules
    {
        public bool Read32(int pid)
        {
            return GetModules(pid);          
        }
    }
}
