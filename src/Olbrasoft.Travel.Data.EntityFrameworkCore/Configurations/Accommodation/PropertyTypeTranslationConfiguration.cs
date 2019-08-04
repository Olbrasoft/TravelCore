﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Olbrasoft.Travel.Data.Base.Objects.Accommodation;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Localization;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Accommodation
{
    public class PropertyTypeTranslationConfiguration : Localization.TranslationConfiguration<PropertyTypeTranslation>
    {
        public override void ConfigureTranslation(EntityTypeBuilder<PropertyTypeTranslation> builder)
        {
            builder.ToTable("PropertyTypesTranslations", nameof(Accommodation));

            builder.Property(p => p.Name).HasMaxLength(256).IsRequired();

            builder.HasOne(p => p.Creator).WithMany(user => user.PropertyTypesTranslations)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Language).WithMany(language => language.PropertyTypesTranslations)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(localizedTypeOfAccommodation => localizedTypeOfAccommodation.PropertyType).WithMany(toa => toa.PropertyTypesTranslations)
                .HasForeignKey(p => p.Id).OnDelete(DeleteBehavior.Cascade);
        }
    }
}