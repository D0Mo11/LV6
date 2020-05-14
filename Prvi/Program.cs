using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prvi
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook();
            notebook.AddNote(new Note("Note#1", "Domagoj Dragic"));
            notebook.AddNote(new Note("Note#2", "RPPOON"));
            notebook.AddNote(new Note("Note#3", "LV6"));

            Iterator iterator = new Iterator(notebook);
            while (iterator.IsDone != true)
            {
                iterator.Current.Show();
                iterator.Next();
            }
        }
    }
}
