using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class InsurancePolicy
    {
        private int policyNo;
        private double cost;
        private double payout;
        private DateTime policyStartDate;
        private DateTime policyEndDate;
        private string paymentType;
        private string status;

        public int PolicyNo
        { get; set; }
        public double Cost
        { get; set; }
        public double Payout
        { get; set; }
        public DateTime PolicyStartDate
        { get; set; }
        public DateTime PolicyEndDate
        { get; set; }
        public string PaymentType
        { get; set; }
        public string Status
        { get; set; }



    }
}
