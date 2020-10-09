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
    public partial class AboutView : Form, IAboutView
    {
        public event EventHandler ViewLoad;

        public AboutView()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            this.Load += ViewLoad;
        }

        public void SetAboutText(string text)
        {
            richTextBox1.Text = text;            
        }

        public void ShowView()
        {
            ViewLoad.Invoke(this, EventArgs.Empty);
            Show();
        }
    }
}
