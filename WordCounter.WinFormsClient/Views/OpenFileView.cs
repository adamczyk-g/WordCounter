﻿using System;
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
    public partial class OpenFileView : Form, IOpenFileView
    {
        private OpenFileDialog openFileDialog;
        private DialogResult result;

        public OpenFileView()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }

        public void ShowView()
        {
            result = openFileDialog.ShowDialog();            
        }

        //wyodrębnić do modelu
        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }

        public bool Result { get { return DialogResult.OK == result; } }
        public string FilePath { get { return openFileDialog.FileName; } }
    }
}
