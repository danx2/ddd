using Microsoft.EntityFrameworkCore;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SaleItemConfiguration : IEntityTypeConfiguration<SaleItem>
    {
        public void Configure(EntityTypeBuilder<SaleItem> builder)
        {
            builder.ToTable("SaleItems");

            builder.HasKey(s => s.Id);
            builder.Property(s => s.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(s => s.Product).IsRequired();
            builder.Property(s => s.Quantity).IsRequired();
            builder.Property(s => s.UnitPrice).IsRequired();
            builder.Property(s => s.Discount).IsRequired();
            builder.Property(s => s.TotalAmount).IsRequired();  
        }
    }
}
