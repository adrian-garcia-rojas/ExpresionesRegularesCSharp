using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExpresionesRegularesCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"^[a-zA-Z]+@[a-zA-Z]+\.[a-zA-Z]{2,3}$"); // ^ = representa el inicio de nuestra cadena
                                            // $ = representa el final de la cadena
                                            // + = debe de haber por lo menos una letra o al infinito
                                            // * = debe puede haber algo o al infinito
                                            // . = puede venir cualquier cosa
                                            // para validar un punto debemos de poner \.
                                            // [a-zA-Z]{2,3} puede ver un dominio o convinacion de min 2 letras hasta 3
            if (regex.IsMatch("adi@gmail.com"))
                Console.WriteLine("si");
            else Console.WriteLine("no");

            Console.ReadLine();

        }
    }
}
