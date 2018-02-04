using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class CarInsurance : InsurancePolicy
    {
        public CarInsurance(string tc, int a, double b, double c, DateTime d, DateTime e, string f, string g, string h, bool i)
        {
            TermAndCondition = tc;
            PolicyNo = a;
            Cost = b;
            Payout = c;
            PolicyStartDate = d;
            PolicyEndDate = e;
            PaymentType = f;
            Status = g;
            Ownedby = h;
            IsDue = i;

        }
    }
}
