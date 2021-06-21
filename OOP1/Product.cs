using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{       
        // BU TİP KLASLARDA SADECE ÖZELLİK OLUR !
    class Product  // ÜRÜN  
    {
        public int Id { get; set; } // NESNEYİ DİĞERİNDEN AYIRT ETMEK İÇİN VERİTABANINDA KULLANILAN ALAN
        public int CategoryId { get; set; } // ÜRÜNÜN HANGİ KATEGORİYE AİT OLDUĞU
        public string ProductName { get; set; } // ÜRÜNÜN ADI
        public double UnitPrice { get; set; } // ÜRÜNÜN FİYATI
        public int UnitInStock { get; set; } // STOK ADEDİ
    }
}
