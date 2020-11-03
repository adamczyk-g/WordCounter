using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model.ModelInterfaces
{
    public class OpenFileErrorEventArgs: EventArgs
    {
        public OpenFileErrorEventArgs(string message) { Message = message; }
        public string Message { get; set; }
    }
}
