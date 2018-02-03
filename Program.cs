using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOADproject
{
    class Program
    {
        public static List<Employee> employeeList = new List<Employee>();
        public static List<JuniorAgent> juniorAgentList = new List<JuniorAgent>();
        public static List<Agent> agentList = new List<Agent>();
        public static List<SeniorAgent> SeniorAgentList = new List<SeniorAgent>();
        public static List<Administrator> administratorList = new List<Administrator>();
        public static List<TravelInsurance> travelInsuranceList = new List<TravelInsurance>();
        public static List<MedicalInsurance> medicalInsuranceList = new List<MedicalInsurance>();
        public static List<CarInsurance> carInsuranceList = new List<CarInsurance>();
        //public static List<Customer> customerList = new List<Customer>();

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

                        foreach (Employee employee in employeeList) //change to customer
                        {
                            if (employee.Id.ToUpper() == userId.ToUpper() )
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



        static void Main(string[] args)
        {
            Initialisation();

            Console.WriteLine("Welcome to Provident Insurance! \n" +
                              "===================\n" +
                              "1. Log In to Customer\n" +
                              "2. Log In to Staff\n" +
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
                    string mainselection;

                    user = LogonEmployee(userId);
                    if (user == "valid")
                    {
                        Console.WriteLine("Main Menu" +
                                          "1. Create new insurance policy\n" +
                                          "2. Edit policy\n" +
                                          "3. Send alerts for policies with premium due\n" +
                                          "--------------------------------------------\n" +
                                          "please enter your option:");
                        mainselection = Console.ReadLine();

                        switch(option)
                        {
                            case "1":
                                createPolicy();
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
            }*/
        }

        public static void CustomerViewInsurance (string userId)
        {
            foreach (Employee employee in employeeList) //change to customer
            {
                if (employee.Id == userId)
                {

                }
            }
        }







        public static void Initialisation()
        {

            JuniorAgent ja = new JuniorAgent("Marcus", "1001", "JuniorAgent");
            juniorAgentList.Add(ja);
            
            Agent ag = new Agent("Derrick", "2001", "Agent");
            agentList.Add(ag);
            employeeList.Add(ag);
            SeniorAgent sa = new SeniorAgent("jennifer", "3001", "SeniorAgent");
            SeniorAgentList.Add(sa);
            employeeList.Add(sa);
            Administrator ad = new Administrator("Joshua", "4001", "Adminsitrator");
            administratorList.Add(ad);
            employeeList.Add(ad);
            TravelInsurance ti = new TravelInsurance(0001, 50.00, 1000.00, Convert.ToDateTime(01/08/1997), Convert.ToDateTime(01/08/2027), "monthly", "active");
            travelInsuranceList.Add(ti);
            MedicalInsurance mi = new MedicalInsurance(0002, 50.00, 5000.00, Convert.ToDateTime(05/12/2000), Convert.ToDateTime(06/06/2060), "yearly", "lasped");
            medicalInsuranceList.Add(mi);
            CarInsurance ci = new CarInsurance(0002, 50.00, 5000.00, Convert.ToDateTime(07 / 03 / 1998), Convert.ToDateTime(03 / 11 / 2020), "one time", "Terminated");


        }

        static void createPolicy()
         {
             Console.WriteLine("Enter terms and condition: ");
             string terms = Console.ReadLine();
             Console.WriteLine("Enter cost: ");
             double cost = Console.ReadLine();
             Console.WriteLine("Enter payout: ");
             double payout = Console.ReadLine();
             DateTime startdate = DateTime.Today;
             Console.WriteLine("Enter End Date: ");
             DateTime enddate = Console.ReadLine();
             Console.WriteLine("Enter payment type: ");
             string paymenttype = Console.ReadLine();
             Console.WriteLine("Enter Status: ");
             string status = Console.ReadLine();
 
             // How to get the agent
             Console.WriteLine("Enter employee id: ");
             string id = Console.ReadLine();
             Employee agent;
             for (int i = 0; i < employeeList.Count; i++)
             {
                 if (id == employeeList[i].Id)
                 {
                     agent = employeeList[i];
                     break;
                 }
             }
 
 
         }
    }
     
}