using System;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a mi aplicacion");
            Console.WriteLine("1=Saludo, 2=Valor Pi, 3=Año actual");
            string ValorIngresado = Console.ReadLine();

            //se compara 1 para saludo
            switch(ValorIngresado)
        	{
                case "1":
                 const string saludo = "Hola mundo";  
                 Console.WriteLine(saludo);
                break;
                case "2":
                case "3":
                return;
                break;
            }


            if (ValorIngresado == "1")
            {
                const string saludo = "Hola mundo";  
                Console.WriteLine(saludo);
            }
            else if (ValorIngresado == "2")
            {
                 double numeroPi = double.Parse("3,14");  
                 Console.WriteLine("Numero pi:" + numeroPi.ToString()); 
            }
            else if (ValorIngresado == "3")
            {
                var año = DateTime.Now.Year;
                Console.WriteLine(año);
            }
        }
    }
}
