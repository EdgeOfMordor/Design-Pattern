using System;

namespace Design_Pattern.AbstractFactory.Shoes.ClassicShoes
{
    class ClassicChildShoes : IChildShoes
    {
        public ClassicChildShoes()
        {
            Console.WriteLine("I'm classic child shoes");
        }
    }
}
