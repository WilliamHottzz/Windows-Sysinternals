using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dnlib.DotNet;
using dnlib.DotNet.Emit;


namespace Morningstar.Core.Foundation.DotNetOperations
{
    abstract class AssemblyClassNames : DotNetOperationsConstants
    {
        /// <summary>
        /// Collection of class names from assembly.
        /// </summary>
        public List<string> AssemblyClasses = new List<string>();


        public AssemblyClassNames() { }


        /// <summary>
        /// Get all class names from .NET assembly.
        /// </summary>
        /// <param name="netassembly">.NET assembly file.</param>
        /// <returns>Completed task, notification on fails</returns>
        internal Task GetClassNames(string netassembly)
        {
            ModuleContext modulecontext = ModuleDef.CreateModuleContext();
            ModuleDefMD module = null;

            try
            {
                module = ModuleDefMD.Load(fileName: netassembly, context: modulecontext);
            }
            catch (BadImageFormatException)
            {
                MessageBox.Show(text: ErrorAssemblyNotDotNet);
                return Task.CompletedTask;
            }

            if(module != null)
            {
                foreach (var item in module.GetTypes())
                {
                    if (item.IsClass)
                    {
                        AssemblyClasses.Add(item.Name);
                    }
                }
            }
            else
            {
                MessageBox.Show(text: ModuleWasEmpty);
            }

            module.Dispose();
            return Task.CompletedTask;
        }
    }


    internal sealed class ClassNames : AssemblyClassNames
    {
        public async void ReadAll(string filename)
        {
            await GetClassNames(filename);
        }
    }
}
