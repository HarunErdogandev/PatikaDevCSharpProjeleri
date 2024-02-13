// See https://aka.ms/new-console-template for more information
/*
 * Alan Hesaplama
C# Console uygulaması oluşturarak aşağıdaki gereksinimleri karşılayan uygulamayı yazınız.

İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı (Daire, Üçgen, Kare, Dikdörtgen vb..)
Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
Hesaplanmak istenen boyutu kullanıcıdan alınmalı (Çevre, Alan, Hacim vb..)
Hesap sonucunu anlaşılır şekilde geri döndürmeli.
Dikkat Edilmesi Gereken Noktalar :

Kod tekrarından kaçınılmalı
Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli.
 */

using AreaCalculation.Enums;
using AreaCalculation.Models;

Console.WriteLine("Şekil: 1-Kare, 2-Üçgen, 3-Daire, 4-Dikdörtgen");
Console.Write("İşlem yapılmak istenen geometrik şekli veriniz: ");

var input = Console.ReadLine();
Console.Clear();


switch (int.Parse(input))
{
	case (int)Proces.square:
		Square square = new Square();
		
        Console.WriteLine("Hesaplama Türü Seçiniz : 1-Alan ,2-Çevre");
        var Cal = int.Parse(Console.ReadLine());
        Console.Clear();

        if (Cal==1)
		{
            Console.WriteLine("Alanı Hesaplamayı Seçtiniz");
            Console.Write("Lütfen Bir kenar uzunluğu  giriniz: ");
            var area = double.Parse(Console.ReadLine());
            Console.WriteLine("Alan:"+(square.AreaCal(area)));
		}
		else
		{
            Console.WriteLine("Çevre Hesaplamayı Seçtiniz");
            Console.Write("Lütfen Bir kenar uzunluğu  giriniz: ");
            var area = double.Parse(Console.ReadLine());
            Console.WriteLine("Çevre:" + (square.PerimeterCal(area)));

        };


        break;
    case (int)Proces.rectangle:
        Rectangle rectangle = new Rectangle();

        break;

}












