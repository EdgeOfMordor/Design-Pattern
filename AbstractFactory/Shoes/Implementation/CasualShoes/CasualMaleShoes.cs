using System;

namespace Design_Pattern.AbstractFactory.Shoes.CasualShoes
{
    class CasualMaleShoes : IMaleShoes
    {
        public CasualMaleShoes()
        {
            Console.WriteLine("I'm casual male shoes");
        }
    }
}
