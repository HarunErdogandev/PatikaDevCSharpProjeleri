// See https://aka.ms/new-console-template for more information



Console.Write("Dairenin yarıçapını girin: ");
double yaricap;

// Kullanıcıdan yarıçapı alır ve girişin doğru bir sayı olup olmadığını kontrol eder.
while (!double.TryParse(Console.ReadLine(), out yaricap) || yaricap <= 0)
{
    Console.WriteLine("Geçersiz giriş. Pozitif bir sayı girin.");
    Console.Write("Dairenin yarıçapını girin: ");
}

// Daireyi çizmek için bir döngü kullanılır.
for (int i = 0; i <= 2 * yaricap; i++)
{
    for (int j = 0; j <= 2 * yaricap; j++)
    {
        // Dairenin içinde mi, yoksa dışında mı olduğunu kontrol eder.
        double mesafe = Math.Sqrt(Math.Pow(i - yaricap, 2) + Math.Pow(j - yaricap, 2));
        if (mesafe > yaricap - 0.5 && mesafe < yaricap + 0.5)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();
}

Console.ReadLine();