using Liblary.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liblary.Data
{
    public class LiblaryContext : DbContext
    {
        private IConfiguration _config;

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public LiblaryContext()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json",true,true)
                .Build();
            _config = config;
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var a = _config["ConnectionStrings:LiblaryContextDb"];
            //optionsBuilder.UseSqlServer(@"Server=.\;Data Source=(localdb)\ProjectsV13;Database=Liblary;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:LiblaryContextDb"]);

            //C:\Users\halukcan.kasim\AppData\Local\Microsoft\VisualStudio\SSDT
            //Data Source=(localdb)\ProjectsV13;
            base.OnConfiguring(optionsBuilder);


        }

    }
}
