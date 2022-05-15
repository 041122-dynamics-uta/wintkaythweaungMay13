using System;
using System.Data.SqlClient;
using BusinessLogic;
using DataAccess;
using FrontEnd;

namespace FrontEnd
{
    class Program 
    {
        static void Main(string[] args)
        {  bool repeat=true;
        
        string connectionString =$" Server=tcp:wintkaythweaungserver.database.windows.net,1433;Initial Catalog=wintkaythweaungDB;Persist Security Info=False;User ID=wintkaythweaungDB;Password=100%Wintisperfect;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                
            while (repeat)
            {
                
                Console.Clear();
                menu.Display();
                string ans=menu.UserChoice();
                Console.WriteLine("Welcome to my Store!");
                 Console.WriteLine("Press 1:Admin ||} Press 2 : Member ||| Presss 3: New User");
                string choice = Console.ReadLine();
                switch(ans)
                {
                    case "AddCustomerMenu":
                    Console.WriteLine("Loading for member register ");
                    menu=new AddCustomerMenu(new MemberBL (connectionString));
                    break;
                    case"SearchCustomerMenu":
                    Console.WriteLine("Loading Customer Search Menu ");
                    menu= new SearchCustomerMenu(new MemberBL(connectionString));
                    break;
                    case"PLaceOrder":
                    Console.WriteLine("Loading for Placeorder menu");
                    menu=new PlaceOrder(new CusomerBL(connectionString));
                    break;
                    case "ViewCustomerOrder":
                    Console.WriteLine("Loading for View the customer's Order");
                    menu=new ViewCustomerOrder(new CusomerBL(connectionString));
                    break;
                    case "ViewStoreOrder":
                    Console.WriteLine("Loading for View the store's Order");
                    menu=new ViewCustomerOrder(new CusomerBL(connectionString));
                    break;
                    case "ViewInventory":
                    Console.WriteLine("Loading for view store menu");
                    menu=new ViewCustomerOrder(new CusomerBL(connectionString));
                    break;
                    case "Replenish":
                    Console.WriteLine("Loading for View the customer's Order");
                    menu=new Replanish(new CusomerBL(connectionString));
                    break;
                    case "MainMenu":
                    Console.WriteLine("Loading for View the customer's Order");
                    menu=new MainMenu();
                    break;
                    case "Exit":
                    Console.WriteLine("Exiting application");
                    repeat=false;
                    break;
                    default:
                    Console.WriteLine("You select an invalid response");
                    Console.WriteLine("Page doesn't exit!");
                    Console.WriteLine("Pleaes press the enter button to continue");
                    Console.ReadLine();
                    Console.WriteLine("You select an invalid response");
                    break;         
            
                }
                

              
            }
        }
            
     }
}

            

    

