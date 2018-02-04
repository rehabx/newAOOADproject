﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class Program
    {
        public static CustomerCollection c;

        public static List<Employee> employeeList = new List<Employee>();
        public static List<JuniorAgent> juniorAgentList = new List<JuniorAgent>();
        public static List<Agent> agentList = new List<Agent>();
        public static List<SeniorAgent> SeniorAgentList = new List<SeniorAgent>();
        public static List<Administrator> administratorList = new List<Administrator>();
        public static List<TravelInsurance> travelInsuranceList = new List<TravelInsurance>();
        public static List<MedicalInsurance> medicalInsuranceList = new List<MedicalInsurance>();
        public static List<CarInsurance> carInsuranceList = new List<CarInsurance>();
        public static List<Customer> customerList = new List<Customer>();
        public static List<InsurancePolicy> insurancePoliciesList = new List<InsurancePolicy>();

        public static string LogonEmployee(string userId)
        {
            bool checkUser = false;
            string end = "";

            foreach (Employee employee in employeeList)
            {
                if (employee.Id.ToUpper() == userId.ToUpper())
                {
                    Console.Write("Welcome " + employee.Name);
                    checkUser = true;
                    end = "valid";
                    break;
                }
            }
            if (checkUser == false)
            {
                Console.WriteLine("User does not exist, please try again.");
                end = "error";
            }

            return end;
        }
        public static string LogonCustomer(string userId)
        {
            bool checkUser = false;
            string end = "";

                        foreach (Customer customer in customerList) //change to customer
                        {
                            if (customer.Uid == userId)
                            {
                                Console.Write("Welcome " + customer.Name + "\n");
                                checkUser = true;
                                end = "valid";
                                break;
                            }
                        }
                        if (checkUser == false)
                        {
                            Console.WriteLine("User does not exist, please try again.");
                            end = "error";
                        }
            return end;
        }



        static void Main(string[] args)
        {
            Initialisation();
            c = new CustomerCollection(insurancePoliciesList);


            Console.WriteLine("Welcome to Provident Insurance! \n" +
                              "===================\n" +
                              "1. Log In to Staff\n" +
                              "2. Log In to Customer\n" +
                              "==================\n" +
                              "Please enter your option:");
            string option = Console.ReadLine();

            string userId;
            string user;

            switch (option)
            {
                case "1":
                    Console.WriteLine("Please enter your ID:");
                    userId = Console.ReadLine();
                    Console.WriteLine("\n");
                    string mainselection;

                    user = LogonEmployee(userId);
                    if (user == "valid")
                    {
                        Console.WriteLine("Main Menu\n" +
                                          "1. Create new insurance policy\n" +
                                          "2. Edit policy\n" +
                                          "3. Send alerts for policies with premium due\n" +
                                          "--------------------------------------------\n" +
                                          "please enter your option:");
                        mainselection = Console.ReadLine();

                        switch(mainselection)
                        {
                            case "1":
                                CreatePolicy();
                                break;
                            case "2":
                                break;
                            case "3":
                                break;
                        }



                    }
                    


                    break;
                case "2":
                    Console.WriteLine("Please enter your ID:");
                    userId = Console.ReadLine();
                    
                    user = LogonCustomer(userId);

                    if (user == "valid")
                    {
                        Console.WriteLine("1. View and pay oustanding insurance premium\n" +
                                          "--------------------------------------------\n" +
                                          "Please enter your option:");
                        string choice = Console.ReadLine(); 
                        if ( choice == "1")
                        {

                            foreach (Customer customer in customerList)
                            {
                                if (customer.Uid == userId)
                                {
                                    foreach(InsurancePolicy insurancepolices in insurancePoliciesList )
                                    {
                                       
                                        {
                                            c.ViewPolices(customer.Name);
                                            //Console.WriteLine(insurancepolices.TermAndCondition + insurancepolices.PolicyNo + insurancepolices.Cost + insurancepolices.Payout +
                                            //    insurancepolices.PolicyStartDate + insurancepolices.PolicyEndDate + insurancepolices.PaymentType + insurancepolices.Status + insurancepolices.Staff.Name + "\n");
                                            Console.ReadLine();
                                        }


                                        Console.ReadLine();

                                        
                                    }
                                    Console.ReadLine();
                                }
                            }
                            //foreach (InsurancePolicy insurancepolicy in insurancePoliciesList )
                            //{
                            //    if(
                                  
                            //}
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection. Please try again");
                        }





                    }

                    break;
                default: 
                    break; 
            }





            /*if (option == 1)
            {
                Console.WriteLine("payment");
            }
            else if (option == 2)
            {
                Console.WriteLine("1. send email n print letter" +
                                  "2. add customer things" +
                                  "please enter your option");

                int options = Convert.ToInt32(Console.ReadLine());
                if (options == 1)
                {
                    Console.WriteLine("do you really want to send the email and print the letter?" +
                                      "enter your option:");
                    string yn = Console.ReadLine();
                    if (yn == "y" || yn == "Y")
                    {
                        Console.WriteLine("email has been send and letter has been printed");
                    }
                    else if (yn == "n" || yn == "N")
                    {
                        Console.WriteLine("You have exited this thing");
                    }
                }
            }


            static void sendmail()
                {
                 InsurancePolicy thing = new InsurancePolicy();
                             if(thing.Status == "due")
                             {
                                 Console.WriteLine("Do you want to print letter and send email?"+
                                 "Enter your option[Y/N]: ");
                                  string option = Console.ReadLine();

                                 if(option == "Y")
                                 {
                                     Console.WriteLine("Letter printed and Email sent!");
                                 }
                                 else if(option == "N")
                                 {
                                 Console.WriteLine(Main);
                                 }
                                 else
                                 {
                                     Console.WriteLine("Bye!");
                                 }   
                             }
                }

  case "3":
                     Console.WriteLine("Please enter your ID:");
                    userId = Console.ReadLine();

                    user = LogonCustomer(userId);

                    if (user == "valid")
                        {
                           Console.WriteLine("send mail?");
                         


             */
        }

        public static void CustomerViewInsurance (string userId)
        {
            foreach (Customer customer in customerList) //change to customer
            {
                if (customer.Uid == userId)
                {
                    customer.ViewPolicies(userId);
                }
            }

            
        }







        public static void Initialisation()
        {

            JuniorAgent ja = new JuniorAgent("Marcus", "1001", "JuniorAgent");
            juniorAgentList.Add(ja);
            employeeList.Add(ja);
            Agent ag = new Agent("Derrick", "2001", "Agent");
            agentList.Add(ag);
            employeeList.Add(ag);
            SeniorAgent sa = new SeniorAgent("jennifer", "3001", "SeniorAgent");
            SeniorAgentList.Add(sa);
            employeeList.Add(sa);
            Administrator ad = new Administrator("Joshua", "4001", "Adminsitrator");
            administratorList.Add(ad);
            employeeList.Add(ad);
            TravelInsurance ti = new TravelInsurance("Only for 1", 0001, 50.00, 1000.00, new DateTime(1997,1,8), new DateTime(2017,1,8), "monthly", "active", "May", true);
            travelInsuranceList.Add(ti);
            insurancePoliciesList.Add(ti);
            MedicalInsurance mi = new MedicalInsurance("Only for 1",0002, 50.00, 5000.00, new DateTime(2000,12,5), new DateTime(2060,6,6), "yearly", "lasped", "May", false);
            medicalInsuranceList.Add(mi);
            insurancePoliciesList.Add(mi);
            CarInsurance ci = new CarInsurance("terminate soon", 0003, 50.00, 5000.00, new DateTime(1998, 3, 7), new DateTime(2020, 3, 11), "one time", "Terminated", "Keith", false);
            carInsuranceList.Add(ci);
            insurancePoliciesList.Add(mi);
            Customer c = new Customer("5001", "May", "Yishun Ave 4");
            customerList.Add(c);
            Customer ca = new Customer("5002", "Keith", "Ang Mo Kio stree 11");
            customerList.Add(ca);


        }

        static void CreatePolicy()
        {
            Console.WriteLine("Enter terms and condition: ");
            string terms = Console.ReadLine();
            Console.WriteLine("Enter cost: ");
            double cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter payout: ");
            double payout = Convert.ToDouble(Console.ReadLine());
            DateTime startdate = DateTime.Today;
            Console.WriteLine("Enter End Date(yyyy-mm-dd): ");
            DateTime enddate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter payment type: ");
            string paymenttype = Console.ReadLine();
            Console.WriteLine("Enter Status: ");
            string status = Console.ReadLine();
            Console.WriteLine("Enter Policy owner's name:");
            string name = Console.ReadLine();

            // How to get the agent

            Console.WriteLine("Enter employee id: ");
            string id = Console.ReadLine();
            Employee agent = null;
            for (int i = 0; i < employeeList.Count; i++)
            {
                if (id == employeeList[i].Id)
                {
                    agent = employeeList[i];
                    break;
                }
            }

            // getting customer
            Console.WriteLine("Enter customer id: ");
            string usrID = Console.ReadLine();
            Customer cw = null;
            for (int i = 0; i < customerList.Count; i++)
            {
                if (usrID == customerList[i].Uid)
                {
                    cw = customerList[i];
                    break;
                }
            }

            InsurancePolicy policy = new CarInsurance(terms, 2, cost, payout, startdate, enddate, paymenttype, status, name, false);
            insurancePoliciesList.Add(policy);
            policy.Staff = agent;
            policy.Customers = cw;
            


        }
    }
     
}