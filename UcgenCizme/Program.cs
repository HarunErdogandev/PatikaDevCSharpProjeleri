// See https://aka.ms/new-console-template for more information






TriangleDraw(4);




void TriangleDraw(int x)
{
    const string star = "*";
    const string space = " ";

    //      *
    //     ***
    //    *****
    //   *******
   

    for (int i = 1; i <= x; i++)
    {
        
        for (int j = i; j <= x; j++)
        {
            Console.Write(space);
        }

        for (int y = 1; y < i*2; y++)
        {
            Console.Write(star);
        }
        Console.WriteLine();
          

        

    }

    

}