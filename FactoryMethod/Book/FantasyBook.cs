using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.FactoryMethod
{
    class FantasyBook : IBook
    {
        public FantasyBook()
        {
            Console.WriteLine("It is fantasy book");
        }
    }
}
