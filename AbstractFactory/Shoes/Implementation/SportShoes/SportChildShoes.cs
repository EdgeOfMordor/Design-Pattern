using System;

namespace Design_Pattern.AbstractFactory.Shoes.SportShoes
{
    class SportChildShoes : IChildShoes
    {
        public SportChildShoes()
        {
            Console.WriteLine("I'm sport child shoes");
        }
    }
}
