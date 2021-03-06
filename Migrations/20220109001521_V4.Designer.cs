// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace restoran.Migrations
{
    [DbContext(typeof(RestoranContext))]
    [Migration("20220109001521_V4")]
    partial class V4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Models.Dezert", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<string>("ImeDezerta")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("RestoranID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RestoranID");

                    b.ToTable("Dezert");
                });

            modelBuilder.Entity("Models.Jela", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<string>("ImeJela")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("RestoranID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RestoranID");

                    b.ToTable("Jela");
                });

            modelBuilder.Entity("Models.Klijent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BrojTelefona")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("Models.Narudzbina", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("DezertID")
                        .HasColumnType("int");

                    b.Property<int?>("JelaID")
                        .HasColumnType("int");

                    b.Property<int?>("KlijentID")
                        .HasColumnType("int");

                    b.Property<int?>("PicaID")
                        .HasColumnType("int");

                    b.Property<int?>("RestoranID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("DezertID");

                    b.HasIndex("JelaID");

                    b.HasIndex("KlijentID");

                    b.HasIndex("PicaID");

                    b.HasIndex("RestoranID");

                    b.ToTable("Narudzbina");
                });

            modelBuilder.Entity("Models.Pica", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<string>("ImePica")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("RestoranID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RestoranID");

                    b.ToTable("Piće");
                });

            modelBuilder.Entity("Models.Restoran", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImeRestorana")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Restoran");
                });

            modelBuilder.Entity("Models.Dezert", b =>
                {
                    b.HasOne("Models.Restoran", "Restoran")
                        .WithMany("Dezert")
                        .HasForeignKey("RestoranID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("Models.Jela", b =>
                {
                    b.HasOne("Models.Restoran", "Restoran")
                        .WithMany("Jela")
                        .HasForeignKey("RestoranID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("Models.Narudzbina", b =>
                {
                    b.HasOne("Models.Dezert", "Dezert")
                        .WithMany("DezertiNaruci")
                        .HasForeignKey("DezertID");

                    b.HasOne("Models.Jela", "Jela")
                        .WithMany("JelaNaruci")
                        .HasForeignKey("JelaID");

                    b.HasOne("Models.Klijent", "Klijent")
                        .WithMany("Klijenti")
                        .HasForeignKey("KlijentID");

                    b.HasOne("Models.Pica", "Pica")
                        .WithMany("PicaNaruci")
                        .HasForeignKey("PicaID");

                    b.HasOne("Models.Restoran", "Restoran")
                        .WithMany("Narudzbine")
                        .HasForeignKey("RestoranID");

                    b.Navigation("Dezert");

                    b.Navigation("Jela");

                    b.Navigation("Klijent");

                    b.Navigation("Pica");

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("Models.Pica", b =>
                {
                    b.HasOne("Models.Restoran", "Restoran")
                        .WithMany("Pica")
                        .HasForeignKey("RestoranID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restoran");
                });

            modelBuilder.Entity("Models.Dezert", b =>
                {
                    b.Navigation("DezertiNaruci");
                });

            modelBuilder.Entity("Models.Jela", b =>
                {
                    b.Navigation("JelaNaruci");
                });

            modelBuilder.Entity("Models.Klijent", b =>
                {
                    b.Navigation("Klijenti");
                });

            modelBuilder.Entity("Models.Pica", b =>
                {
                    b.Navigation("PicaNaruci");
                });

            modelBuilder.Entity("Models.Restoran", b =>
                {
                    b.Navigation("Dezert");

                    b.Navigation("Jela");

                    b.Navigation("Narudzbine");

                    b.Navigation("Pica");
                });
#pragma warning restore 612, 618
        }
    }
}
