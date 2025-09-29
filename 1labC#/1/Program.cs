using Microsoft.Win32;
using System; //4 var

class Program
{
    static void Main(string[] args)
    {
        const double pi = Math.PI;
        const double e = Math.E;
        
        Console.Write("input a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("input b: ");
        int b = int.Parse(Console.ReadLine());
        Console.ReadKey();
        double function = (Math.Pow(Math.Cos(pi), 7) + Math.Sqrt(Math.Log(Math.Pow(b, 4)))) / Math.Pow(Math.Sin((pi / 2) + a), 2);

        string formattedFunction = function.ToString("F2");
            
        Console.WriteLine(formattedFunction);
    }
}

