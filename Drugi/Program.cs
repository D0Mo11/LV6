using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            box.AddProduct(new Product("Slusalice", 400));
            box.AddProduct(new Product("Tastatura", 300));
            box.AddProduct(new Product("Mis", 350));

            Iterator iterator = new Iterator(box);
            while (iterator.IsDone != true)
            {
                Console.WriteLine(iterator.Current.ToString() + " kn");
                Console.WriteLine();
                iterator.Next();
            }
        }
    }
}
