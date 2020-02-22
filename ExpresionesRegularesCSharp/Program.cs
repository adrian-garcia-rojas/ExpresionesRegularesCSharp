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
            Regex regex = new Regex(@"\d");
            if (regex.IsMatch("79798"))
                Console.WriteLine("si");
            else Console.WriteLine("no");

            Console.ReadLine();

        }
    }
}
