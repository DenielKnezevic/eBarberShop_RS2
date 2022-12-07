using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eBarberShop.Models;
using eBarberShop.Models.Requests;

namespace eBarberShop.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Database.Drzava, Drzava>();
            CreateMap<Database.Grad , Grad>();
            CreateMap<Database.Uloga , Uloga>();
            CreateMap<Database.Usluga , Usluga>();
            CreateMap<Database.VrstaProizvoda , VrstaProizvoda>();
            CreateMap<Database.Proizvod , Proizvod>();
            CreateMap<Database.Korisnik, Korisnik>();
            CreateMap<Database.KorisnikUloga , KorisnikUloga>();
            CreateMap<Database.Termin , Termin>();
            CreateMap<Database.Slika , Slika>();
            CreateMap<Database.Rezervacija, Rezervacija>();
            CreateMap<Database.Recenzija, Recenzija>();
            CreateMap<Database.Novost, Novost>();
            CreateMap<Database.Narudzba, Narudzba>();
            CreateMap<Database.NarudzbaProizvodi, NarudzbaProizvodi>();

            CreateMap<DrzavaUpsertRequest, Database.Drzava>();
            CreateMap<GradUpsertRequest, Database.Grad>();
            CreateMap<UlogaUpsertRequest, Database.Uloga>();
            CreateMap<UslugaUpsertRequest, Database.Usluga>();
            CreateMap<VrstaProizvodaUpsertRequest, Database.VrstaProizvoda>();
            CreateMap<RezervacijaUpsertRequest, Database.Rezervacija>();
            CreateMap<TerminUpsertRequest , Database.Termin>();
            CreateMap<ProizvodInsertRequest, Database.Proizvod>();
            CreateMap<ProizvodUpdateRequest, Database.Proizvod>();
            CreateMap<KorisnikInsertRequest, Database.Korisnik>();
            CreateMap<KorisnikUpdateRequest, Database.Korisnik>();
            CreateMap<SlikaInsertRequest , Database.Slika>();
            CreateMap<SlikaUpdateRequest , Database.Slika>();
            CreateMap<RecenzijaInsertRequest, Database.Recenzija>();
            CreateMap<RecenzijaUpdateRequest, Database.Recenzija>();
            CreateMap<NovostInsertRequest, Database.Novost>();
            CreateMap<NovostUpdateRequest, Database.Novost>();
            CreateMap<NarudzbaInsertRequest , Database.Narudzba>();
            CreateMap<NarudzbaUpdateRequest , Database.Narudzba>();
        }
    }
}
