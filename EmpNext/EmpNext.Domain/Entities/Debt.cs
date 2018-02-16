using System;

namespace EmpNext.Domain.Entities
{
    public class Debt
    {
        public int DebtId { get; private set; }

        public string Description { get; private set; }

        public DateTime PaymentDate { get; private set; } 

        public DateTime MaturityDate { get; private set; }

        public DateTime RegistrationDate { get; private set; }

        public bool Delayed { get; set; }

        public bool Active { get; private set; }

        public bool IsDelayed(Debt debt)
        {
            return debt.Active && DateTime.Now.CompareTo(debt.MaturityDate) > 0;
        }
    }
}