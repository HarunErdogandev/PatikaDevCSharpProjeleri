// See https://aka.ms/new-console-template for more information
//Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.


List<int> numbers = new List<int>();
Console.Write("Kaç sayı giriceksiniz: ");
var lengt = int.Parse(Console.ReadLine());
int j = 0;
while (numbers.Count < lengt)
{

    Console.Write("Sayı giriniz: ");
    var number = int.Parse(Console.ReadLine());
    numbers.Add(number);
    Console.WriteLine("eklendi");
    j++;
    if (j == 10)
    {
        Console.Clear();
    }

}


//var result = new List<int>();
//for (int i = 0; i < numbers.Count-1; i++)
//{
//    if (!(numbers[i] == numbers[i+1]))
//    {
//        result.Add(numbers[i] + numbers[i+1]);

//    }
//    else
//    {
//        var temp = numbers[i] + numbers[i + 1];
//        result.Add(temp * temp);
//    }
//}


//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

int[,] numbers2 = { { 1, 2} ,{3,4 } };
for (int i = 0; i < numbers2.Length/2; i++)
{
	for (int j = 0; j < 2; j++)
	{
        Console.WriteLine(numbers2[i,j]);
    }
}






