using Design_Pattern.AbstractFactory.Shoes;
using Design_Pattern.AbstractFactory.Shoes.SportShoes;

namespace Design_Pattern.AbstractFactory.Shop
{
    class SportShop : IShop
    {
        public IChildShoes GetChildShoes()
        {
            return new SportChildShoes();
        }

        public IFemaleShoes GetFemaleShoes()
        {
            return new SportFemaleShoes();
        }

        public IMaleShoes GetMaleShoes()
        {
            return new SportMaleShoes();
        }
    }
}
