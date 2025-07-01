using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip02
{
	public class Category : IEntity//class add
	{
		public string Name { get; set; }
        public DateTime CreateDate { get; set; }
		public string Description { get; set; }
		public List<Product>? Products { get; set; } //Category ile Product arasında 1 e 1 ilişki kurduk. 1 kategoride 1 den çok ürün bulunabilir.
		//IEntity copy-paste (aynı property leri kabul etmiyor)
		public int Id { get; set; }
		public bool Stock { get; set; }
	}
}
