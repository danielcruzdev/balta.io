using Projeto1.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1.SubscriptionContext
{
    public class Subscription : Base
    {

        public Plan Plan { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsInactive => EndDate <= DateTime.Now;
    }
}
