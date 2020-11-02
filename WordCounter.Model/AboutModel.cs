using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCounter.Model.ModelInterfaces;

namespace WordCounter.Model
{
    public class AboutModel: IAboutModel
    {
        public string AboutText { get { return "Something about WordCounter ..."; } }
    }
}
