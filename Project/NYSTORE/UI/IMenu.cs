using System;
using System.Data;
using System.Collections.Generic;

using System.Data.SqlClient;
using ShopDL;
using ShopBL;
using ShopModel;
namespace UI
{
    public class IMenu
    {      
        public void Display()

        {   Customer customer=new Customer();
            CustomerRepo CRP= new CustomerRepo();
            CustomerBL customerBL=new CustomerBL(CRP);
            Console.WriteLine("Please enter your first name");
            string fname = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            String lname = Console.ReadLine();
            Console.WriteLine("Please enter your username");
            string username = Console.ReadLine();
            Console.WriteLine("Please enter your password");
            string password = Console.ReadLine();
            Console.WriteLine("Please enter your email name");
            string email = Console.ReadLine();
            customer = customerBL.UpdateCustomerByID(fname, lname, username,password, email);
            Console.WriteLine ("Successfull Saved!!!!");
            Console.WriteLine($" {customer.fname} {customer.lname} Successfully saved for your new update!!! .");
        } 
        public  void Placeorder()
        {
            
             ProductRepo productRepo=new ProductRepo();
            ProductBL productBL=new ProductBL(productRepo);           
            Product newProduct=new Product();
            OrderRepo orderRepo=new OrderRepo();
            OrderBL orderBL=new OrderBL(orderRepo);
            Order order=new Order();
            List <Product> product = productBL.ProductList();
            foreach (Product m in product )
            {
                  //Console.WriteLine($"BrandName: ||   Category :  {m.Catgory}    ||    UnitPrice :  {m.UnitPrice}   || Quantity : {m.Quantity}");
                Console.WriteLine ("Do you want to buy this prorduct/n");
                Console.WriteLine ("Please press yes or no");
             Console.WriteLine("================================================\n");
                Console.WriteLine($"Product ID  - [{m.ProductID}] ");
                 Console.WriteLine($"Brand Name - [{m.ProductBrand}] ");
                Console.WriteLine($"Category   - [{m.Catgory}] ");
                Console.WriteLine($"Unit Price - [{m.UnitPrice}] ");
                Console.WriteLine($"Quanity    - [{m.Quantity}] ");
                Console.WriteLine($"Location   - [{m.location}]");
                 Console.WriteLine("================================================/n");
                  Console.WriteLine ("Please press yes or no");

                string answer= Console.ReadLine();
                while (true)
                if ( answer == "yes" || answer == "Yes" || answer == "YES")
                {  string productID= "1";

                  Console.WriteLine("Plese enter CustomerID");
                  string orderCusomerID=Console.ReadLine();
                  Console.WriteLine("Plese enter username");
                  string uname=Console.ReadLine();
                  string name=m.ProductBrand;
                  string cat=m.Catgory;;
                  string Price=Convert.ToString(m.UnitPrice);
                  int price= Int32.Parse(Price);
                  Console.WriteLine("Please type your Quantity");
                  string qtystring=Console.ReadLine();
                  int qty =Int32.Parse(qtystring);
                  if (qty> m.Quantity)
                  {
                    Console .WriteLine("plase enter the only availbe qty");
                    
                  }
                  else if (price>500)
                  {
                      Console .WriteLine("Please choose the the unitprice which is under 500");
                  }
                   string locate=m.location;
                order=orderBL.NewOrder(productID,orderCusomerID,Price,qtystring,locate);
                 Console.WriteLine ("Successfull Saved!!!!");
                Console.WriteLine($" You bought  {productID} : {name}  with {Price} from {locate}store! .");
      

                  
               


                }
                else  {
                    Console.WriteLine("you didcedie not to shop");}
                 
                    Console.WriteLine($" {newProduct.CustomerID} {newProduct.ProductID} {newProduct.ProductBrand} {newProduct.UnitPrice} {newProduct.Quantity}  {newProduct.location}.From now!  You are one of our regular customer list .");
              
            } return false;
 
            }
           

              
           




            
            }
      


        }
    }
