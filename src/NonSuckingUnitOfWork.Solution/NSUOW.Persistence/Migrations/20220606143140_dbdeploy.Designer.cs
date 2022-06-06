﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NSUOW.Persistence;

#nullable disable

namespace NSUOW.Persistence.Migrations
{
    [DbContext(typeof(NsuowDbContext))]
    [Migration("20220606143140_dbdeploy")]
    partial class dbdeploy
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NSUOW.Domain.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ServiceId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("Amount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("Amount");

                    b.Property<string>("ClientReference")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ClientReference");

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDateUtc");

                    b.Property<DateTime?>("DeliveryDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("DeliveryDate");

                    b.Property<string>("Eta")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ETA");

                    b.Property<string>("Instructions")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("Instructions");

                    b.Property<int>("NumberOfVolumes")
                        .HasColumnType("int")
                        .HasColumnName("NumberOfVolumes");

                    b.Property<DateTime?>("PickingDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("PickingDate");

                    b.Property<string>("PinNumber")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)")
                        .HasColumnName("PinNumber");

                    b.Property<string>("PreferentialPeriod")
                        .HasMaxLength(23)
                        .HasColumnType("nvarchar(23)")
                        .HasColumnName("PreferentialPeriod");

                    b.Property<string>("ReceiverAddress")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("ReceiverAddress");

                    b.Property<string>("ReceiverAddressCountryCode")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("ReceiverAddressCountryCode");

                    b.Property<string>("ReceiverAddressPlace")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ReceiverAddressPlace");

                    b.Property<string>("ReceiverAddressZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("ReceiverAddressZipCode");

                    b.Property<string>("ReceiverAddressZipCodePlace")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ReceiverAddressZipCodePlace");

                    b.Property<string>("ReceiverClientCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("ReceiverClientCode");

                    b.Property<string>("ReceiverContactEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ReceiverContactEmail");

                    b.Property<string>("ReceiverContactName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("ReceiverContactName");

                    b.Property<string>("ReceiverContactPhoneNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ReceiverContactPhoneNumber");

                    b.Property<string>("ReceiverFixedInstructions")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("ReceiverFixedInstructions");

                    b.Property<string>("ReceiverName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("ReceiverName");

                    b.Property<string>("SenderAddress")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("SenderAddress");

                    b.Property<string>("SenderAddressCountryCode")
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)")
                        .HasColumnName("SenderAddressCountryCode");

                    b.Property<string>("SenderAddressPlace")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SenderAddressPlace");

                    b.Property<string>("SenderAddressZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("SenderAddressZipCode");

                    b.Property<string>("SenderAddressZipCodePlace")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SenderAddressZipCodePlace");

                    b.Property<string>("SenderClientCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("SenderClientCode");

                    b.Property<string>("SenderContactEmail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SenderContactEmail");

                    b.Property<string>("SenderContactName")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasColumnName("SenderContactName");

                    b.Property<string>("SenderContactPhoneNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SenderContactPhoneNumber");

                    b.Property<string>("SenderName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SenderName");

                    b.Property<string>("ServiceBarCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ServiceBarCode");

                    b.Property<decimal>("TotalWeightOfVolumes")
                        .HasColumnType("decimal(18,3)")
                        .HasColumnName("TotalWeightOfVolumes");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime>("UpdatedDateUtc")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDateUtc");

                    b.HasKey("Id");

                    b.HasIndex("ReceiverAddress");

                    b.HasIndex("ReceiverContactPhoneNumber");

                    b.HasIndex("SenderAddress");

                    b.HasIndex("SenderContactPhoneNumber");

                    b.ToTable("Services", "dbo");
                });

            modelBuilder.Entity("NSUOW.Domain.Volume", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VolumeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CreatedBy");

                    b.Property<DateTime>("CreatedDateUtc")
                        .HasColumnType("datetime2")
                        .HasColumnName("CreatedDateUtc");

                    b.Property<decimal?>("Height")
                        .HasColumnType("decimal(10,3)")
                        .HasColumnName("Height");

                    b.Property<decimal?>("Length")
                        .HasColumnType("decimal(10,3)")
                        .HasColumnName("Length");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int")
                        .HasColumnName("ServiceId");

                    b.Property<string>("UpdatedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("UpdatedBy");

                    b.Property<DateTime>("UpdatedDateUtc")
                        .HasColumnType("datetime2")
                        .HasColumnName("UpdatedDateUtc");

                    b.Property<string>("VolumeBarCode")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("VolumeBarCode");

                    b.Property<int>("VolumeNumber")
                        .HasColumnType("int")
                        .HasColumnName("VolumeNumber");

                    b.Property<decimal>("Weight")
                        .HasColumnType("decimal(18,3)")
                        .HasColumnName("Weight");

                    b.Property<decimal?>("Width")
                        .HasColumnType("decimal(10,3)")
                        .HasColumnName("Width");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("Volumes", "dbo");
                });

            modelBuilder.Entity("NSUOW.Domain.Volume", b =>
                {
                    b.HasOne("NSUOW.Domain.Service", "Service")
                        .WithMany("Volumes")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Volumes_Services_ServiceId");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("NSUOW.Domain.Service", b =>
                {
                    b.Navigation("Volumes");
                });
#pragma warning restore 612, 618
        }
    }
}