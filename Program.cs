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

        public static string Logon()
        {
            string option = Console.ReadLine();

            string userId;
            bool checkUser = false;
            string end = "";
            while ((option != "1" || option != "2") && checkUser == false)
            {
                Console.WriteLine("Welcome to Provident Insurance! \n" +
                                  "===================\n" +
                                  "1. Log In to Customer\n" +
                                  "2. Log In to Staff\n" +
                                  "==================\n" +
                                  "Please enter your option:");

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Please enter your ID:");
                        userId = Console.ReadLine();
                        foreach (Employee employee in employeeList)
                        {
                            if (employee.Id.ToUpper() == userId.ToUpper())
                            {
                                Console.Write("Welcome " + employee.Name);
                                checkUser = true;
                                end = "employee";
                                break;
                            }
                        }
                        if (checkUser == false)
                        {
                            Console.WriteLine("User does not exist, please try again.");
                            return "error";
                        }
                        break;
                    case "2":

                        Console.WriteLine("Please enter your ID:");
                        userId = Console.ReadLine();
                        foreach (Employee employee in employeeList)
                        {
                            if (employee.Id.ToUpper() == userId.ToUpper())
                            {
                                Console.Write("Welcome " + employee.Name);
                                checkUser = true;
                                end = "customer";
                                break;
                            }
                        }
                        if (checkUser == false)
                        {
                            Console.WriteLine("User does not exist, please try again.");
                            return "error";
                        }
                        break;
                    default:
                        break;
                }
            }
            return end;
        }

        static void Main(string[] args)
        {
            Initialisation();
            string logonUser = Logon();
            int option;
            if (logonUser == "Employee")
            {

                switch(option)
            }
            
            /*Console.WriteLine("Welcome to Provident Insurance! \n" +
                              "===================\n" +
                              "1. Log In to Customer\n" +
                              "2. Log In to Staff\n" +
                              "==================\n" +
                              "Please enter your option");
            string option = Console.ReadLine();

            string userId;
            bool checkUser = false;

            switch (option)
            {
                case "1":
                    Console.WriteLine("Please enter your ID:");
                    userId = Console.ReadLine();
                    foreach (Employee employee in employeeList)
                    {
                        if (employee.Id.ToUpper() == userId.ToUpper())
                        {
                            Console.Write("Welcome " + employee.Name);
                            checkUser = true;
                            break;
                        }
                    }
                    if (checkUser == false)
                    {
                        Console.WriteLine("User does not exist, please try again.");
                    }
                    break;
                case "2":

                    Console.WriteLine("Please enter your ID:");
                    userId = Console.ReadLine();
                    foreach (Employee employee in employeeList)
                    {
                        if (employee.Id.ToUpper() == userId.ToUpper())
                        {
                            Console.Write("Welcome " + employee.Name);
                            checkUser = true;
                            break;
                        }
                    }
                    if (checkUser == false)
                    {
                        Console.WriteLine("User does not exist, please try again.");
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

        }

    }
}