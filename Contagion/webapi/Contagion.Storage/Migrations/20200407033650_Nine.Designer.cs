﻿// <auto-generated />
using Contagion.Storage.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Contagion.Storage.Migrations
{
    [DbContext(typeof(ContagionDbContext))]
    [Migration("20200407033650_Nine")]
    partial class Nine
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Contagion.Storage.Models.User", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("Lat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Lon")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("UserPhone")
                        .HasColumnType("bigint");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 637218094098029167L,
                            Lat = 32.7286784m,
                            Lon = -97.1046912m,
                            UserPhone = 987653432L
                        },
                        new
                        {
                            UserId = 637218094098045090L,
                            Lat = 32.7286784m,
                            Lon = -97.1346912m,
                            UserPhone = 8175550150L
                        },
                        new
                        {
                            UserId = 637218094098045148L,
                            Lat = 32.7566784m,
                            Lon = -97.1146912m,
                            UserPhone = 8175550131L
                        },
                        new
                        {
                            UserId = 637218094098045153L,
                            Lat = 32.7066784m,
                            Lon = -97.0846912m,
                            UserPhone = 8175550117L
                        },
                        new
                        {
                            UserId = 637218094098045155L,
                            Lat = 32.7186784m,
                            Lon = -97.2986532m,
                            UserPhone = 8175550142L
                        },
                        new
                        {
                            UserId = 637218094098045158L,
                            Lat = 32.7413513m,
                            Lon = -97.0846912m,
                            UserPhone = 8175550101L
                        },
                        new
                        {
                            UserId = 637218094098045161L,
                            Lat = 32.7281164m,
                            Lon = -97.1212765m,
                            UserPhone = 8175550148L
                        },
                        new
                        {
                            UserId = 637218094098045164L,
                            Lat = 32.7185123m,
                            Lon = -97.1416348m,
                            UserPhone = 8175550189L
                        });
                });
#pragma warning restore 612, 618
        }
    }
}