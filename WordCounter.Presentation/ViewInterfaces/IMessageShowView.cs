using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Presentation.ViewInterfaces
{
    public interface IMessageShowView
    {
        void ShowView();
        string Message { get; set; }
    }
}
