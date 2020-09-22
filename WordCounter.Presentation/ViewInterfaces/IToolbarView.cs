using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Presentation.ViewInterfaces
{
    public interface IToolbarView
    {
        event EventHandler ButtonRunClick;
        event EventHandler ButtonOpenFileClick;
        event EventHandler ButtonInfoClick;
        event EventHandler ButtonExitClick;
    }
}
