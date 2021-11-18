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
        public int ProcessId { get; set; }
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

            var userStartedProcess = new Process();
            userStartedProcess.StartInfo.FileName = file;
            userStartedProcess.StartInfo.CreateNoWindow = false;
            userStartedProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
            userStartedProcess.Start();            

            //  fill
            
            completed = await SetProcessInformation(id: userStartedProcess.Id, name: userStartedProcess.ProcessName, createwindow: false);
            completionstatus = completed == true ? 1 : 0;

            if (completionstatus == 1)
            {
                MessageBox.Show(ProcessId.ToString() + " " + ProcessName);
                userStartedProcess.Dispose();
                return userStartedProcess.Id;
            }

            userStartedProcess.Dispose();
            return completionstatus;
        }
    }
}
