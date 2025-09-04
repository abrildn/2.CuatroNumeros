using System;

namespace CuatroNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            string linea;
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.WriteLine("Ingrese un número");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);

            int suma = num1 + num2 + num3 + num4;
            int promedio = suma / 4;

            Console.WriteLine("Total:");
            Console.WriteLine(suma);
            Console.WriteLine("Promedio:");
            Console.WriteLine(promedio);
            Console.ReadKey();
        }
    }
}
