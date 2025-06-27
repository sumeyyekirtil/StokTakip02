namespace StokTakip02
{
	public class Product : IEntity
	{
		public int ProductId { get; set; }
		public string Department { get; set; }
		public int Upper { get; set; }
		public int Lower { get; set; }
		public DateTime CreatDate { get; set; }
	}
}
