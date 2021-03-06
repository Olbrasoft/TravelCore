﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Olbrasoft.Travel.Data.Identity;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.EntityTypesConfigurations.Identity
{
    public class UserLoginConfiguration : TravelTypeConfiguration<UserLogin>
    {
        public UserLoginConfiguration() : base("UsersLogins")
        {
        }

        public override void Configuration(EntityTypeBuilder<UserLogin> builder)
        {
            builder.HasKey(userLogin => new { userLogin.UserId, userLogin.ProviderKey });

            //modelBuilder.Entity<UserLogin>().HasKey(m => new { m.UserId, m.ProviderKey });
        }
    }
}