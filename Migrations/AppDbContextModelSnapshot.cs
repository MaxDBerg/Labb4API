﻿// <auto-generated />
using Hobbies.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hobbies.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hobbies.Models.Interest", b =>
                {
                    b.Property<int>("InterestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InterestID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InterestID");

                    b.ToTable("Interests");
                });

            modelBuilder.Entity("Hobbies.Models.Link", b =>
                {
                    b.Property<int>("LinkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LinkID"));

                    b.Property<int>("InterestID")
                        .HasColumnType("int");

                    b.Property<string>("LinkURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.HasKey("LinkID");

                    b.HasIndex("InterestID");

                    b.HasIndex("PersonID");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("Hobbies.Models.Person", b =>
                {
                    b.Property<int>("PersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("InterestPerson", b =>
                {
                    b.Property<int>("InterestsInterestID")
                        .HasColumnType("int");

                    b.Property<int>("PersonsPersonID")
                        .HasColumnType("int");

                    b.HasKey("InterestsInterestID", "PersonsPersonID");

                    b.HasIndex("PersonsPersonID");

                    b.ToTable("InterestPerson");
                });

            modelBuilder.Entity("Hobbies.Models.Link", b =>
                {
                    b.HasOne("Hobbies.Models.Interest", "Interest")
                        .WithMany()
                        .HasForeignKey("InterestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hobbies.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Interest");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("InterestPerson", b =>
                {
                    b.HasOne("Hobbies.Models.Interest", null)
                        .WithMany()
                        .HasForeignKey("InterestsInterestID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hobbies.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonsPersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
