﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eBarberShop.Services.Database;

#nullable disable

namespace eBarberShop.Services.Migrations
{
    [DbContext(typeof(eBarberShopContext))]
    partial class eBarberShopContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eBarberShop.Services.Database.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DrzavaID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzavas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GradID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.ToTable("Grads");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikID"), 1L, 1);

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikID");

                    b.HasIndex("DrzavaID");

                    b.HasIndex("GradID");

                    b.ToTable("Korisniks");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.KorisnikUloga", b =>
                {
                    b.Property<int>("KorisnikUlogaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikUlogaID"), 1L, 1);

                    b.Property<DateTime>("DatumIzmjene")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("UlogaID")
                        .HasColumnType("int");

                    b.HasKey("KorisnikUlogaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("UlogaID");

                    b.ToTable("KorisnikUlogas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NarudzbaID"), 1L, 1);

                    b.Property<string>("BrojNarudzbe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumNarudzbe")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.HasKey("NarudzbaID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Narudzbas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.NarudzbaProizvodi", b =>
                {
                    b.Property<int>("NarudzbaProizvodiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NarudzbaProizvodiID"), 1L, 1);

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaID")
                        .HasColumnType("int");

                    b.Property<int>("ProizvodID")
                        .HasColumnType("int");

                    b.HasKey("NarudzbaProizvodiID");

                    b.HasIndex("NarudzbaID");

                    b.HasIndex("ProizvodID");

                    b.ToTable("NarudzbaProizvodis");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Novost", b =>
                {
                    b.Property<int>("NovostID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NovostID"), 1L, 1);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Thumbnail")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("NovostID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Novosts");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Proizvod", b =>
                {
                    b.Property<int>("ProizvodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProizvodID"), 1L, 1);

                    b.Property<decimal>("Cijena")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifra")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("VrstaProizvodaID")
                        .HasColumnType("int");

                    b.HasKey("ProizvodID");

                    b.HasIndex("VrstaProizvodaID");

                    b.ToTable("Proizvods");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Recenzija", b =>
                {
                    b.Property<int>("RecenzijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecenzijaID"), 1L, 1);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int>("Ocjena")
                        .HasColumnType("int");

                    b.Property<string>("SadrzajRecenzije")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RecenzijaID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Recenzijas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Rezervacija", b =>
                {
                    b.Property<int>("RezervacijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RezervacijaID"), 1L, 1);

                    b.Property<DateTime>("DatumRezervacije")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<int?>("TerminID")
                        .HasColumnType("int");

                    b.Property<int>("UslugaID")
                        .HasColumnType("int");

                    b.HasKey("RezervacijaID");

                    b.HasIndex("KorisnikID");

                    b.HasIndex("TerminID");

                    b.HasIndex("UslugaID");

                    b.ToTable("Rezervacijas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Slika", b =>
                {
                    b.Property<int>("SlikaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SlikaID"), 1L, 1);

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("SlikaByte")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("SlikaID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Slikas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Termin", b =>
                {
                    b.Property<int>("TerminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TerminID"), 1L, 1);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumTermina")
                        .HasColumnType("datetime2");

                    b.Property<int>("KorisnikID")
                        .HasColumnType("int");

                    b.Property<string>("VrijemeTermina")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TerminID");

                    b.HasIndex("KorisnikID");

                    b.ToTable("Termins");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Uloga", b =>
                {
                    b.Property<int>("UlogaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlogaID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlogaID");

                    b.ToTable("Ulogas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Usluga", b =>
                {
                    b.Property<int>("UslugaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UslugaID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UslugaID");

                    b.ToTable("Uslugas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.VrstaProizvoda", b =>
                {
                    b.Property<int>("VrstaProizvodaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VrstaProizvodaID"), 1L, 1);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VrstaProizvodaID");

                    b.ToTable("VrstaProizvodas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Korisnik", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBarberShop.Services.Database.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drzava");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.KorisnikUloga", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikUlogas")
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBarberShop.Services.Database.Uloga", "Uloga")
                        .WithMany("KorisnikUlogas")
                        .HasForeignKey("UlogaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Narudzba", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.NarudzbaProizvodi", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.Narudzba", "Narudzba")
                        .WithMany("NarudzbaProizvodis")
                        .HasForeignKey("NarudzbaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBarberShop.Services.Database.Proizvod", "Proizvod")
                        .WithMany("NarudzbaProizvodis")
                        .HasForeignKey("ProizvodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Narudzba");

                    b.Navigation("Proizvod");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Novost", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Proizvod", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.VrstaProizvoda", "VrstaProizvoda")
                        .WithMany()
                        .HasForeignKey("VrstaProizvodaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("VrstaProizvoda");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Recenzija", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Rezervacija", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eBarberShop.Services.Database.Termin", "Termin")
                        .WithMany()
                        .HasForeignKey("TerminID");

                    b.HasOne("eBarberShop.Services.Database.Usluga", "Usluga")
                        .WithMany()
                        .HasForeignKey("UslugaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");

                    b.Navigation("Termin");

                    b.Navigation("Usluga");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Slika", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Termin", b =>
                {
                    b.HasOne("eBarberShop.Services.Database.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Korisnik", b =>
                {
                    b.Navigation("KorisnikUlogas");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Narudzba", b =>
                {
                    b.Navigation("NarudzbaProizvodis");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Proizvod", b =>
                {
                    b.Navigation("NarudzbaProizvodis");
                });

            modelBuilder.Entity("eBarberShop.Services.Database.Uloga", b =>
                {
                    b.Navigation("KorisnikUlogas");
                });
#pragma warning restore 612, 618
        }
    }
}
