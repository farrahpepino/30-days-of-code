using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> binaryvalues = new List<string>();

        for (int i = 0; i <= 12; i++) 
        {
            string stringRep = Convert.ToString(i, 2);
            Console.WriteLine(stringRep);
            binaryvalues.Add(stringRep);
        }

        foreach (var val in binaryvalues)
        {
            int e = Convert.ToInt32(val, 2);
            Console.WriteLine(e);
        }
    }
}
