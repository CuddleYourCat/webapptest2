﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PhoneBookTestApp.Data;

namespace PhoneBookTestApp.Data.Migrations
{
    [DbContext(typeof(PhoneBookContext))]
    [Migration("20200221110017_initial-seed")]
    partial class initialseed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("PhoneBookTestApp.Data.Entities.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("State")
                        .HasColumnType("TEXT")
                        .HasMaxLength(2);

                    b.Property<string>("StreetAddress")
                        .HasColumnType("TEXT");

                    b.Property<string>("Suburb")
                        .HasColumnType("TEXT");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            FirstName = "Chris",
                            LastName = "Johnson",
                            PhoneNumber = "(321) 231-7876",
                            State = "MI",
                            StreetAddress = "452 Freeman Drive",
                            Suburb = "Algonac"
                        },
                        new
                        {
                            PersonId = 2,
                            FirstName = "Dave",
                            LastName = "Williams",
                            PhoneNumber = "(231) 502-1236",
                            State = "MI",
                            StreetAddress = "285 Huron Street",
                            Suburb = "Port Austin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
