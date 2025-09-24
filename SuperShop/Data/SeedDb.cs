using Microsoft.AspNetCore.Identity;
using SuperShop.Data.Entities;
using SuperShop.Helpers; // Add this using directive at the top of the file.


namespace SuperShop.Data
{
    public class SeedDb
    {
        private readonly DataContext  _context;
        private readonly IUserHelper _userHelper;
        private Random _random;

        public SeedDb(DataContext context, IUserHelper userHelper) 

        {
            _context = context;
            _userHelper = userHelper;
            _random = new Random();
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            var user = await _userHelper.GetUserByEmailAsync("mhcorcimari@gmail.com");
            if (user == null) 
            {
                user = new User
                {
                FirstName  ="Mihail",
                LastName = "Corcimar",
                Email = "mhcorcimari@gmail.com",
                UserName= "mhcorcimari@gmail.com",
                PhoneNumber = "123456789"
                };

                var result = await _userHelper.AddUserAsync(user, "123456 ");

                if (result != IdentityResult.Success)
                {
                   throw new InvalidOperationException("Could not create the user in seeder");
                }
            }

            if(!_context.Products.Any())
            {
                AddProduct("Iphone 12", user);
                AddProduct("Iphone 13", user);
                AddProduct("Iphone 14", user);
                AddProduct("Samsung Galaxy A10", user);
                AddProduct("Samsung Galaxy A20", user);
                AddProduct("Samsung Galaxy A30", user);
                AddProduct("Huawei P20", user);
                AddProduct("Huawei P30", user);
                AddProduct("Huawei P40", user);

                await _context.SaveChangesAsync();
            }
        }

        private void AddProduct(string name, User user)
        {
            _context.Products.Add(new Entities.Product
            {
                Name = name,
                Price = _random.Next(1000),
                IsAvailable = true,
                Stock = _random.Next(1, 100),
                User = user
            });
        }
    }
}
