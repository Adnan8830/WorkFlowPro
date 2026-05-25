using WorkFlowProNew.API.Models;

namespace WorkFlowProNew.API.Data
{
    public static class DbSeeder
    {
        public static void Seed(AppDbContext context)
        {
            Console.WriteLine("Seeder Running");

            if (!context.Users.Any())
            {
                Console.WriteLine("Inserting Admin User");

                context.Users.Add(
                    new User
                    {
                        UserName = "admin",
                        Email = "admin@workflowpro.com",
                        Password = BCrypt.Net.BCrypt.HashPassword("123"),
                        Role = "Admin"
                    });

                context.SaveChanges();

                Console.WriteLine("Inserted");

            }
        }
    }
}