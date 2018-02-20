using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpNext.Domain.Entities
{
    public class Card
    {
        public int CardId { get; private set; }

        public string Name { get; private set; }

        public string UserName { get; private set; }

        public DateTime ExpirationDate { get; private set; }

        public decimal Limit { get; private set; }

        public int Number { get; private set; }

        public int SecurityNumber { get; private set; }


    }
}
