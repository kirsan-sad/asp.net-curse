using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var can1 = new Candidate(true, true, true);
            var can2 = new Candidate(false, true, true);
            var can3 = new Candidate(true, true, false);

            var th = new TelephoneInterview();
            var hi = new HrInterview();
            var thl = new TehleadInterview();

            th.SetNext(hi).SetNext(thl);

            var res = th.Interview(can1);

            Console.WriteLine(res);
        }
    }
}
