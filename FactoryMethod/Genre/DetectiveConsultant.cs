using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.FactoryMethod.Genre
{
    class DetectiveConsultant : IConsultant
    {
        public IBook ShowBook()
        {
            return new DetectiveBook();
        }
    }
}
