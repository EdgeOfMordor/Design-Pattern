using System;

namespace Design_Pattern.AbstractFactory.Shoes.CasualShoes
{
    class CasualChildShoes: IChildShoes
    {
        public CasualChildShoes()
        {
            Console.WriteLine("I'm casual child shoes");
        }
    }
}
