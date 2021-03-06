﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Model.ModelInterfaces
{
    public interface IFileSelectionModel
    {
        void Display();
        string FilePath { get; set; }
        event EventHandler DisplayDialogRequest;
    }
}
