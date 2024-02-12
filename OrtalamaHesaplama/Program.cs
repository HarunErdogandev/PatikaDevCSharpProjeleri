// See https://aka.ms/new-console-template for more information
//Fibonicci dizisi her sayının kendinden önceki sayı ile toplanması sonucu oluşan bir sayı dizisi;
// 1 1 2 3 5 8 gibi







Console.Write("Fibonacci serisi derinliğini girin: ");
int depth = int.Parse(Console.ReadLine());

int[] fibSeries = FibonicciArray(depth);

double sum = 0;
foreach (int num in fibSeries)
{
    sum += num;
}
double average = sum / fibSeries.Length;
Console.WriteLine("Fibonacci serisindeki rakamların ortalaması: " + average);







static int [] FibonicciArray(int x)
{
    //{0,1,} 
    int[] fibonicci_array= new int[x];
    fibonicci_array[0]=0;
    fibonicci_array[1]=1;

    for(int i=2; i<x; i++)
    {
                     
        fibonicci_array[i] = fibonicci_array[i-1] + fibonicci_array[i-2];
    }



    return fibonicci_array;
}