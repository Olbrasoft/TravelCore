﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Olbrasoft.Travel.Data.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Localization;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Accommodation
{
    public class LocalizedAttributeConfiguration : LocalizedConfiguration<LocalizedAttribute>
    {
        public override void ConfigureLocalized(EntityTypeBuilder<LocalizedAttribute> builder)
        {
            builder.Property(p => p.Description).HasMaxLength(255).IsRequired();

            builder.HasOne(localizedAttribute => localizedAttribute.Attribute)
                .WithMany(attribute => attribute.LocalizedAttributes)
                .HasForeignKey(localizedAttribute => localizedAttribute.Id).OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(localizedAttribute => localizedAttribute.Language)
                .WithMany(language => language.LocalizedAttributes).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(localizedAttribute => localizedAttribute.Creator).WithMany(user => user.LocalizedAttributes)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}