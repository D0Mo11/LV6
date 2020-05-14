using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cetvrti
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Domagoj Dragic", "Djakovo", 5000);
            Memento memento = new Memento(account);
            Console.WriteLine(account.ToString());

            Console.WriteLine();

            account.UpdateBalance(5000);
            account.ChangeOwnerAddress("Osijek");
            Console.WriteLine(account.ToString());

        }
    }
}
