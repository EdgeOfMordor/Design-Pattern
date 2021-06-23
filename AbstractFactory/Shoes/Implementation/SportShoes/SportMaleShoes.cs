using System;

namespace Design_Pattern.AbstractFactory.Shoes.SportShoes
{
    class SportMaleShoes : IMaleShoes
    {
        public SportMaleShoes()
        {
            Console.WriteLine("I'm sport male shoes");
        }
    }
}
