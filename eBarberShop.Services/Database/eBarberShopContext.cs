using eBarberShop.Services.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Database
{
    public class eBarberShopContext : DbContext
    {
        public eBarberShopContext()
        {
        }

        public eBarberShopContext(DbContextOptions<eBarberShopContext> options):base(options)
        {
        }

        public virtual DbSet<Drzava> Drzavas { get; set; } = null!;
        public virtual DbSet<Grad> Grads { get; set; } = null!;
        public virtual DbSet<Korisnik> Korisniks { get; set; } = null!;
        public virtual DbSet<KorisnikUloga> KorisnikUlogas { get; set; } = null!;
        public virtual DbSet<Narudzba> Narudzbas { get; set; } = null!;
        public virtual DbSet<NarudzbaProizvodi> NarudzbaProizvodis { get; set; } = null!;
        public virtual DbSet<Novost> Novosts { get; set; } = null!;
        public virtual DbSet<Proizvod> Proizvods { get; set; } = null!;
        public virtual DbSet<Recenzija> Recenzijas { get; set; } = null!;
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; } = null!;
        public virtual DbSet<Slika> Slikas { get; set; } = null!;
        public virtual DbSet<Termin> Termins { get; set; } = null!;
        public virtual DbSet<Uloga> Ulogas { get; set; } = null!;
        public virtual DbSet<Usluga> Uslugas { get; set; } = null!;
        public virtual DbSet<VrstaProizvoda> VrstaProizvodas { get; set; } = null!;
        public virtual DbSet<Uplata> Uplatas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=eBarberShop;Trusted_Connection=true;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var saltAdmin = KorisnikService.GenerateSalt();
            var saltUposlenik = KorisnikService.GenerateSalt();
            var saltUser = KorisnikService.GenerateSalt();

            modelBuilder.Entity<Drzava>().HasData(
                new Drzava { DrzavaID = 1, Naziv = "Bosna i Hercegovina" },
                new Drzava { DrzavaID = 2, Naziv = "Hrvatska" },
                new Drzava { DrzavaID = 3, Naziv = "Srbija" }
                );

            modelBuilder.Entity<Grad>().HasData(
                new Grad { GradID = 1, Naziv = "Sarajevo" },
                new Grad { GradID = 2, Naziv = "Zagreb" },
                new Grad { GradID = 3, Naziv = "Beograd" }
                );

            modelBuilder.Entity<Uloga>().HasData(
                new Uloga { UlogaID = 1, Naziv = "Administrator", Opis = "Administrator" },
                new Uloga { UlogaID = 2, Naziv = "Uposlenik", Opis = "Uposlenik" }
                );

            modelBuilder.Entity<Korisnik>().HasData(
                new Korisnik { KorisnikID = 1, Ime = "Admin", Prezime = "Admin", DatumRodjenja = DateTime.Now, DrzavaID = 1, GradID = 1, Email = "admin@gmail.com", KorisnickoIme = "admin", Telefon = "000000000", LozinkaSalt = saltAdmin, LozinkaHash = KorisnikService.GenerateHash(saltAdmin, "admin") },
                new Korisnik { KorisnikID = 2, Ime = "Uposlenik", Prezime = "Uposlenik", DatumRodjenja = DateTime.Now, DrzavaID = 2, GradID = 2, Email = "uposlenik@gmail.com", KorisnickoIme = "uposlenik", Telefon = "000000001", LozinkaSalt = saltUposlenik, LozinkaHash = KorisnikService.GenerateHash(saltUposlenik, "uposlenik") },
                new Korisnik { KorisnikID = 3, Ime = "User", Prezime = "User", DatumRodjenja = DateTime.Now, DrzavaID = 3, GradID = 3, Email = "user@gmail.com", KorisnickoIme = "user", Telefon = "000000002", LozinkaSalt = saltUser, LozinkaHash = KorisnikService.GenerateHash(saltUser, "user") }
                );

            modelBuilder.Entity<KorisnikUloga>().HasData(
                new KorisnikUloga { KorisnikUlogaID = 1, DatumIzmjene = DateTime.Now, KorisnikID = 1, UlogaID = 1 },
                new KorisnikUloga { KorisnikUlogaID = 2, DatumIzmjene = DateTime.Now, KorisnikID = 1, UlogaID = 2 },
                new KorisnikUloga { KorisnikUlogaID = 3, DatumIzmjene = DateTime.Now, KorisnikID = 2, UlogaID = 2 }
                );

            modelBuilder.Entity<VrstaProizvoda>().HasData(
                new VrstaProizvoda { VrstaProizvodaID = 1, Naziv = "Masinica", Opis = "Masinica" },
                new VrstaProizvoda { VrstaProizvodaID = 2, Naziv = "Sampon", Opis = "Sampon" },
                new VrstaProizvoda { VrstaProizvodaID = 3, Naziv = "Gel", Opis = "Gel" },
                new VrstaProizvoda { VrstaProizvodaID = 4, Naziv = "Fen", Opis = "Fen" }
                );

            modelBuilder.Entity<Recenzija>().HasData(
                new Recenzija { RecenzijaID = 1, DatumKreiranja = DateTime.Now, KorisnikID = 3, Ocjena = 4, SadrzajRecenzije = "Ovo je sadrzaj recenzije koju je napisao korisnik User" }
                );

            modelBuilder.Entity<Proizvod>().HasData(
                new Proizvod { ProizvodID = 1, Cijena = 8, Naziv = "Head & Shoulders", VrstaProizvodaID = 2, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[0]) },
                new Proizvod { ProizvodID = 2, Cijena = 50, Naziv = "Frizerland masinica", VrstaProizvodaID = 1, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[1]) },
                new Proizvod { ProizvodID = 3, Cijena = 40, Naziv = "Ovnak fen", VrstaProizvodaID = 4, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[2]) }
                );

            modelBuilder.Entity<Termin>().HasData(
                new Termin { TerminID = 1, KorisnikID = 1, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("12/12/2023"), VrijemeTermina = "12:00" },
                new Termin { TerminID = 2, KorisnikID = 1, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("12/12/2023"), VrijemeTermina = "13:00" },
                new Termin { TerminID = 3, KorisnikID = 2, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("12/12/2023"), VrijemeTermina = "14:00" }
                );

            modelBuilder.Entity<Novost>().HasData(
                new Novost { NovostID = 1, DatumKreiranja = DateTime.Now, KorisnikID = 1, Naslov = "Novost 1", Sadrzaj = "Ovo je sadrzaj prve novosti", Thumbnail = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Novost { NovostID = 2, DatumKreiranja = DateTime.Now, KorisnikID = 1, Naslov = "Novost 2", Sadrzaj = "Ovo je sadrzaj druge novosti", Thumbnail = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Novost { NovostID = 3, DatumKreiranja = DateTime.Now, KorisnikID = 1, Naslov = "Novost 3", Sadrzaj = "Ovo je sadrzaj trece novosti", Thumbnail = Convert.FromBase64String(Images.Images.Slike2[0]) }
                );

            modelBuilder.Entity<Slika>().HasData(
                new Slika { SlikaID = 1, KorisnikID = 1, Opis = "Slika 1", SlikaByte = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Slika { SlikaID = 2, KorisnikID = 1, Opis = "Slika 2", SlikaByte = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Slika { SlikaID = 3, KorisnikID = 1, Opis = "Slika 3", SlikaByte = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Slika { SlikaID = 4, KorisnikID = 1, Opis = "Slika 4", SlikaByte = Convert.FromBase64String(Images.Images.Slike2[0]) }
                );

            modelBuilder.Entity<Usluga>().HasData(
                new Usluga { UslugaID = 1, Naziv = "Sisanje", Opis = "Sisanje" },
                new Usluga { UslugaID = 2, Naziv = "Pranje kose", Opis = "Pranje kose" },
                new Usluga { UslugaID = 3, Naziv = "Feniranje", Opis = "Feniranje" },
                new Usluga { UslugaID = 4, Naziv = "Brijanje", Opis = "Brijanje" }
                );
        }

    }
}
