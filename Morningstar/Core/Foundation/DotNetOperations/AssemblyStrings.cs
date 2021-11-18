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
    abstract class AssemblyStrings : DotNetOperationsConstants
    {
        /// <summary>
        /// Collection of string from assembly.
        /// </summary>
        public List<string> Strings = new List<string>();


        public AssemblyStrings() { }


        /// <summary>
        /// Gets all strings from .NET assembly.
        /// </summary>
        /// <param name="netassembly">.NET assembly file.</param>
        /// <returns>Completed task, notification on fails.</returns>
        internal Task GetAssemblyStrings(string netassembly)
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

            if (module != null)
            {
                foreach (TypeDef type in module.Types)
                {
                    if (type.IsClass)
                    {
                        foreach (MethodDef method in type.Methods)
                        {
                            if (method.Body == null)
                            {
                                continue;
                            }
                            for (int i = 0; i < method.Body.Instructions.Count(); i++)
                            {
                                if (method.Body.Instructions[i].OpCode == OpCodes.Ldstr)
                                {
                                    Strings.Add(item: type.Name + " | " + method.Name + " | " + method.Body.Instructions[i].ToString().Split(new string[] { "ldstr" }, StringSplitOptions.None)[1]);
                                }
                            }
                        }
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


    internal sealed class AssemblyString : AssemblyStrings
    {
        public async void ReadAll(string filename)
        {
            await GetAssemblyStrings(filename);
        }
    }
}
