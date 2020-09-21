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
    public partial class MainView : Form, IMainView
    {
        public MainView(IToolbarView toolbarView, ITextInputView textInputView, IWordCounterView wordCounterView, IStatusBarView statusbarView)
        {
            InitializeComponent();

            ((Form)textInputView).TopLevel = false;
            ((Form)textInputView).FormBorderStyle = FormBorderStyle.None;
            ((Form)textInputView).Show();
            ((Form)textInputView).Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add((Form)textInputView);

            ((Form)wordCounterView).TopLevel = false;
            ((Form)wordCounterView).FormBorderStyle = FormBorderStyle.None;
            ((Form)wordCounterView).Show();
            ((Form)wordCounterView).Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add((Form)wordCounterView);

            ((Form)toolbarView).TopLevel = false;
            ((Form)toolbarView).FormBorderStyle = FormBorderStyle.None;            
            ((Form)toolbarView).Show();
            ((Form)toolbarView).Dock = DockStyle.Fill;
            panel1.Controls.Add((Form)toolbarView);

            panel1.Height = 128;
            splitContainer1.BringToFront();

            ((Form)statusbarView).TopLevel = false;
            ((Form)statusbarView).FormBorderStyle = FormBorderStyle.None;
            ((Form)statusbarView).Show();
            ((Form)statusbarView).Dock = DockStyle.Fill;
            panel2.Controls.Add((Form)statusbarView);
            panel2.Height = ((Form)statusbarView).Height;

        }
    }
}
