﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Olbrasoft.Travel.Data.Base.Objects.Accommodation;

namespace Olbrasoft.Travel.Data.EntityFrameworkCore.Configurations.Accommodation
{
    public class RoomConfiguration : TravelTypeConfiguration<Room>
    {
        public override void Configuration(EntityTypeBuilder<Room> builder)
        {
            builder.HasOne(tor => tor.Creator).WithMany(u => u.Rooms).OnDelete(DeleteBehavior.Restrict);
        }
    }
}