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
    public partial class WordCounterView : Form, IWordCounterView
    {
        public WordCounterView()
        {
            InitializeComponent();
        }

        public void SetWordCounterListData(List<WordCounterListItem> listData)
        {
            dataGridView1.DataSource = listData;
        }
    }
}
