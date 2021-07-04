using Projeto1.NotificationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.ContentContext
{
    public class Article : Content
    {
        public Article(string title, string url) : base(title, url){}

        public List<Notification> MyProperty { get; set; }
    }
}
