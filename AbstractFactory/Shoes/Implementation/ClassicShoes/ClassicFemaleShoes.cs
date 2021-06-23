using System;

namespace Design_Pattern.AbstractFactory.Shoes.ClassicShoes
{
    class ClassicFemaleShoes : IFemaleShoes
    {
        public ClassicFemaleShoes()
        {
            Console.WriteLine("I'm classic female shoes");
        }
    }
}
