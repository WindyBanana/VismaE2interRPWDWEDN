﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VismaE2interRPWDWEDN.Data;

namespace VismaE2interRPWDWEDN.Migrations
{
    [DbContext(typeof(VismaE2interRPWDWEDNContext))]
    [Migration("20210307084651_Initilal")]
    partial class Initilal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VismaE2interRPWDWEDN.Models.Ansatt", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oppgave")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PositionEndDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("PositionStartDate")
                        .HasColumnType("Date");

                    b.Property<string>("Stilling")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Ansatt");
                });

            modelBuilder.Entity("VismaE2interRPWDWEDN.Models.Oppgave", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ansatt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OppgaveDato")
                        .HasColumnType("Date");

                    b.Property<string>("Oppgavetittel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stilling")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Oppgave");
                });

            modelBuilder.Entity("VismaE2interRPWDWEDN.Models.Stilling", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ansatt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PositionEndDate")
                        .HasColumnType("Date");

                    b.Property<DateTime>("PositionStartDate")
                        .HasColumnType("Date");

                    b.HasKey("ID");

                    b.ToTable("Stilling");
                });
#pragma warning restore 612, 618
        }
    }
}