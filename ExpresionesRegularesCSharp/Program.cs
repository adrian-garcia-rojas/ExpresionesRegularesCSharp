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
            Regex regex = new Regex(@"^[a-z]+$"); // ^ = representa el inicio de nuestra cadena
                                            // $ = representa el final de la cadena
                                            // + = debe de haber por lo menos una letra o al infinito
                                            // * = debe puede haber algo o al infinito
            if (regex.IsMatch("dgfdgfdgd4"))
                Console.WriteLine("si");
            else Console.WriteLine("no");

            Console.ReadLine();

        }
    }
}
