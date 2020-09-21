using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordCounter.Presentation.ViewInterfaces;

namespace WordCounter.WinFormsClient.Views
{
    public partial class ToolbarView : Form, IToolbarView
    {
        public ToolbarView()
        {
            InitializeComponent();
        }

        public event EventHandler ButtonOpenFileClick { add { ButtonOpenFile.Click += new EventHandler(value); } remove { ButtonOpenFile.Click -= new EventHandler(value); } }
        public event EventHandler ButtonRunClick { add { ButtonRun.Click += new EventHandler(value); } remove { ButtonRun.Click -= new EventHandler(value); } }        
        public event EventHandler ButtonInfoClick { add { ButtonInfo.Click += new EventHandler(value); } remove { ButtonInfo.Click -= new EventHandler(value); } }
        public event EventHandler ButtonExitClick { add { ButtonExit.Click += new EventHandler(value); } remove { ButtonExit.Click -= new EventHandler(value); } }
    }
}
