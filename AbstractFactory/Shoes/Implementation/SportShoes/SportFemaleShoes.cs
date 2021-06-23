using System;

namespace Design_Pattern.AbstractFactory.Shoes.SportShoes
{
    class SportFemaleShoes : IFemaleShoes
    {
        public SportFemaleShoes()
        {
            Console.WriteLine("I'm sport female shoes");
        }
    }
}
