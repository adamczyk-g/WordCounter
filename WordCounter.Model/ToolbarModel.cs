using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Model
{
    public class ToolbarModel : IToolbarModel
    {
        public event EventHandler ButtonRunClick;
        public event EventHandler ButtonOpenFileClick;
        public event EventHandler ButtonAboutClick;
        public event EventHandler ButtonExitClick;

        public ToolbarModel() {  }

        public void OpenFile() => ButtonOpenFileClick.Invoke(this, null);

        public void Run() =>  ButtonRunClick.Invoke(this, null);

        public void About() => ButtonAboutClick.Invoke(this, null);

        public void Exit() => ButtonExitClick.Invoke(this, null);
    }
}
