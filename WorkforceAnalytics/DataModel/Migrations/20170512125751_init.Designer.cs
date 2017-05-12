using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DataModel;
using Entities.Enums;

namespace DataModel.Migrations
{
    [DbContext(typeof(WorkforceContext))]
    [Migration("20170512125751_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BuildingNo");

                    b.Property<string>("POBox");

                    b.Property<string>("PostCode");

                    b.Property<int>("State");

                    b.Property<string>("StreetName");

                    b.Property<int>("StreetNo");

                    b.Property<string>("Suburb");

                    b.Property<int>("Type");

                    b.Property<int>("WorkerId");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FaxAreaCode");

                    b.Property<string>("FaxNumber");

                    b.Property<string>("Mobile");

                    b.Property<string>("PhoneAreaCode");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("WorkerId");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Entities.Worker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FamilyName");

                    b.Property<int>("Gender");

                    b.Property<string>("GivenName");

                    b.Property<DateTime>("SignupDate");

                    b.Property<int>("Title");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("Workers");
                });
        }
    }
}
