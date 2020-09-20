﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WordCounter.WinFormsClient.Interfaces;

namespace WordCounter.WinFormsClient.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView(IToolbarView toolbarView, ITextInputView textInputView, IWordCounterView wordCounterView)
        {
            InitializeComponent();
        }
    }
}