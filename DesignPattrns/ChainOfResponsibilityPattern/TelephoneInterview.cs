using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class TelephoneInterview : BaseInterview
    {
        public override object Interview(Candidate candidate)
        {
            if (candidate.TelephoneInterview == true)
            {
                Console.WriteLine("You passed the telephone interview");
                return base.Interview(candidate);
            }
            else
                return "We will call you back";
        }
    }
}
