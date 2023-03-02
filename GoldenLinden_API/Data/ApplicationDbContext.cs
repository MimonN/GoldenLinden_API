using GoldenLinden_API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoldenLinden_API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                Id = 1,
                Name = "Ukrainian Borscht",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://img.ccnull.de/1025000/preview/1025542_48f1150dc44ff42996600b34cd34a3fe.jpg",
                Price = 7.99,
                Category = "Soup",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 2,
                Name = "Mushroom Soup",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://media.30seconds.com/tip/md/Hungarian-Mushroom-Soup-Recipe-39195-c46def2dd2-1644776743.jpg",
                Price = 8.99,
                Category = "Soup",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 3,
                Name = "Roasted Beef & Goat Cheese Salad",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://hips.hearstapps.com/hmg-prod/images/delish-beet-salad-jpg-1526059794.jpg",
                Price = 8.99,
                Category = "Salad",
                SpecialTag = "Best Seller"
            }, new MenuItem
            {
                Id = 4,
                Name = "Mixed Ukrainian Grill",
                Description = "Fusc tincidunt maximus leo, sed scelerisque massa auctor sit amet. Donec ex mauris, hendrerit quis nibh ac, efficitur fringilla enim.",
                Image = "https://www.sweetandsavorybyshinee.com/wp-content/uploads/2020/07/Grilled-Pork-Kebabs-Shashlyk-4.jpg",
                Price = 10.99,
                Category = "Entrée",
                SpecialTag = ""
            });
        }
    }
}
