using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class MedicalInsurance : InsurancePolicy
    {
        public MedicalInsurance(int a, double b, double c, DateTime d, DateTime e, string f, string g)
        {
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
