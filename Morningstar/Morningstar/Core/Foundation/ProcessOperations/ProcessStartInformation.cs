using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Morningstar.Core.Foundation.ProcessOperations
{
    public abstract class ProcessStartInformation
    {
        public int ProcessId;
        public string ProcessName { get; set; }
        public bool CreateWindow { get; set; }
    }


    internal class ProcessEnviroment : ProcessStartInformation
    {
        private Task<bool> SetProcessInformation(int id, string name, bool createwindow)
        {
            this.ProcessId = id;
            this.ProcessName = name;
            this.CreateWindow = createwindow;

            //  Always return true.

            return Task.FromResult(true);
        }
        public async Task<int> StartProcess(string file)
        {          
            bool completed = false;
            int completionstatus = -1;

            Process userstartedprocess = new Process();
            userstartedprocess.StartInfo.FileName = file;
            userstartedprocess.StartInfo.CreateNoWindow = false;
            userstartedprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            userstartedprocess.Start();            

            //  fill
            
            completed = await SetProcessInformation(id: userstartedprocess.Id, name: userstartedprocess.ProcessName, createwindow: false);
            completionstatus = (completed == true) ? 1 : 0;

            if (completionstatus == 1)
            {
                MessageBox.Show(ProcessId.ToString() + " " + ProcessName);
                return userstartedprocess.Id;
            }
            
            return completionstatus;
        }
    }
}
