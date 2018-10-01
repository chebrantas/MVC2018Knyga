using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVC2018Knyga.Models.EntityTypeConfiguration;

namespace MVC2018Knyga.Models
{
    //DbContext yra Entity Framework clase ir duoda priejima prie album, genre, artist informacijos duomenu bazeje
    public class MusicStoreDB : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
            //name =MusicStoreDB yra connectionstringo vardas pagal kury db parenkamas
        public MusicStoreDB() : base("name=MusicStoreDBx")
        {
        }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }



        //naudojam kad visus nustatymus duomenu bazei atliktu pagal nurodymus ko nepadare automatiskai . visi nustatymai sudeti i 
        //Models/EntityTypeConfiguration o is ten uzloadinami OnModelCreating metodu
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderConfiguartion());

            base.OnModelCreating(modelBuilder);
        }
    }
}
