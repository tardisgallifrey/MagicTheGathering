#nullable disable
using Microsoft.EntityFrameworkCore;
using MagicTheGathering.Models;

namespace MagicTheGathering.Data 
{
    public class Magic_DBContext : DbContext {

        //For Code First and EF Tools to work, DO NOT DEFINE A CONSTRUCTOR!
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{

			var connString = @"Server=localhost;Database=MagicDB;User Id=sa;Password=krys2018!;";
			optionsBuilder.UseSqlServer(connString);
				//.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);

			base.OnConfiguring(optionsBuilder);
		}
        public DbSet<Cards> cards { get; set; }

		public DbSet<SuperTypeList> supertypelist { get; set; }
    }
}