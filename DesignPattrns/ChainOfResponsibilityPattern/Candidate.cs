using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class Candidate
    {
        public bool TelephoneInterview { get; set; }
        public bool HrInterview { get; set; }
        public bool TehleadInterview { get; set; }

        public Candidate (bool ti, bool hi, bool thi)
        {
            TelephoneInterview = ti;
            HrInterview = hi;
            TehleadInterview = thi;
        }
    }
}
