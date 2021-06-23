using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.FluentInterface
{
    public interface IIntern
    {
        IIntern LearnEnglish();

        IIntern LearnProgrammingLanguage();

        IIntern TakeAProgrammingMarathon();

        IIntern ApplyForAnInternship();

        IIntern FinishInternship();

        IIntern ApplyForAJob();
    }
}
