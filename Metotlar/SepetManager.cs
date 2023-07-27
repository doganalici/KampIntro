using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler."+urun.Adi+ " sepete Eklendi!");
        }

        //yeni bir bilgi girmek istediğimizde metotun çağırıldığı her yeri de değiştirmemiz gerektirdiği için bu yöntem kullanılmamalıdır
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler." + urunAdi + " sepete Eklendi!");
        }
    }
}
