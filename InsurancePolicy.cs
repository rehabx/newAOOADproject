﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class InsurancePolicy
    {
        private string termsAndCondition;
        private int policyNo;
        private double cost;
        private double payout;
        private DateTime policyStartDate;
        private DateTime policyEndDate;
        private string paymentType;
        private string status;
        private string ownedBy;
        private bool isDue;
        private Employee staff;
        private Customer customers;
        public Customer Customers
        {
            get; set;

            //set
            //{
            //    if(customers != value)
            //    {
            //        customers = value;
            //        value.Insurancepolicies = this;
            //    }
            //}
           
        }

        public string TermAndCondition
        { get; set; }
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
        public string Ownedby
        { get; set; }
        public bool IsDue
        { get; set; }
        public Employee Staff
        { get; set; }

 



       // public createInsurancePolicy(){}



    }
}
