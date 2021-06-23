
namespace Design_Pattern.FactoryMethod.Genre
{
    class FantasyConsultant : IConsultant
    {
        public IBook ShowBook()
        {
            return new FantasyBook();
        }
    }
}
