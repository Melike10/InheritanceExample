using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    // base class 
    internal abstract class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Title { get; set; }

        public void ShowBaseKisi()
        {
            
            Console.WriteLine(Title+" Ad Soyad: "+ Ad + " " + Soyad);
        }

        
    }
    // Ogrenci inherite  properties and method of base class
    internal class Ogrenci : BaseKisi
    {
        public int OgrenciNo { get; set; }

        public void ShowOgrenci()
        {
            Console.WriteLine("Öğrenci No:"+OgrenciNo );
            ShowBaseKisi();
        }
        
    }

    // Ogretmen inherite  properties and method of base class
    internal class Ogretmen : BaseKisi
    {
        public decimal Maas { get; set; }
        public void ShowOgretmen() {

            ShowBaseKisi();
            Console.WriteLine("Maaş Bilgisi"+ Maas);
        }
    }
}
