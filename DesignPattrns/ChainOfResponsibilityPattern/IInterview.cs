using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public interface IInterview
    {
        IInterview SetNext(IInterview interviewee);
        object Interview(Candidate candidate);
    }
}
