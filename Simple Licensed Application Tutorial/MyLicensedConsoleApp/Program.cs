using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLicensedConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Este es un ejemplo de licenciamiento de una aplicación.");
            Console.WriteLine("-------------------------------------------------------------");

            SystemDateTimeProvider provider = new SystemDateTimeProvider();
            DateTime dateTime = provider.GetDateTime();
            Console.WriteLine(" Fecha y hora del sistema: {0}", dateTime);

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para terminar...");
            Console.ReadKey();
        }
    }
}
