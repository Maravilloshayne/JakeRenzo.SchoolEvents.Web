﻿// <auto-generated />
using System;
using JakeRenzo.Calander.Web.Infrastructures.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JakeRenzo.Calander.Web.Migrations
{
    [DbContext(typeof(DefaultDbContext))]
    partial class DefaultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("JakeRenzo.Calander.Web.Infrastructures.Models.SchoolEvent", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("Description");

                    b.Property<DateTime>("EventEnd");

                    b.Property<DateTime>("EventStart");

                    b.Property<bool>("IsPublished");

                    b.Property<DateTime>("PostExpiry");

                    b.Property<string>("TemplateName");

                    b.Property<DateTime>("Timestamp");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("SchoolEvents");
                });

            modelBuilder.Entity("JakeRenzo.Calander.Web.Infrastructures.Models.User", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<int>("LoginStatus");

                    b.Property<int>("LoginTrials");

                    b.Property<string>("Password");

                    b.Property<string>("RegistrationCode");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JakeRenzo.Calander.Web.Infrastructures.Models.UserRole", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Role");

                    b.Property<DateTime>("Timestamp");

                    b.Property<Guid?>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
