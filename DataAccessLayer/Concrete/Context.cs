using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int> //önceden DbContext'ten miras alıyorduk fakat projemize identity kütüphanesini dahil ettiğimiz de sadece migrations işlemi yeterli olmaz, IdentityDbContext'ten miras alması lazım context sınıfımızın.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("{your connection string type here}");
        }


        //AppUser ve AppRole çağırmana gerek yok, kendisi otomatik olarak ilgili tabloları çağıracak çünkü appuser identityden miras aldı
        public DbSet<About> Abouts { get; set; }
        public DbSet<AboutOther> AboutOthers { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FeatureOther> FeatureOthers { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
