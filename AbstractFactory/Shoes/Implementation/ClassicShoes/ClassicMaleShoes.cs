using System;

namespace Design_Pattern.AbstractFactory.Shoes.ClassicShoes
{
    class ClassicMaleShoes : IMaleShoes
    {
        public ClassicMaleShoes()
        {
            Console.WriteLine("I'm classic male shoes");
        }
    }
}
