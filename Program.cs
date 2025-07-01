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
			Console.WriteLine("StokTakip02 - Clothes!");
			Console.WriteLine();
			Product ürün = new Product(); //yeni değer atama işlemi
			ürün.Description = "Stok yenileme";
			Console.WriteLine("Stok Türü: " + ürün.Description);

			WomanClothes woman = new WomanClothes();
			woman.Department = "Kadın Reyonu";
			woman.Case = 12;
			woman.Lower = 47;
			woman.ProductId = 1; //Tur Stok class ının kalıtımdan dolayı kullanılabilir
			woman.CreateDate = DateTime.Now;//yazılan zamanın kontrolünü sağlamak için kullanıldı.
			Console.WriteLine("Kayıt Tarihi : " + woman.CreateDate);
			Console.WriteLine("Departman : " + woman.Department);
			Console.WriteLine("Ürün Numarası : " + woman.ProductId);
			Console.WriteLine("Çanta : " + woman.Case);
			Console.WriteLine("Alt Takım Satısı : " + woman.Lower);
			Console.WriteLine();

			MenClothes men = new();
			men.Name = "Erkek Reyonu";
			men.Id = 2;
			men.Heels = 24;
			men.Pants = 19;
			men.Coat = 8;
			men.Cravat = 4;
			men.Upper = 5;
			men.CreateDate = DateTime.Today;
			Console.WriteLine("Kayıt Zamanı " + men.CreateDate); //Boşluklara duyarlı
			Console.WriteLine($"Stok Detayı : {men.Name}, \nAyakkabı(Kutu) : {men.Heels}, \nPantolon : {men.Pants}, \nCeket: {men.Coat}, \nKravat : {men.Cravat}, \nÜst Takım : {men.Upper}");

			KidsClothes yeniStok = new()
			{
				Department = "Çocuk Reyonu",
				Id = 3,
				Stock = true,
				Toys = 38,
				Shoes =14,
				Lower = 18,
				Upper = 21,
				CreateDate = DateTime.Now
			};
			if (yeniStok.Stock == true) //if döngüsüyle eğer stok true ise yazdırır
			{
				Console.Write($"\nStok Detayı : {yeniStok.Department} \nOyuncak Stok: {yeniStok.Toys} \nAyakkabı(Çift) : {yeniStok.Shoes} \nAlt Takım : {yeniStok.Lower} \nÜst Takım : {yeniStok.Upper} \nGüncellenme Tarihi : {yeniStok.CreateDate}"); //$ : yeniStok değişkenini aktif eder
			}
			Console.WriteLine();

			WomanClothes yeniStok2 = new()
			{
				Name = "Kadın Reyonu Güncelleme",
				Id = 4,
				Stock = true,
				Upper = 27,
				Jewelry = 42,
				HighHeels = 53,
				Case = 19,
				CreateDate = DateTime.Now,
			};
			if (yeniStok2.Stock == true)
			{
				Console.WriteLine("Stok detayı : " + yeniStok2.Name);
				Console.WriteLine("Üst Takım : " + yeniStok2.Upper);
				Console.WriteLine("Takı Setleri : " + yeniStok2.Jewelry);
				Console.WriteLine("Topuklu Ayakkabı : " + yeniStok2.HighHeels);
				Console.WriteLine("Çanta : " + yeniStok2.Case);
				Console.WriteLine("Yenileme Tarihi: " + yeniStok2.CreateDate);
			}
			Console.WriteLine();

			KidsClothes kids = new KidsClothes()
			{ 
				ProductId = 5,
				Department = "Çocuk Reyonu Güncelleme",
				Lower = 8,
				Upper = 5,
				Shoes = 9,
				Toys = 26,
				Description = "Depodan sonradan çıkarıldı",
				CreateDate = DateTime.UtcNow //evrensel zamanı temsil eder
			};
			Console.Write($"\nKayıt Detayı : {kids.Department}"); //writeLine ile iki satır atlamış oluyo '\n' kullandığımız içiin
			Console.Write($"\nÜst Takım Grubu : {kids.Lower}");
			Console.Write($"\nAlt Takım Grubu : {kids.Upper}");
			Console.Write($"\nAyakkabı(Çift) : {kids.Shoes}");
			Console.Write($"\nOyuncak : {kids.Toys}");
			Console.Write($"\nAçıklama Bölümü : {kids.Description}");
			Console.Write($"\nOluşturulma Zamanı : {kids.CreateDate}");
		}
	}
}