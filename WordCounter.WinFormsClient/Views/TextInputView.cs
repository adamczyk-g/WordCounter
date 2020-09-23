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
    public partial class TextInputView : Form, ITextInputView
    {
        public TextInputView()
        {
            InitializeComponent();
        }

        public event EventHandler TextInputChanged { add { this.richTextBox1.TextChanged += new System.EventHandler(value); } remove { this.richTextBox1.TextChanged -= new System.EventHandler(value); } }

        public string GetText()
        {
            return richTextBox1.Text;
        }
    }
}
