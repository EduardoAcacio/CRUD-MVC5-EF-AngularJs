using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpNext.Domain.Entities
{
    public class Income
    {
        public int IncomeId { get; private set; }

        public string Type { get; private set; }

        public string Description { get; private set; }

        public DateTime CollectionDate { get; private set; }

        public DateTime RegistrationDate { get; private set; }

        public bool Delayed { get; set; }

        public bool Active { get; private set; }

        public bool IsDelayed(Income income)
        {
            return income.Active && DateTime.Now.CompareTo(income.CollectionDate) > 0;
        }
    }
}
