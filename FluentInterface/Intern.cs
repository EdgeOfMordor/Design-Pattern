using System;

namespace Design_Pattern.FluentInterface
{
    public class Intern : IIntern
    {
        public IIntern LearnEnglish()
        {
            Console.WriteLine("Intern now knows English");

            return this;
        }

        public IIntern LearnProgrammingLanguage()
        {
            Console.WriteLine("Intern now knows programming language");

            return this;
        }

        public IIntern TakeAProgrammingMarathon()
        {
            Console.WriteLine("Intern finished the programming marathon");

            return this;
        }

        public IIntern ApplyForAnInternship()
        {
            Console.WriteLine("Intern applied for an internship");

            return this;
        }

        public IIntern FinishInternship()
        {
            Console.WriteLine("Intern finished an internship");

            return this;
        }

        public IIntern ApplyForAJob()
        {
            Console.WriteLine("Intern finished his training");

            return this;
        }

    }
}
