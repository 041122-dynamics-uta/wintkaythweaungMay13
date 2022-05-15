using BusinessLogic;
using DataAccess;
using System;
namespace FrontEnd
{
    public class AddCustomerMenu:IMenu

    {
         private static Customer _newCustomer = new Customer();

        //Dependency Injection =======
        private ICustomerBL _customerBL;
        public AddCustomerMenu(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
        }
        // ===========================
        
        public void Display() 
        {
            Console.WriteLine("Please select the type of Customer information you would like to add:\n");
            Console.WriteLine("[1] - Name: " + _newCustomer.Name); 
            Console.WriteLine("[2] - Address: " + _newCustomer.Address); 
            Console.WriteLine("[3] - Email: " + _newCustomer.Email); 
            Console.WriteLine("[4] - Phone: " + _newCustomer.Phone);  
            Console.WriteLine("[5] - Save Information");
            Console.WriteLine("[6] - Return to Main Menu\n");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.WriteLine("User selected to add customer name.");
                    Console.WriteLine("Please enter a name:");
                    _newCustomer.Name = Console.ReadLine(); 
                    Console.WriteLine("User has entered in a name.");
                    return "AddCustomerMenu";
                case "2":
                    Console.WriteLine("User selected to add customer address.");
                    Console.WriteLine("Please enter an address:");
                    _newCustomer.Address = Console.ReadLine();
                    Console.WriteLine("User has entered in an address.");
                    return "AddCustomerMenu";
                case "3":
                    Console.WriteLine("User selected to add customer email.");
                    Console.WriteLine("Please enter an email:");
                    _newCustomer.Email = Console.ReadLine();
                    Console.WriteLine("User has entered in an email.");
                    return "AddCustomerMenu";
                case "4":
                    Console.WriteLine("User selected to add customer phone number.");
                    Console.WriteLine("Please enter a phone number (must be 10 digits with no dashes):");
                    _newCustomer.Phone = Console.ReadLine();
                    Console.WriteLine("User has entered in a phone number.");
                    return "AddCustomerMenu";
                case "5":
                    //Exception handling with logging to have better user experience.
                    try
                    {
                        Console.WriteLine("Adding customer information \n" + _newCustomer);
                        _customerBL.AddCustomer(_newCustomer);
                        Console.WriteLine("Customer information has been added. Welcome to Colorado's Market!");
                        Console.WriteLine("Press the Enter to return to the main menu:");
                        Console.ReadLine();
                        Console.WriteLine("Successfully added customer's information!");
                    }
                    catch (System.Exception exc)
                    {
                        Console.WriteLine("Failed to add customer information.");
                        Console.WriteLine(exc.Message);
                        Console.WriteLine("Please press Enter to continue:");
                        Console.ReadLine();
                        Console.WriteLine("User pressed the Enter key to continue.");
                    }
                    return "MainMenu";
                case "6":
                    Console.WriteLine("User has selected to return to the main menu.");
                    return "MainMenu";
                default:      
                    Console.WriteLine("User selected an invalid response.");            
                    Console.WriteLine("You've selected an invalid response.");
                    Console.WriteLine("Press the Enter key to try again:");
                    Console.ReadLine();
                    Console.WriteLine("User has pressed the Enter Key to try again.");
                    return "AddCustomerMenu";
            }
        }

        public void Display()
        {
            Console.WriteLine("Please Select the type of Cusomer information you would llike to add:\n");
           

        }

    }
}