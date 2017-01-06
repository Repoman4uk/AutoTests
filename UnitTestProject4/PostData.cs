using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests
{
    public class PostData
    {
        public string Title { get; set; }
        public string Tag { get; set; }
        public PostData(string title, string tag)
        {
            this.Title = title;
            this.Tag = tag;
        }
    }
}
