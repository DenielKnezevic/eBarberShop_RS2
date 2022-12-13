using AutoMapper;
using eBarberShop.Models.Requests;
using eBarberShop.Models.SearchObjects;
using eBarberShop.Services.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eBarberShop.Services.Services
{
    public class KorisnikService : CRUDService<Models.Korisnik, Korisnik, KorisnikSearchObject, KorisnikInsertRequest , KorisnikUpdateRequest> , IKorisnikService
    {
        public KorisnikService(eBarberShopContext db , IMapper mapper):base(db , mapper)
        {

        }

        public override Models.Korisnik Insert(KorisnikInsertRequest request)
        {
            var entity = base.Insert(request);

            foreach (var uloga in request.UlogeID)
            {
                Database.KorisnikUloga Uloga = new Database.KorisnikUloga();
                Uloga.UlogaID = uloga;
                Uloga.KorisnikID = entity.KorisnikID;
                Uloga.DatumIzmjene = DateTime.Now;

                _db.KorisnikUlogas.Add(Uloga);
            }

            _db.SaveChanges();

            return entity;
        }

        public override IQueryable<Korisnik> AddInclude(IQueryable<Korisnik> entity)
        {
            entity = entity.Include("KorisnikUlogas.Uloga").Include(x => x.Grad).Include(x => x.Drzava);

            return entity;
        }

        public override IQueryable<Korisnik> AddFilter(IQueryable<Korisnik> entity, KorisnikSearchObject obj)
        {
            if(!string.IsNullOrWhiteSpace(obj.Ime))
            {
                entity = entity.Where(x => x.Ime.ToLower().StartsWith(obj.Ime.ToLower()));
            }

            if (!string.IsNullOrWhiteSpace(obj.Prezime))
            {
                entity = entity.Where(x => x.Prezime.ToLower().StartsWith(obj.Prezime.ToLower()));
            }

            if(!string.IsNullOrWhiteSpace(obj.KorisnickoIme))
            {
                entity = entity.Where(x => x.KorisnickoIme.StartsWith(obj.KorisnickoIme));
            }

            return entity;
        }

        public override void BeforeInsert(KorisnikInsertRequest insert, Korisnik entity)
        {
            var salt = GenerateSalt();
            var hash = GenerateHash(salt,insert.Lozinka);
            entity.LozinkaSalt = salt;
            entity.LozinkaHash = hash;
        }

        public Models.Korisnik AddUloga(int id)
        {
            var user = _db.Korisniks.Include("KorisnikUlogas.Uloga").FirstOrDefault(x => x.KorisnikID == id);
            var uloga = _db.Ulogas.FirstOrDefault(x => x.Naziv.ToLower() == "uposlenik");

            Database.KorisnikUloga nova = new Database.KorisnikUloga()
                {
                DatumIzmjene = DateTime.Now,
                KorisnikID = id,
                UlogaID = uloga.UlogaID
            };
            _db.KorisnikUlogas.Add(nova);
            _db.SaveChanges();

            return _mapper.Map<Models.Korisnik>(user);
        }

        public Models.Korisnik Login(string username, string password)
        {
            var user = _db.Korisniks.Include("KorisnikUlogas.Uloga").FirstOrDefault(x => x.KorisnickoIme == username);

            if (user == null) { throw new Exception("No user found"); }

            var hash = GenerateHash(user.LozinkaSalt, password);

            if (user.LozinkaHash != hash) { throw new Exception("Wrong password"); }

            return _mapper.Map<Models.Korisnik>(user);
        }

        public static string GenerateSalt()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            var byteArray = new byte[16];
            provider.GetBytes(byteArray);


            return Convert.ToBase64String(byteArray);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
