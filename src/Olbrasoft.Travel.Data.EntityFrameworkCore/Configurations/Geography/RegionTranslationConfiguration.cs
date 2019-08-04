﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Olbrasoft.Travel.Data.Base.Objects.Geography;
using Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Localization;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Geography
{
    public class RegionTranslationConfiguration : Localization.TranslationConfiguration<RegionTranslation>
    {
        public RegionTranslationConfiguration() : base("RegionsTranslations")
        {
        }

        public override void ConfigureTranslation(EntityTypeBuilder<RegionTranslation> builder)
        {
            builder.HasIndex(p => p.Name);

            builder.HasOne(p => p.Region).WithMany(p => p.RegionTranslations).HasForeignKey(p => p.Id);

            builder.HasOne(lr => lr.Creator).WithMany(user => user.LocalizedRegions).OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(lr => lr.Language).WithMany(l => l.RegionsTranslations).OnDelete(DeleteBehavior.Restrict);
        }
    }
}