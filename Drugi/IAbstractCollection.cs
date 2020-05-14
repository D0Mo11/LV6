using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drugi
{
    interface IAbstractCollection
    {
        IAbstractIterator GetIterator();
    }
}
