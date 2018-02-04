using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class EditInsurance : InsurancePolicy
    {
        public EditInsurance(int a, double b, double c, DateTime d, DateTime e, string f, string g)
        {
            PolicyNo = a;
            Cost = b;
            Payout = c;
            PolicyStartDate = d;
            PolicyEndDate = e;
            PaymentType = f;
            Status = g;
        }
        class Program
        {
            static void Main(string[] args)
            {
                for (int i = 1; i <= 1000; i = i + 1)
                {
                    Console.WriteLine(i);
                }

        
        







            }
        }
    }
}