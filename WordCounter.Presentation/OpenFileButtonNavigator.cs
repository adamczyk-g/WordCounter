using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Presentation.ViewInterfaces;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Presentation
{
    public class OpenFileButtonNavigator
    {
        private readonly IOpenFileModel openFileModel;

        public OpenFileButtonNavigator(IToolbarView toolbarView, IOpenFileModel openFileModel)
        {
            toolbarView.ButtonOpenFileClick += OnOpenFileClick;

            this.openFileModel = openFileModel;
        }

        private void OnOpenFileClick(object obj, EventArgs e)
        {
            openFileModel.ReadFileContent(@"D:\ebook.txt");
        }
    }
}
