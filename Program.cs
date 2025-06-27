namespace StokTakip02
{
    class MenClothes : Product
    {
		public int Pants { get; set; }
		public int Coat { get; set; }
		public int Cravat { get; set; }
		public int Heels { get; set; }
	}
    class WomanClothes : Product
    {
		public int HighHeels { get; set; }
		public int Jewelry { get; set; }
		public int Case { get; set; }
	}
    class KidsClothes : Product
    {
		public int Toys { get; set; }
		public int Shoes { get; set; }
	}
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StokTakip02-Clothes!");
        }
    }
}
