using Microsoft.EntityFrameworkCore;
using VillaAPI.Models;
using VillaAPI.Models;

namespace VillaAPI.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "one Villa",
                    Details = "awsedrtfuikolkmj dxujhsgfgvbhkm rdgyuhijogf",
                    ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa3.jpg",
                    Occupancy = 7,
                    Rate = 2000,
                    Sqft = 1000,
                    Amenity = "qwertyu",
                    CreatedDate = DateTime.Now
                },
              new Villa
              {
                  Id = 2,
                  Name = "two Villa",
                  Details = "sedrftgyhuj oiujytdrf poiuytrsdcfgvhbjnmk ftgyuhj",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa1.jpg",
                  Occupancy = 9,
                  Rate = 1500,
                  Sqft = 2500,
                  Amenity = "oiuyt",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 3,
                  Name = "three Villa",
                  Details = "wertyuhj lkjhgfd poiuytrdsx kjhgfd",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa4.jpg",
                  Occupancy = 3,
                  Rate = 400,
                  Sqft = 700,
                  Amenity = "fghkj",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 4,
                  Name = "four Villa",
                  Details = "sdfgkjhgfd iuytrdf sdfyujk lokjhgfd",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa5.jpg",
                  Occupancy = 4,
                  Rate = 500,
                  Sqft = 800,
                  Amenity = "dfgjhgjh",
                  CreatedDate = DateTime.Now
              },
              new Villa
              {
                  Id = 5,
                  Name = "five Villa",
                  Details = "qwertyuiolkj sdfghjkl lkiuytredxcvbnm sdfghjkkkmnbvcd",
                  ImageUrl = "https://dotnetmastery.com/bluevillaimages/villa2.jpg",
                  Occupancy = 5,
                  Rate = 800,
                  Sqft = 1200,
                  Amenity = "ertyui",
                  CreatedDate = DateTime.Now
              });
        }
    }
}
