using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciobasico3
{
    internal class Program
    {
        static void Main(string[] args)
        {


            char ascii;

            Console.WriteLine("Ingrese valor: ");
            ascii = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Valor ASCII de :" + ascii + " es " + Convert.ToInt32(ascii));
            Console.ReadKey();


        }
    }
}
