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
    public class FileSelectionViewPure : IFileSelectionView//: Form, IFileSelectionView
    {
        public FileSelectionViewPure()
        {

        }

        public void ShowView()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            IsFileSelected = openFileDialog.ShowDialog() == DialogResult.OK;
            FilePath = openFileDialog.FileName;
        }

        //wyodrębnić do modelu
        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        public bool IsFileSelected { get; private set; }
        public string FilePath { get; private set; }
    }
}

