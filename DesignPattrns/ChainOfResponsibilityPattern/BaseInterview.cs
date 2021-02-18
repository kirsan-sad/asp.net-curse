using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class BaseInterview : IInterview
    {
        private IInterview _nextInterview;
        public virtual object Interview(Candidate candidate)
        {
            if (_nextInterview != null)
                return _nextInterview.Interview(candidate);
            else
                return null;
        }

        public IInterview SetNext(IInterview interviewee)
        {
            _nextInterview = interviewee;

            return interviewee;
        }
    }
}
