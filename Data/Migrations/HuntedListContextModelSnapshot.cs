﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(HuntedListContext))]
    partial class HuntedListContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.HuntedList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("HuntedList");
                });

            modelBuilder.Entity("Models.HuntedListCharacter", b =>
                {
                    b.Property<int>("HuntedListId");

                    b.Property<int>("TibiaCharacterId");

                    b.HasKey("HuntedListId", "TibiaCharacterId");

                    b.HasIndex("TibiaCharacterId");

                    b.ToTable("HuntedListCharacter");
                });

            modelBuilder.Entity("Models.HuntingSpot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("HuntingSpot");
                });

            modelBuilder.Entity("Models.HuntingSpotCharacter", b =>
                {
                    b.Property<int>("HuntingSpotId");

                    b.Property<int>("TibiaCharacterId");

                    b.HasKey("HuntingSpotId", "TibiaCharacterId");

                    b.HasIndex("TibiaCharacterId");

                    b.ToTable("HuntingSpotCharacter");
                });

            modelBuilder.Entity("Models.TibiaCharacter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GuildName");

                    b.Property<bool>("IsOnline");

                    b.Property<DateTime>("LastLogin");

                    b.Property<DateTime>("LatestDeath");

                    b.Property<string>("LatestDeathBy");

                    b.Property<int>("Level");

                    b.Property<string>("Name");

                    b.Property<string>("Residence");

                    b.Property<string>("Vocation");

                    b.Property<string>("World");

                    b.HasKey("Id");

                    b.ToTable("TibiaCharacter");
                });

            modelBuilder.Entity("Models.HuntedListCharacter", b =>
                {
                    b.HasOne("Models.HuntedList", "HuntedList")
                        .WithMany("HuntedListCharacters")
                        .HasForeignKey("HuntedListId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Models.TibiaCharacter", "TibiaCharacter")
                        .WithMany("HuntedListCharacters")
                        .HasForeignKey("TibiaCharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Models.HuntingSpotCharacter", b =>
                {
                    b.HasOne("Models.HuntingSpot", "HuntingSpot")
                        .WithMany("HuntingSpotCharacters")
                        .HasForeignKey("HuntingSpotId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Models.TibiaCharacter", "TibiaCharacter")
                        .WithMany("HuntingSpotCharacters")
                        .HasForeignKey("TibiaCharacterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
