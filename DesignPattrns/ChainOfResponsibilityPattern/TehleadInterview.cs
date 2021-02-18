using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class TehleadInterview : BaseInterview
    {
        public override object Interview(Candidate candidate)
        {
            if (candidate.TehleadInterview == true)
            {
                Console.WriteLine("You passed the interview with Teh. Lead");
                Console.WriteLine("Congratulations, you've got offer");
                return base.Interview(candidate);
            }
            else
                return "We will call you back";
        }
    }
}
