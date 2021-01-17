using System;

namespace KafamaGoreCalismalar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Adi = "Kazak";
            product1.Foto = "Kazak Fotoğrafı";
            product1.UrunFiyat = 127.42;

            Product product2 = new Product();
            product2.Adi = "Gömlek";
            product2.Foto = "Gömlek Fotoğrafı";
            product2.UrunFiyat= 152.53;

            Product[] products = new Product[] { product1, product2 };


            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].Adi);
                Console.WriteLine(products[i].Foto);
                Console.WriteLine(products[i].UrunFiyat);
                Console.WriteLine("-----");
            }
            Console.WriteLine("For bitti");

            foreach (var x in products)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Foto);
                Console.WriteLine(x.UrunFiyat);
                Console.WriteLine("------");
            }
            int a = 0;

            while (a<products.Length)

            {
                Console.WriteLine(products[a].Adi);
                Console.WriteLine(products[a].Foto);
                Console.WriteLine(products[a].UrunFiyat);
                Console.WriteLine("-------");
                a++;
            }





          
        }
    }
}
