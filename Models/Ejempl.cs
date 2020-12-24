using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace APIpaOmar.Models
{
	[Table("Jaja")]
	public class Ejempl
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Apellido { get; set; }
	}
}
