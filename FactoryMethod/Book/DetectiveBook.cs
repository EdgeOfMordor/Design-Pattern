using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.FactoryMethod
{
    class DetectiveBook : IBook
    {
        public DetectiveBook()
        {
            Console.WriteLine("It is detective book");
        }
    }
}
