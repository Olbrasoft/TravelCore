﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Olbrasoft.Travel.Data.Base.Objects.Identity;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Identity
{
    public class UserRoleConfiguration : TravelTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration() : base("UsersRoles")
        {
        }

        public override void Configuration(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(p => new { p.UserId, p.RoleId });
        }
    }
}