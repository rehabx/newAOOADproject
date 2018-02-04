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

        public void ViewPolices(string id)

        {
            foreach(InsurancePolicy ip in insurancePolicyList)
            {
                Console.WriteLine(ip.TermAndCondition + ip.PolicyEndDate + ip.PolicyStartDate + "name");
            }
        }

    }
}
