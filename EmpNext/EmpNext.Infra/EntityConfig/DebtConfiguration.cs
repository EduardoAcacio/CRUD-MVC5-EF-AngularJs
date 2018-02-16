using EmpNext.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace EmpNext.Infra.EntityConfig
{
    public class DebtConfiguration : EntityTypeConfiguration<Debt>
    {
        public DebtConfiguration()
        {
            HasKey(c => c.DebtId);

            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.PaymentDate)
                .IsRequired();

            Property(c => c.MaturityDate)
                .IsRequired();

            Property(c => c.Delayed)
                .IsRequired();

            Property(c => c.Active)
                .IsRequired();
        }
    }
}
