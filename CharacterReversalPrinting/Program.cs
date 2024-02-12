// See https://aka.ms/new-console-template for more information



using System.Linq;

var input = "Merhaba Hello Question";

var result = ReverseInput(input);

Console.WriteLine(result);

static string ReverseInput(string input)
{
    var words = input.Split(" ");
    input = " ";
    for (int i = 0; i < words.Length; i++)
    {
        var word = words[i].Reverse();
        foreach (var item in word)
        {
            if (char.IsUpper(item))
                input = input + item +" ";
            else
             input =input+item;
        }
        
    }

    

    return input;
}
