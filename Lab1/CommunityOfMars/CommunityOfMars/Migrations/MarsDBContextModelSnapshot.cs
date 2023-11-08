﻿// <auto-generated />
using System;
using CommunityOfMars.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CommunityOfMars.Migrations
{
    [DbContext(typeof(MarsDBContext))]
    partial class MarsDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CommunityOfMars.Models.AppUser", b =>
                {
                    b.Property<int>("AppUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("longtext");

                    b.HasKey("AppUserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CommunityOfMars.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Body")
                        .HasColumnType("longtext");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<int?>("ReceiverAppUserId")
                        .HasColumnType("int");

                    b.Property<int?>("SenderAppUserId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("longtext");

                    b.HasKey("MessageId");

                    b.HasIndex("ReceiverAppUserId");

                    b.HasIndex("SenderAppUserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("CommunityOfMars.Models.Message", b =>
                {
                    b.HasOne("CommunityOfMars.Models.AppUser", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverAppUserId");

                    b.HasOne("CommunityOfMars.Models.AppUser", "Sender")
                        .WithMany()
                        .HasForeignKey("SenderAppUserId");

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });
#pragma warning restore 612, 618
        }
    }
}
