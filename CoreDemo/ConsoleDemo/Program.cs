using System;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string saludo = "Hola mundo";            
            var año = 2019;
            double numeroPi = double.Parse("3,14");
            Console.WriteLine(saludo);
            Console.WriteLine(año);
            Console.WriteLine("Numero pi+1:" + (numeroPi+1));
        }
    }
}
