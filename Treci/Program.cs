using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treci
{
    class Program
    {
        static void Main(string[] args)
        {
            CareTaker careTaker = new CareTaker();
            ToDoItem item = new ToDoItem("RPPOON", "Predati analizu LV6 do 23:00 h", new DateTime(2020, 5, 14));
            careTaker.AddPreviousState(item.StoreState());
            Console.WriteLine(item.ToString());

            Console.WriteLine();

            item.Rename("KM");
            item.ChangeTask("Predati analizu iz KM-a");
            item.ChangeTimeDue(new DateTime(2020, 5, 16));
            careTaker.AddPreviousState(item.StoreState());
            Console.WriteLine(item.ToString());

            Console.WriteLine();

            item.RestoreState(careTaker.Undo());
            Console.WriteLine(item.ToString());

            Console.WriteLine();
            item.RestoreState(careTaker.Add());
            Console.WriteLine(item.ToString());
        }
    }
}
