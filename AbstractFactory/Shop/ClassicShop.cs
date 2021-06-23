using Design_Pattern.AbstractFactory.Shoes;
using Design_Pattern.AbstractFactory.Shoes.ClassicShoes;

namespace Design_Pattern.AbstractFactory.Shop
{
    class ClassicShop : IShop
    {
        public IChildShoes GetChildShoes()
        {
            return new ClassicChildShoes();
        }

        public IFemaleShoes GetFemaleShoes()
        {
            return new ClassicFemaleShoes();
        }

        public IMaleShoes GetMaleShoes()
        {
            return new ClassicMaleShoes();
        }
    }
}
