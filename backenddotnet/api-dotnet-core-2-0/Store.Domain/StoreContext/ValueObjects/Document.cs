using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Domain.StoreContext.ValueObjects
{
    public class Document
    {
        public string Number { get; private set; }

        public Document(string number)
        {
            Number = number;
        }

        public override string ToString() => Number.ToString();
    }
}
