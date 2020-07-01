﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using RPG.API.Database;
using RPG.API.Model;

namespace RPG.API.IntegrationTests
{
    public class CustomWebApplicationFactory<TStartUp> : WebApplicationFactory<TStartUp>
        where TStartUp : class
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                var serviceToRemove = services.SingleOrDefault(d =>
                    d.ServiceType == typeof(DbContextOptions<ApplicationDbContext>));
            
                if(serviceToRemove != null)
                {
                    services.Remove(serviceToRemove);
                }

                services.AddDbContext<ApplicationDbContext>(options =>
                {
                    options.UseInMemoryDatabase(Guid.NewGuid().ToString());
                });

                var serviceProvider = services.BuildServiceProvider();

                using(var scope = serviceProvider.CreateScope())
                {
                    var scopedServices = scope.ServiceProvider;
                    var db = scopedServices.GetRequiredService<ApplicationDbContext>();

                    db.Database.EnsureCreated();

                    db.Players.Add(new Player
                    {
                        Id = 1,
                        Name = "Tester",
                        Proffesion = "Warrior",
                        Health = 100,
                        Resource = 1,
                        Strength = 1,
                        Dexterity = 1,
                        Intelligence = 1,
                        Level = 1,
                        Items = new List<Item>()
                    });

                    db.SaveChanges();
                }
            });
        }
    }
}
