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
        public event EventHandler ViewShown;
        public event EventHandler ViewClose;

        public AboutView()
        {
            InitializeComponent();
            richTextBox1.ReadOnly = true;
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;

            this.Load += ViewLoad;
            this.Shown += OnFormShown;
            this.FormClosing += OnFormClosing;
        }

        public void SetAboutText(string text)
        {
            richTextBox1.Text = text;            
        }

        public void ShowView()
        {
            Show();
        }

        public void HideView()
        {
            Hide();
        }

        private void OnFormShown(Object obj, EventArgs e)
        {
            ViewShown.Invoke(this, EventArgs.Empty);
        }
        
        private void OnFormClosing(Object obj, FormClosingEventArgs e)
        {
            ViewClose.Invoke(this, FormClosingEventArgs.Empty);
        }
        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            OnFormClosing(this, e);
            e.Cancel = true;
        }
    }
}
