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

        public OpenFileView()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }

        public void ShowView()
        {
            Result = openFileDialog.ShowDialog();
        }

        public DialogResult Result { get; private set; }
    }
}
