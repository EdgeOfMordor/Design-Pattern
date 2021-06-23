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
            //Intern intern = new Intern();
            //intern
            //    .LearnEnglish()
            //    .LearnProgrammingLanguage()
            //    .TakeAProgrammingMarathon()
            //    .ApplyForAnInternship()
            //    .FinishInternship()
            //    .ApplyForAJob();
            #endregion

            #region FactoryMethod

            //IConsultant consultant;
            //Console.WriteLine("Write book genre(Fantasy or Detective)");
            //var genre = Console.ReadLine();
            //if (genre.ToLower() == "fantasy")
            //{
            //    consultant = new FantasyConsultant();
            //    consultant.ShowBook();
            //}
            //else if (genre.ToLower() == "detective")
            //{
            //    consultant = new DetectiveConsultant();
            //    consultant.ShowBook();
            //}

            #endregion
            Console.ReadLine();
        }
    }
}
