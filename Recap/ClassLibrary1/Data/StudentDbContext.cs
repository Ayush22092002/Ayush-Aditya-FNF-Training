using ClassLibrary1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Data
{
    public class StudentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public IConfiguration Configuration { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var config = new ConfigurationBuilder()
                .SetBasePath("C:\\My Trainings\\Recap\\ClassLibrary1")
                .AddJsonFile("appsettings.json", false)
                .Build();


            if (Configuration == null)
            {
                Configuration = config;
            }
            var connectionstring = Configuration["connectionstring"];
            if (connectionstring == null)
            {
                Configuration = config;
                throw new ApplicationException("Could not read from the Configuration file");
            }

            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}
