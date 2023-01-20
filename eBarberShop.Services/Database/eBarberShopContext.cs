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
            var saltUposlenik2 = KorisnikService.GenerateSalt();
            var saltUser = KorisnikService.GenerateSalt();
            var saltUser2 = KorisnikService.GenerateSalt();

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
                new Korisnik { KorisnikID = 3, Ime = "User", Prezime = "User", DatumRodjenja = DateTime.Now, DrzavaID = 3, GradID = 3, Email = "user@gmail.com", KorisnickoIme = "user", Telefon = "000000002", LozinkaSalt = saltUser, LozinkaHash = KorisnikService.GenerateHash(saltUser, "user") },
                new Korisnik { KorisnikID = 4, Ime = "Uposlenik2", Prezime = "Uposlenik2", DatumRodjenja = DateTime.Now, DrzavaID = 2, GradID = 2, Email = "uposlenik2@gmail.com", KorisnickoIme = "uposlenik2", Telefon = "000000003", LozinkaSalt = saltUposlenik2, LozinkaHash = KorisnikService.GenerateHash(saltUposlenik2, "uposlenik2") },
                new Korisnik { KorisnikID = 5, Ime = "User2", Prezime = "User2", DatumRodjenja = DateTime.Now, DrzavaID = 3, GradID = 3, Email = "user2@gmail.com", KorisnickoIme = "user2", Telefon = "000000002", LozinkaSalt = saltUser2, LozinkaHash = KorisnikService.GenerateHash(saltUser2, "user2") }

                );

            modelBuilder.Entity<KorisnikUloga>().HasData(
                new KorisnikUloga { KorisnikUlogaID = 1, DatumIzmjene = DateTime.Now, KorisnikID = 1, UlogaID = 1 },
                new KorisnikUloga { KorisnikUlogaID = 2, DatumIzmjene = DateTime.Now, KorisnikID = 1, UlogaID = 2 },
                new KorisnikUloga { KorisnikUlogaID = 3, DatumIzmjene = DateTime.Now, KorisnikID = 2, UlogaID = 2 },
                new KorisnikUloga { KorisnikUlogaID = 4, DatumIzmjene = DateTime.Now, KorisnikID = 4, UlogaID = 2 }
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
                new Proizvod { ProizvodID = 1, Cijena = 8, Naziv = "Head & Shoulders", VrstaProizvodaID = 2, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[0]), Opis="Opis prvog proizvoda" },
                new Proizvod { ProizvodID = 2, Cijena = 50, Naziv = "Frizerland masinica", VrstaProizvodaID = 1, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[1]) , Opis = "Opis drugog proizvoda" },
                new Proizvod { ProizvodID = 3, Cijena = 40, Naziv = "Ovnak fen", VrstaProizvodaID = 4, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[2]), Opis = "Opis treceg proizvoda" },
                new Proizvod { ProizvodID = 4, Cijena = 60, Naziv = "Rowenta fen", VrstaProizvodaID = 4, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[3]), Opis = "Opis cetvrtog proizvoda" },
                new Proizvod { ProizvodID = 5, Cijena = 6, Naziv = "Red One gel", VrstaProizvodaID = 3, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[4]), Opis = "Opis petog proizvoda" },
                new Proizvod { ProizvodID = 6, Cijena = 8, Naziv = "Gummy vosak", VrstaProizvodaID = 3, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[5]), Opis = "Opis sestog proizvoda" },
                new Proizvod { ProizvodID = 7, Cijena = 9, Naziv = "Taft glina", VrstaProizvodaID = 3, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[6]), Opis = "Opis sedmog proizvoda" },
                new Proizvod { ProizvodID = 8, Cijena = 10, Naziv = "Schauma", VrstaProizvodaID = 2, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[7]), Opis = "Opis osmog proizvoda" },
                new Proizvod { ProizvodID = 9, Cijena = 70, Naziv = "Mozer masinica", VrstaProizvodaID = 1, Sifra = Guid.NewGuid().ToString(), Slika = Convert.FromBase64String(Images.Images.Slike[8]), Opis = "Opis devetog proizvoda" }
                );

            modelBuilder.Entity<Termin>().HasData(
                new Termin { TerminID = 1, KorisnikID = 2, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("01/03/2023"), VrijemeTermina = "12:00" },
                new Termin { TerminID = 2, KorisnikID = 2, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("02/03/2023"), VrijemeTermina = "13:00" },
                new Termin { TerminID = 3, KorisnikID = 2, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("03/03/2023"), VrijemeTermina = "14:00" },
                new Termin { TerminID = 4, KorisnikID = 4, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("01/03/2023"), VrijemeTermina = "13:00" },
                new Termin { TerminID = 5, KorisnikID = 4, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("02/03/2023"), VrijemeTermina = "14:00" },
                new Termin { TerminID = 6, KorisnikID = 4, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("03/03/2023"), VrijemeTermina = "15:00" },
                new Termin { TerminID = 7, KorisnikID = 2, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("01/03/2023"), VrijemeTermina = "16:00" , IsBooked = true },
                new Termin { TerminID = 8, KorisnikID = 4, DatumKreiranja = DateTime.Now, DatumTermina = DateTime.Parse("01/03/2023"), VrijemeTermina = "10:00" , IsBooked = true }
                );

            modelBuilder.Entity<Rezervacija>().HasData(
                new Rezervacija { RezervacijaID = 1 , DatumRezervacije = DateTime.Now , IsArchived = true , IsCanceled = false , KorisnikID = 3, TerminID = 7 , UslugaID = 1 },
                new Rezervacija { RezervacijaID = 2, DatumRezervacije = DateTime.Now, IsArchived = false, IsCanceled = false, KorisnikID = 5, TerminID = 8, UslugaID = 2 }
                );

            modelBuilder.Entity<Novost>().HasData(
                new Novost { NovostID = 1, DatumKreiranja = DateTime.Now, KorisnikID = 2, Naslov = "Novost 1", Sadrzaj = "Ovo je sadrzaj prve novosti", Thumbnail = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Novost { NovostID = 2, DatumKreiranja = DateTime.Now, KorisnikID = 2, Naslov = "Novost 2", Sadrzaj = "Ovo je sadrzaj druge novosti", Thumbnail = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Novost { NovostID = 3, DatumKreiranja = DateTime.Now, KorisnikID = 4, Naslov = "Novost 3", Sadrzaj = "Ovo je sadrzaj trece novosti", Thumbnail = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Novost { NovostID = 4, DatumKreiranja = DateTime.Now, KorisnikID = 4, Naslov = "Novost 4", Sadrzaj = "Ovo je sadrzaj cetvrte novosti", Thumbnail = Convert.FromBase64String(Images.Images.Slike2[0]) }
                );

            modelBuilder.Entity<Slika>().HasData(
                new Slika { SlikaID = 1, KorisnikID = 2, Opis = "Slika 1", SlikaByte = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Slika { SlikaID = 2, KorisnikID = 2, Opis = "Slika 2", SlikaByte = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Slika { SlikaID = 3, KorisnikID = 4, Opis = "Slika 3", SlikaByte = Convert.FromBase64String(Images.Images.Slike2[0]) },
                new Slika { SlikaID = 4, KorisnikID = 4, Opis = "Slika 4", SlikaByte = Convert.FromBase64String(Images.Images.Slike2[0]) }
                );

            modelBuilder.Entity<Usluga>().HasData(
                new Usluga { UslugaID = 1, Naziv = "Sisanje", Opis = "Sisanje" },
                new Usluga { UslugaID = 2, Naziv = "Pranje kose", Opis = "Pranje kose" },
                new Usluga { UslugaID = 3, Naziv = "Feniranje", Opis = "Feniranje" },
                new Usluga { UslugaID = 4, Naziv = "Brijanje", Opis = "Brijanje" }
                );

            modelBuilder.Entity<Uplata>().HasData(
                new Uplata { UplataID = 1, BrojTransakcije = "pi_3MSSv3ANnFXjgSPx2LOrScMr", DatumTransakcije = DateTime.Now , Iznos = 146 },
                new Uplata { UplataID = 2, BrojTransakcije = "pi_3MSSwtANnFXjgSPx1GLV7ZWR", DatumTransakcije = DateTime.Now, Iznos = 196 },
                new Uplata { UplataID = 3, BrojTransakcije = "pi_3MSSxZANnFXjgSPx1h6sZONh", DatumTransakcije = DateTime.Now, Iznos = 122 },
                new Uplata { UplataID = 4, BrojTransakcije = "pi_3MSSykANnFXjgSPx0j7dwFvL", DatumTransakcije = DateTime.Now, Iznos = 132 },
                new Uplata { UplataID = 5, BrojTransakcije = "pi_3MSSzFANnFXjgSPx1K5yB3MP", DatumTransakcije = DateTime.Now, Iznos = 58 },
                new Uplata { UplataID = 6, BrojTransakcije = "pi_3MSSzgANnFXjgSPx30vUfLBv", DatumTransakcije = DateTime.Now, Iznos = 118 },
                new Uplata { UplataID = 7, BrojTransakcije = "pi_3MST02ANnFXjgSPx28dm4Ke1", DatumTransakcije = DateTime.Now, Iznos = 66 }
                );

            modelBuilder.Entity<Narudzba>().HasData(
                new Narudzba { NarudzbaID = 1 , BrojNarudzbe = Guid.NewGuid().ToString(), DatumNarudzbe = DateTime.Now , IsCanceled = false , IsShipped = true , KorisnikID = 3 , UplataID = 1 },
                new Narudzba { NarudzbaID = 2, BrojNarudzbe = Guid.NewGuid().ToString(), DatumNarudzbe = DateTime.Now, IsCanceled = false, IsShipped = true, KorisnikID = 3, UplataID = 2 },
                new Narudzba { NarudzbaID = 3, BrojNarudzbe = Guid.NewGuid().ToString(), DatumNarudzbe = DateTime.Now, IsCanceled = false, IsShipped = false, KorisnikID = 3, UplataID = 3 },
                new Narudzba { NarudzbaID = 4, BrojNarudzbe = Guid.NewGuid().ToString(), DatumNarudzbe = DateTime.Now, IsCanceled = false, IsShipped = false, KorisnikID = 5, UplataID = 4 },
                new Narudzba { NarudzbaID = 5, BrojNarudzbe = Guid.NewGuid().ToString(), DatumNarudzbe = DateTime.Now, IsCanceled = false, IsShipped = true, KorisnikID = 5, UplataID = 5 },
                new Narudzba { NarudzbaID = 6, BrojNarudzbe = Guid.NewGuid().ToString(), DatumNarudzbe = DateTime.Now, IsCanceled = false, IsShipped = true, KorisnikID = 5, UplataID = 6 },
                new Narudzba { NarudzbaID = 7, BrojNarudzbe = Guid.NewGuid().ToString(), DatumNarudzbe = DateTime.Now, IsCanceled = false, IsShipped = false, KorisnikID = 3, UplataID = 7 }
                );

            modelBuilder.Entity<NarudzbaProizvodi>().HasData(
                new NarudzbaProizvodi { NarudzbaProizvodiID = 1 , NarudzbaID = 1 , ProizvodID = 1 , Kolicina = 2},
                new NarudzbaProizvodi { NarudzbaProizvodiID = 2, NarudzbaID = 1, ProizvodID = 4, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 3, NarudzbaID = 1, ProizvodID = 9, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 4, NarudzbaID = 2, ProizvodID = 1, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 5, NarudzbaID = 2, ProizvodID = 2, Kolicina = 2 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 6, NarudzbaID = 2, ProizvodID = 7, Kolicina = 2 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 7, NarudzbaID = 2, ProizvodID = 9, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 8, NarudzbaID = 3, ProizvodID = 2, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 9, NarudzbaID = 3, ProizvodID = 1, Kolicina = 3 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 10, NarudzbaID = 3, ProizvodID = 6, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 11, NarudzbaID = 3, ProizvodID = 3, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 12, NarudzbaID = 4, ProizvodID = 1, Kolicina = 3 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 13, NarudzbaID = 4, ProizvodID = 2, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 14, NarudzbaID = 4, ProizvodID = 3, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 15, NarudzbaID = 4, ProizvodID = 7, Kolicina = 2 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 17, NarudzbaID = 5, ProizvodID = 8, Kolicina = 3 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 18, NarudzbaID = 5, ProizvodID = 9, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 19, NarudzbaID = 5, ProizvodID = 3, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 20, NarudzbaID = 5, ProizvodID = 6, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 21, NarudzbaID = 6, ProizvodID = 5, Kolicina = 3 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 22, NarudzbaID = 6, ProizvodID = 2, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 23, NarudzbaID = 6, ProizvodID = 1, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 24, NarudzbaID = 6, ProizvodID = 4, Kolicina = 1 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 25, NarudzbaID = 7, ProizvodID = 1, Kolicina = 2 },
                new NarudzbaProizvodi { NarudzbaProizvodiID = 26, NarudzbaID = 7, ProizvodID = 2, Kolicina = 1 }
                );
        }

    }
}
