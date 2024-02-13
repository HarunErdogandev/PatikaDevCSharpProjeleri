// See https://aka.ms/new-console-template for more information


var input = "Merhaba Hello Algoritma X";




var words = input.Split(' ');

var sentece = "";

foreach (var word in words)
{
    sentece += " " + ReplaceChar(word);

}
Console.WriteLine(sentece);







static string ReplaceChar(string input)
{
    

    char[] charArray = input.ToCharArray();

    charArray[0] = input[input.Length - 1];

    charArray[input.Length - 1] = input[0];

    return new string(charArray);
}