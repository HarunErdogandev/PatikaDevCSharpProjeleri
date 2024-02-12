// See https://aka.ms/new-console-template for more information


/*Algoritma
Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.

Örnek: Input: Algoritma,3 Algoritma,5 Algoritma,22 Algoritma,0

Output: Algritma Algortma Algoritma lgoritma*/

Console.Write("Metn giriniz: ");
var text=Console.ReadLine();

var result = charRemove(text);
Console.WriteLine($"Düzenlenmiş metin: {result}" );

static string charRemove(string x)
{
    
    var text=x.Split(',');
    
    var value = text[0];
    var key = int.Parse((text[1]));

    value= value.Remove(key, 1);



    return value;
};
