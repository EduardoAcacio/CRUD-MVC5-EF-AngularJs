using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpNext.Domain.Entities
{
    public class Client
    {
        public int ClientId { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Email { get; private set; }

        public DateTime RegistrationDate { get; private set; }

        public bool Active { get; private set; }

        public bool SpecialClient(Client client)
        {
            return client.Active && DateTime.Now.Year - client.RegistrationDate.Year >= 5;
        }
    }
}
