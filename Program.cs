using Design_Pattern.AbstractFactory;
using Design_Pattern.AbstractFactory.Shop;
using Design_Pattern.FactoryMethod;
using Design_Pattern.FactoryMethod.Genre;
using Design_Pattern.FluentInterface;
using System;

namespace Design_Pattern
{
    class Program
    {
        static void Main()
        {
            #region FluentInterface
            Intern intern = new Intern();
            intern
                .LearnEnglish()
                .LearnProgrammingLanguage()
                .TakeAProgrammingMarathon()
                .ApplyForAnInternship()
                .FinishInternship()
                .ApplyForAJob();
            #endregion

            Console.WriteLine();

            #region FactoryMethod

            IConsultant consultant;
            Console.WriteLine("Write book genre(Fantasy or Detective):");
            var genre = Console.ReadLine();
            if (genre.ToLower() == "fantasy")
            {
                consultant = new FantasyConsultant();
                consultant.ShowBook();
            }
            else if (genre.ToLower() == "detective")
            {
                consultant = new DetectiveConsultant();
                consultant.ShowBook();
            }
            #endregion

            Console.WriteLine();

            #region AbstractFactory
            IShop shop;
            Console.WriteLine("Write shop type(Sport, Casual, Classic):");
            var shopType = Console.ReadLine();
            if (shopType.ToLower() == "sport")
            {
                shop = new SportShop();
                
                GetShoesByType(shop);
            }
            else if (shopType.ToLower() == "casual")
            {
                shop = new CasualShop();

                GetShoesByType(shop);
            }
            else if (shopType.ToLower() == "classic")
            {
                shop = new ClassicShop();

                GetShoesByType(shop);
            }
            #endregion

            Console.ReadLine();
        }


        public static void GetShoesByType(IShop shop)
        {
            Console.WriteLine("Write shoes type(Child, Female, Male):");
            var shoesType = Console.ReadLine();
            if (shoesType.ToLower() == "child") { shop.GetChildShoes(); }
            else if (shoesType.ToLower() == "female") { shop.GetFemaleShoes(); }
            else if (shoesType.ToLower() == "male") { shop.GetMaleShoes(); }
        }
    }
}
