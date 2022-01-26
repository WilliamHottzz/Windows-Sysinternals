using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morningstar.Core.Foundation.Message.Error
{
    internal class FailedProcessOperations
    {
        public string FailedStartingProcess = "Failed to start process!";
        public string FailedLoadingProcessModules = "Failed reloading process modules!";
        public string FailedProcessIdNotFound = "Process ID does not exist!";
        public string FailedTerminatingProcess = "Could not terminate process, is it still running?";
        public string FailedProcessNamesDoNotMatch = "Process names do not match! can NOT terminate";
    }
}
