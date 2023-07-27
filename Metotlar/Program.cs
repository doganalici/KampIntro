using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
      
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safe -- tip güvenliği
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi+ "\n" + urun.Fiyati+ "\n" + urun.Aciklama+"\n-------------------");
            }

            Console.WriteLine("\n---------------Metotlar---------------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            //direk urun olarak paremetre verdiğimiz için ürün içine yeni tanımlanan ne olursa olsun bu kısmada otomatik olarak 
            //bilgi girişi olduktan sonra eklenir ve yazdırılabilir ya da ürünle ilgili bir değişiklik olursa çağırıldığı her yerde otomatik olarak değişir
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //stok adedi sonradan eklendiği için bütün ekle2 içerisine tek tek stok bilgisi girmek zorunda kaldık
            Console.WriteLine("----------------------------\n");
            sepetManager.Ekle2("Armut", "Yeşil armut", 12,10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12,8);


        }
    }
}
