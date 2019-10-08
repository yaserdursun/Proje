using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrepareAnExam.Web.DB.Tables;
using PrepareAnExam.Web.Services;
using System;
using System.IO;
using System.Linq;

namespace PrepareAnExam.Web.DB
{
    public static class InitializeData
    {
        public static IServiceCollection CreateTestUsers(this IServiceCollection services)
        {
            try
            {
                var serviceProvider = services.BuildServiceProvider();
                var signInManager = serviceProvider.GetService<ISignInManager>();
                var configuration = serviceProvider.GetService<IConfiguration>();

                var dbName = configuration.GetConnectionString("DefaultConnection");
                if (File.Exists(dbName))
                    return services;

                using (var db = new SqliteContext(configuration))
                {
                    db.Database.EnsureCreated();
                    if (db.Users.Any())
                        return services;

                    var r1Hashed = signInManager.CreadHashedUser("123");
                    var r1 = db.Users.Add(new User
                    {
                        UserName = "admin",
                        FirstName = "Admin",
                        LastName = "Manager",
                        Email = "admin@manager.com",
                        Password = r1Hashed.Item1,
                        Salt = r1Hashed.Item2
                    });

                    var r2Hashed = signInManager.CreadHashedUser("12345");
                    var r2 = db.Users.Add(new User
                    {
                        UserName = "test",
                        FirstName = "Test Name",
                        LastName = "Test Surname",
                        Email = "test@test.com",
                        Password = r2Hashed.Item1,
                        Salt = r2Hashed.Item2
                    });

                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //TODO:...
            }

            return services;
        }
    }
}
