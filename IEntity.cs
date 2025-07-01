using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip02
{
	public interface IEntity //ınterface kullanıldı
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public DateTime CreateDate { get; set; }
		public bool Stock { get; set; }
	}
}
