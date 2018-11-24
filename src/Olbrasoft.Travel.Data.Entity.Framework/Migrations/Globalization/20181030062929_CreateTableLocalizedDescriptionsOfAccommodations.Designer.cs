﻿// <auto-generated />
using System;
using GeoAPI.Geometries;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Olbrasoft.Travel.Data.Entity.Framework;

namespace Olbrasoft.Travel.Data.Entity.Framework.Migrations.Globalization
{
    [DbContext(typeof(GlobalizationDatabaseContext))]
    [Migration("20181030062929_CreateTableLocalizedDescriptionsOfAccommodations")]
    partial class CreateTableLocalizedDescriptionsOfAccommodations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-preview3-35497")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.Airport", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("CreatorId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Airports","Geography");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.Country", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("CreatorId");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("Countries","Geography");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<IPoint>("CenterCoordinates")
                        .HasColumnType("geography");

                    b.Property<IPolygon>("Coordinates")
                        .HasColumnType("geography");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<long>("EanId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Regions","Geography");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.RegionToRegion", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("ToId");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.HasKey("Id", "ToId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ToId");

                    b.ToTable("RegionsToRegions","Geography");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.RegionToType", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("ToId");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int?>("SubClassId");

                    b.HasKey("Id", "ToId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("SubClassId");

                    b.HasIndex("ToId");

                    b.ToTable("RegionsToTypes","Geography");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.SubClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("SubClasses","Geography");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.TypeOfRegion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("Description")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TypesOfRegions","Geography");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.Language", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("EanLanguageCode")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("EanLanguageCode")
                        .IsUnique();

                    b.ToTable("Languages","Globalization");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.LocalizedAccommodation", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("LanguageId");

                    b.Property<string>("CheckInTime")
                        .HasMaxLength(10);

                    b.Property<string>("CheckOutTime")
                        .HasMaxLength(10);

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Location")
                        .HasMaxLength(80);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("Id", "LanguageId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LanguageId");

                    b.ToTable("LocalizedAccommodations","Globalization");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.LocalizedDescriptionOfAccommodation", b =>
                {
                    b.Property<int>("AccommodationId");

                    b.Property<int>("TypeOfDescriptionId");

                    b.Property<int>("LanguageId");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("AccommodationId", "TypeOfDescriptionId", "LanguageId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LanguageId");

                    b.HasIndex("TypeOfDescriptionId");

                    b.ToTable("LocalizedDescriptionsOfAccommodations","Globalization");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.LocalizedRegion", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("LanguageId");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("LongName")
                        .HasMaxLength(510);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id", "LanguageId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LanguageId");

                    b.ToTable("LocalizedRegions","Globalization");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.LocalizedTypeOfAccommodation", b =>
                {
                    b.Property<int>("Id");

                    b.Property<int>("LanguageId");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id", "LanguageId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("LanguageId");

                    b.ToTable("LocalizedTypesOfAccommodations","Globalization");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("Users","Identity");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Property.Accommodation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditionalAddress")
                        .HasMaxLength(50);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("AirportId");

                    b.Property<IPoint>("CenterCoordinates")
                        .IsRequired();

                    b.Property<int>("ChainId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<int>("CountryId");

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("EanId");

                    b.Property<int>("SequenceNumber");

                    b.Property<decimal>("StarRating");

                    b.Property<int>("TypeOfAccommodationId");

                    b.HasKey("Id");

                    b.HasIndex("AirportId");

                    b.HasIndex("ChainId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("EanId")
                        .IsUnique();

                    b.HasIndex("TypeOfAccommodationId");

                    b.ToTable("Accommodations","Property");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Property.Chain", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("EanId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("EanId")
                        .IsUnique();

                    b.ToTable("Chains","Property");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Property.TypeOfAccommodation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<int>("EanId");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("EanId")
                        .IsUnique();

                    b.ToTable("TypesOfAccommodations","Property");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Property.TypeOfDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatorId");

                    b.Property<DateTime>("DateAndTimeOfCreation")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("TypesOfDescriptions","Property");
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.Airport", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("Airports")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.Region", "Region")
                        .WithOne("ExpandingInformationAboutAirport")
                        .HasForeignKey("Olbrasoft.Travel.Data.Entity.Geography.Airport", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.Country", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("Countries")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.Region", "Region")
                        .WithOne("ExpandingInformationAboutCountry")
                        .HasForeignKey("Olbrasoft.Travel.Data.Entity.Geography.Country", "Id")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.Region", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("Regions")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.RegionToRegion", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("RegionsToRegions")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.Region", "Region")
                        .WithMany("ToChildRegions")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.Region", "ParentRegion")
                        .WithMany("ToParentRegions")
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.RegionToType", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("RegionsToTypes")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.Region", "Region")
                        .WithMany("RegionsToTypes")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.SubClass", "SubClass")
                        .WithMany()
                        .HasForeignKey("SubClassId");

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.TypeOfRegion", "TypeOfRegion")
                        .WithMany("RegionsToTypes")
                        .HasForeignKey("ToId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.SubClass", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("SubClasses")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Geography.TypeOfRegion", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("TypesOfRegions")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.Language", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("Languages")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.LocalizedAccommodation", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("LocalizedAccommodations")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Property.Accommodation", "Accommodation")
                        .WithMany("LocalizedAccommodations")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Globalization.Language", "Language")
                        .WithMany("LocalizedAccommodations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.LocalizedDescriptionOfAccommodation", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Property.Accommodation", "Accommodation")
                        .WithMany("LocalizedDescriptionsOfAccommodations")
                        .HasForeignKey("AccommodationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("LocalizedDescriptionsOfAccommodations")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Globalization.Language", "Language")
                        .WithMany("LocalizedDescriptionsOfAccommodations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Property.TypeOfDescription", "TypeOfDescription")
                        .WithMany("LocalizedDescriptionsOfAccommodations")
                        .HasForeignKey("TypeOfDescriptionId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.LocalizedRegion", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("LocalizedRegions")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.Region", "Region")
                        .WithMany("LocalizedRegions")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Globalization.Language", "Language")
                        .WithMany("LocalizedRegions")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Globalization.LocalizedTypeOfAccommodation", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("LocalizedTypesOfAccommodations")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Property.TypeOfAccommodation", "TypeOfAccommodation")
                        .WithMany("LocalizedTypesOfAccommodations")
                        .HasForeignKey("Id")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Globalization.Language", "Language")
                        .WithMany("LocalizedTypesOfAccommodations")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Property.Accommodation", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.Airport", "Airport")
                        .WithMany()
                        .HasForeignKey("AirportId");

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Property.Chain", "Chain")
                        .WithMany("Accommodations")
                        .HasForeignKey("ChainId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Geography.Country", "Country")
                        .WithMany("Accommodations")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("Accommodations")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Olbrasoft.Travel.Data.Entity.Property.TypeOfAccommodation", "TypeOfAccommodation")
                        .WithMany()
                        .HasForeignKey("TypeOfAccommodationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Property.Chain", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("Chains")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Property.TypeOfAccommodation", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("TypesOfAccommodations")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Olbrasoft.Travel.Data.Entity.Property.TypeOfDescription", b =>
                {
                    b.HasOne("Olbrasoft.Travel.Data.Entity.Identity.User", "Creator")
                        .WithMany("TypesOfDescriptions")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
