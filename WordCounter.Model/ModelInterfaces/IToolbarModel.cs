using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model.ModelInterfaces
{
    public interface IToolbarModel
    {
        event EventHandler ButtonRunClick;
        event EventHandler ButtonOpenFileClick;
        event EventHandler ButtonAboutClick;
        event EventHandler ButtonExitClick;

        void OpenFile();
        void Run();
        void About();
        void Exit();
    }
}
