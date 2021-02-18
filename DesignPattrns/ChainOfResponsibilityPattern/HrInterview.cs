using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class HrInterview : BaseInterview
    {
        public override object Interview(Candidate candidate)
        {
            if (candidate.HrInterview == true)
            {
                Console.WriteLine("You passed the interview with HR");
                return base.Interview(candidate);
            }
            else
                return "We will call you back";
        }
    }
}
