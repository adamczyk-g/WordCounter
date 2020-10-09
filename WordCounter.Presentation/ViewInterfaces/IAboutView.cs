using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounter.Presentation.ViewInterfaces
{
    public interface IAboutView
    {
        void SetAboutText(string text);
        void ShowView();
        event EventHandler ViewLoad;
    }
}
