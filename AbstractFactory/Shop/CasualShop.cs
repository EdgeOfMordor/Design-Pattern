using Design_Pattern.AbstractFactory.Shoes;
using Design_Pattern.AbstractFactory.Shoes.CasualShoes;

namespace Design_Pattern.AbstractFactory.Shop
{
    class CasualShop : IShop
    {
        public IChildShoes GetChildShoes()
        {
            return new CasualChildShoes();
        }

        public IFemaleShoes GetFemaleShoes()
        {
            return new CasualFemaleShoes();
        }

        public IMaleShoes GetMaleShoes()
        {
            return new CasualMaleShoes();
        }
    }
}
