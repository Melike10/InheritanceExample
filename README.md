# InheritanceExample
Bu projede patika dev .net-core eğitimi için C# dili kullanarak bir miras alma örneği yapılmıştır. (   This project demonstrate how to create an inheritance example using C# tech for Patika Dev .net core course).
## İçerik


- [Kullanım](#kullanım-(usage))
- [Kod Açıklaması](#kod-açıklaması)

## Kullanım (Usage)

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

Yukarıdaki kod bloğu BaseKisi sınıfından referans almış Ogretmen ve Ogrenci sınıflarının base sınıfta bulunan title, ad , soyad kavramlarında erişebileceğini göstermiştir.
(The code block above shows that the Ogretmen and Ogrenci classes, which are referenced from the BaseKisi class, can access the title, ad and soyad concepts in the base class)

## Kod Açıklaması
BaseKisi Class
Ad, Soyad, Title: General properties for a person's first name, last name, and title.
ShowBaseKisi(): Method that prints the person's title, first name, and last name.

Ogrenci Class
Inherits from BaseKisi.
OgrenciNo: Property for the student's number.
ShowOgrenci(): Method that prints the student's number and calls ShowBaseKisi() to print the inherited properties.

Ogretmen Class
Inherits from BaseKisi.
Maas: Property for the teacher's salary.
ShowOgretmen(): Method that prints the teacher's salary and calls ShowBaseKisi() to print the inherited properties.
