using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Оperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Products liddle = new Products(1.20, 1.05, 5.60);
            Products billa = new Products(1.00, 0.97, 6.20);
            Console.WriteLine("Liddle :\n" + liddle);
            Console.WriteLine("Billa: \n" + billa);
            Console.WriteLine("Total:\n" + (liddle + billa));
        }
    }
}
