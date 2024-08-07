// See https://aka.ms/new-console-template for more information

using System;

namespace InheritanceExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci() {Title="Öğrenci", OgrenciNo = 1, Ad="Melike",Soyad="Göz"};
            Ogretmen ogretmen = new Ogretmen() { Title = "Öğretmen",Ad = "Sertan", Soyad = "Bozkuş", Maas = 70000 };

            ogrenci.ShowOgrenci();
            ogretmen.ShowOgretmen();
        }
    }
}
