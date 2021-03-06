﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class EditInsurance : InsurancePolicy
    {
        public EditInsurance(string tc, int a, double b, double c, DateTime d, DateTime e, string f, string g, string h, bool i)
        {
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