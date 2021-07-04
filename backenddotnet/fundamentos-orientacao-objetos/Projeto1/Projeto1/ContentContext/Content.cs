using Projeto1.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.ContentContext
{
    public abstract class Content : Base
    {
        public Content(string title, string url)
        {
            //SPOF - Ponto único de falha.
            Title = title;
            Url = url;
        }

        public string Title { get; set; }
        public string Url { get; set; }
    }
}
