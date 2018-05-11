using System;
using GymTimeApp.Interfaces;
using Microsoft.EntityFrameworkCore;
using Xamarin.Forms;
using GymTimeApp.Models;

namespace GymTimeApp.LocalData
{
	public class DataBase : DbContext
    {
		public DbSet<UserGym> UserGym { get; set; }
        public DbSet<Routine> Routine { get; set; }

		readonly string pathDB;

		public DataBase(string pathDB)
        {
			this.pathDB = pathDB;
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IDataBase>().GetDatabasePath();
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}
