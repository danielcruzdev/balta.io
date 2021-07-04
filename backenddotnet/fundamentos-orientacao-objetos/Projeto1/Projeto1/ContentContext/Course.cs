using Projeto1.ContentContext.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.ContentContext
{
    public class Course : Content
    {
        public Course()
        {
            Modules = new List<Module>();
        }

        public string Tag { get; set; }
        public int DurationInMinutes { get; set; }
        public EcontentLevel Level { get; set; }
        public IList<Module> Modules { get; set; }
    }
}
