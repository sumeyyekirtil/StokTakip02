namespace StokTakip02
{
	public class Product : IEntity //Implement interface add
	{
		public int ProductId { get; set; }
		public string Department { get; set; }
		public int Upper { get; set; }
		public int Lower { get; set; }
		public DateTime CreateDate { get; set; }
		public List<Category>? Category { get; set; } //Category ile Product arasında 1 e 1 ilişki kurduk. 1 kategoride 1 den çok ürün bulunabilir.
		//public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		//public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		//public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		//public string Stock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		//Category class copy-paste
		public string Name { get; set; }
		public string Description { get; set; }
		//IEntity interface copy-paste
		public int Id { get; set; }
		public bool Stock { get; set; }
	}
}