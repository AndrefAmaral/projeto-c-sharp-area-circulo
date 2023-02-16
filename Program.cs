using System;
using System.Globalization;

namespace Area_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite o  raio do circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(raio, 2.0);
            Console.WriteLine("Area = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
