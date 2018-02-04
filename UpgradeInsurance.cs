using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class UpgradeInsurance : InsurancePolicy
    {
        public UpgradeInsurance(string tc, int a, double b, double c, DateTime d, DateTime e, string f, string g, string h, bool i)
        {
            TermAndCondition = tc;
            PolicyNo = a;
            Cost = b;
            Payout = c;
            PolicyStartDate = d;
            PolicyEndDate = e;
            PaymentType = f;
            Status = g;


                AddRider MyCode = new AddRider();
            }

            class AddRider
            {
                public AddRider() { }

                List<string> rider;
                public void ListInit(){}


                public void Rider()
                {
                    Console.WriteLine("Enter a rider to be added: ");
                    string userinput = Console.ReadLine();
                    if (rider.Count < 10)
                    {
                        if (userinput != "rider 1")
                        {
                            rider.Add(userinput);
                            foreach (var item in rider)
                            Console.Write(item.ToString() + " ");
                        }
                    }
                }
            }
        }
    }
}


