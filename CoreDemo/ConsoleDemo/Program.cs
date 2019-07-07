using System;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string saludo = "Bienvenido a mi aplicación";            
            var año = DateTime.Now.Year;
            double numeroPi = 3.14;
            Console.WriteLine(saludo);

            while(1>0)
            {
                Console.WriteLine("1=Mostrar año actual, 2=Valor del número pi, 3=Contador");
                var numeroSeleccionado = Console.ReadLine();
                Menu menu = Menu.Ninguna;

                try 
                {
                  menu = Enum.Parse<Menu>(numeroSeleccionado);
                }
                catch (FormatException)
                {
                    Console.WriteLine("El dato ingresado no es válido");
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Excepción:" + ex.Message);        
                }
               
                if (menu == Menu.Año)
                {
                    Console.WriteLine(año);
                }
                else if(menu == Menu.PI)   
                {
                    Console.WriteLine("Número pi:" + numeroPi);
                }
                else if(menu == Menu.Contador)
                {
                    Console.WriteLine("Ingrese el limite del contador");
                    var limiteContador = Console.ReadLine();
                    int intLimiteContador = 0;
                    int.TryParse(limiteContador, out intLimiteContador);

                    for (int i=1; i<=intLimiteContador; i++)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                }
                else
                {
                    Console.WriteLine("No ha seleccionado un valor válido");
                }           
            }
        }
    }

    public enum Menu
    {
        Ninguna = 0,
        Año=1,
        PI=2,
        Contador=3
    }
}
