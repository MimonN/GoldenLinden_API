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
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MenuItem>().HasData(new MenuItem
            {
                Id = 1,
                Name = "Borscht",
                Description = "A hearty soup that is one of Ukraine's most famous dishes. It is made with beets, cabbage, potatoes, and meat or sausage (usually beef or pork). The soup is flavored with dill, garlic, and bay leaves, and is often served with a dollop of sour cream on top.",
                Image = "Resourses/Images/borscht.jpg",
                Price = 7.99,
                Category = "Soup",
                SpecialTag = "Best Seller"
            }, new MenuItem
            {
                Id = 2,
                Name = "Solyanka ",
                Description = "A sour and salty soup that is often made with various types of meat, pickled cucumbers, and tomatoes. Other ingredients can include olives, capers, and lemon juice. The soup is typically served hot and is often enjoyed as a comforting winter meal.",
                Image = "Resourses/Images/Solyanka.jpg",
                Price = 8.99,
                Category = "Soup",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 3,
                Name = "Vinigret",
                Description = "A colorful salad made with boiled beets, carrots, and potatoes, as well as pickles and onions. The salad is dressed with vegetable oil and vinegar and is often served chilled.",
                Image = "Resourses/Images/Vinigret.jpg",
                Price = 8.99,
                Category = "Salad",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 4,
                Name = "Herring under a Fur Coat",
                Description = "A layered salad that is typically served during the New Year holiday season. It includes layers of herring, beets, potatoes, carrots, and mayonnaise. The salad is chilled before serving and can also be garnished with grated boiled egg.",
                Image = "Resourses/Images/Herring under a Fur Coat.jpg",
                Price = 10.99,
                Category = "Salad",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 5,
                Name = "Holubtsi",
                Description = " Cabbage rolls that are stuffed with a filling made from rice and meat (usually ground beef or pork). The rolls are typically baked in a tomato-based sauce and can be served hot or cold.",
                Image = "Resourses/Images/Holubtsi.jpg",
                Price = 10.99,
                Category = "Entree",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 6,
                Name = "Shashlyk",
                Description = "Grilled meat skewers that are typically made with pork or lamb. The meat is marinated in a mixture of spices, vinegar, and oil before being grilled over an open flame. Shashlik is often served with flatbread and a side salad.",
                Image = "Resourses/Images/Shashlyk.jpg",
                Price = 10.99,
                Category = "Entree",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 7,
                Name = "Salo",
                Description = "A popular Ukrainian snack made from cured pork fat. The salo is usually sliced thinly and served with garlic and bread. It is often accompanied by shots of vodka or other strong alcoholic drinks.",
                Image = "Resourses/Images/salo.jpg",
                Price = 10.99,
                Category = "Appetizer",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 8,
                Name = "Kholodets",
                Description = "A jellied meat dish made with pork or beef. The meat is simmered with onions, carrots, and spices, and then cooled until it solidifies. The dish is typically served cold and can be garnished with parsley or chopped garlic.",
                Image = "Resourses/Images/Kholodets.jpg",
                Price = 10.99,
                Category = "Appetizer",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 9,
                Name = "Cabbage Varenyky",
                Description = "Dumplings made from potato-based dough that are typically filled with mashed potatoes or cottage cheese. The vareniki are boiled until tender and can be served with sour cream or melted butter.",
                Image = "Resourses/Images/Varenyky with Cabbage.jpg",
                Price = 10.99,
                Category = "Side Dish",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 10,
                Name = "Herring under a Fur Coat",
                Description = " A sweet cake made with honey, flour, and spices like cinnamon and nutmeg. This cake is usually served with tea or coffee and is perfect for a sweet treat after a meal.",
                Image = "Resourses/Images/Medivnyk.jpg",
                Price = 10.99,
                Category = "Dessert",
                SpecialTag = ""
            }, new MenuItem
            {
                Id = 11,
                Name = "Pampushky",
                Description = "Soft and fluffy donuts that are typically served with garlic butter or jam. These donuts are often enjoyed as a breakfast or brunch item.",
                Image = "Resourses/Images/Pampushky.jpg",
                Price = 10.99,
                Category = "Dessert",
                SpecialTag = ""
            });
        }
    }
}
