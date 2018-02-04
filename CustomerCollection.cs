using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class CustomerCollection
    {
        public List<InsurancePolicy> insurancePolicyList;

        public CustomerCollection(List<InsurancePolicy> insurancePolicyList)
        {
            this.insurancePolicyList = insurancePolicyList;
        }

        public void ViewPolices(string name)

        {
            int i = 0;
            foreach (InsurancePolicy ip in insurancePolicyList)
            {
                if (ip.Ownedby.ToUpper() == name.ToUpper() && ip.IsDue == true )
                {
                    i++;

                    Console.WriteLine(i + ". " + ip.TermAndCondition + " | " + ip.PolicyNo + " | " + ip.Cost + " | " + ip.Payout + " | " + ip.PolicyStartDate + " | " + ip.PolicyEndDate + " | "
                       + ip.PaymentType + " | " + ip.Status + " | " + ip.Ownedby + " | " + ip.IsDue);
                       

                }
            }
        }

    }
}

