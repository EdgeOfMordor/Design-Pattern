using Design_Pattern.AbstractFactory.Shoes;

namespace Design_Pattern.AbstractFactory
{
    interface IShop
    {
        IMaleShoes GetMaleShoes();

        IFemaleShoes GetFemaleShoes();

        IChildShoes GetChildShoes();

    }
}
