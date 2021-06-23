using System;

namespace Design_Pattern.AbstractFactory.Shoes.CasualShoes
{
    class CasualFemaleShoes : IFemaleShoes
    {
        public CasualFemaleShoes()
        {
            Console.WriteLine("I'm casual female shoes");
        }
    }
}
