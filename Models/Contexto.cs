using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIpaOmar.Models
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions options) : base(new DbContextOptionsBuilder().UseSqlServer("Data Source = .; Initial Catalog = EjemploPaOmar; Integrated Security=true;Trusted_Connection=True;").Options)
		{

		}

		public DbSet<Ejempl> Jaja { get; set; }
	}
}
