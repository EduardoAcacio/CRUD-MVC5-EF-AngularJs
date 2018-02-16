using EmpNext.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EmpNext.Infra.EntityConfig
{
    public class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        public ClientConfiguration()
        {
            HasKey(c => c.ClientId);

            Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Email)
                .IsRequired();
        }
    }
}
