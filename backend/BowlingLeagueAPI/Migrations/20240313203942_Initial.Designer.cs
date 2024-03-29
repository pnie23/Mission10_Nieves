﻿// <auto-generated />
using System;
using BowlingLeagueAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BowlingLeagueAPI.Migrations
{
    [DbContext(typeof(BowlingLeagueContext))]
    [Migration("20240313203942_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("BowlingLeagueAPI.Data.Bowler", b =>
                {
                    b.Property<int>("BowlerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BowlerAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerCity")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerFirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerLastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerMiddleInit")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerPhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerState")
                        .HasColumnType("TEXT");

                    b.Property<string>("BowlerZip")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeamID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BowlerID");

                    b.HasIndex("TeamID");

                    b.ToTable("Bowlers");
                });

            modelBuilder.Entity("BowlingLeagueAPI.Data.Team", b =>
                {
                    b.Property<int>("TeamID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CaptainID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeamID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("BowlingLeagueAPI.Data.Bowler", b =>
                {
                    b.HasOne("BowlingLeagueAPI.Data.Team", "Teams")
                        .WithMany()
                        .HasForeignKey("TeamID");

                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
