using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class UpgradeInsurance : InsurancePolicy
    {
        public UpgradeInsurance(string tc, int a, double b, double c, DateTime d, DateTime e, string f, string g)
        {
            TermAndCondition = tc;
            PolicyNo = a;
            Cost = b;
            Payout = c;
            PolicyStartDate = d;
            PolicyEndDate = e;
            PaymentType = f;
            Status = g;



        }
    }
}
