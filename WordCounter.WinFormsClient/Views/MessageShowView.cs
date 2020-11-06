using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using System.Windows.Forms;

namespace WordCounter.WinFormsClient.Views
{
    public class MessageShowView: IMessageShowView
    {
        public MessageShowView() { }

        public void ShowView()
        {
            MessageBox.Show(Message);
        }

        public string Message { get; set; }
    }
}
