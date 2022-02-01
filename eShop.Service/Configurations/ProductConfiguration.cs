using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eShop.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eShop.Service.Configurations
{
    //public class VariantOptionConfiguration : IEntityTypeConfiguration<VariantOption>
    //{
    //    public void Configure(EntityTypeBuilder<VariantOption> builder)
    //    {
    //        builder.HasOne<Variant>(x => x.Variant)
    //               .WithMany(x => x.Options)
    //               .HasForeignKey(x => x.VariantId);
                   
    //    }
    //}

    //public class VariantConfiguration : IEntityTypeConfiguration<Variant>
    //{
    //    public void Configure(EntityTypeBuilder<Variant> builder)
    //    {
    //        builder.HasOne<Product>(x => x.Product)
    //            .WithMany(x => x.Variants)
    //            .HasForeignKey( x => x.ProudctId);
    //    }
    //}

    //public class ProductConfiguration : IEntityTypeConfiguration<Product>
    //{
    //    public void Configure(EntityTypeBuilder<Product> builder)
    //    {
    //       builder.HasMany<Variant>(x => x.Variants)
    //            .WithOne(x => x.Product)
    //            .HasForeignKey(x => x.ProudctId);
    //    }
    //}
}
