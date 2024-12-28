using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List of frameworks
        var frameworks = new List<string> { "Django", "Flask", "CherryPy", "Bottle", "Web2Py", "TurboGears" };

        // Accept integer input for the index
        int I;
        if (int.TryParse(Console.ReadLine(), out I))
        {
            try
            {
                // Try to access the element in the list at index I
                string V = frameworks[I];
                // Output the corresponding framework name if index is valid
                Console.WriteLine(V);
            }
            catch (ArgumentOutOfRangeException)
            {
                // If the index is out of range, print "Error"
                Console.WriteLine("Error");
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}