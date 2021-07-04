using Projeto1.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
