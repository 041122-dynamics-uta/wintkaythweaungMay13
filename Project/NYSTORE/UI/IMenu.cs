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
                Console.WriteLine ("Do you want to buy this prorduct?\n");
                
                 Console.WriteLine ("Please press yes or no\n");
             Console.WriteLine("================================================\n");
                Console.WriteLine($"Product ID  - [{m.ProductID}] ");
                 Console.WriteLine($"Brand Name - [{m.ProductBrand}] ");
                Console.WriteLine($"Category   - [{m.Catgory}] ");
                Console.WriteLine($"Unit Price - [{m.UnitPrice}] ");
                Console.WriteLine($"Quanity    - [{m.Quantity}] ");
                Console.WriteLine($"Location   - [{m.location}]\n");
                 Console.WriteLine("================================================\n");
            
                
               
                 string answer= Console.ReadLine();
            if ( answer == "yes" || answer == "Yes" || answer == "YES")
              {  
                List <Order> products = orderBL.OrderList();
                List<Product>pp=productBL.ProductList();
                          
                 Console.WriteLine("Plese enter ProductID");
                  string pid=Console.ReadLine();
                  Console.WriteLine("Plese enter CustomerID");
                 string orderCusomerID=Console.ReadLine();
                  Console.WriteLine("Please enter the quantity");
                 string qty =Console.ReadLine();
                 int qtychange=Int32.Parse(qty);
                  if (qtychange>m.Quantity)
                     {
                        Console.WriteLine("pelase enter the available amount");
                     }
                  Console.WriteLine("Please enter the price");
                  string ppp =Console.ReadLine();
                  Console.WriteLine("Please enter the location");
                  string ll =Console.ReadLine();
                  string quantity=Convert.ToString(qtychange);
                  string price=Convert.ToString(m.UnitPrice);
                  order =orderBL.NewOrder(pid,orderCusomerID,ppp,quantity,ll);
                  string diff= Convert.ToString(m.Quantity-qtychange);
                 // Console.WriteLine ($" different is {diff}");
                  Console.WriteLine("===================after Making order ===========================\n");
                  Console.WriteLine("=================   This is the list in you cart    ==========\n");
                 
                 newProduct = productBL.P_QuantityUpdate(diff,m.ProductBrand);
                 
                 Console.WriteLine($"ProductID - [{pid} ]");
                 Console.WriteLine($"CustomerID - [{orderCusomerID} ]");
                 Console.WriteLine($"UnitPrice - [{ppp} ]");
                 Console.WriteLine($"Quantity - [{quantity} ]");
                 Console.WriteLine($"Location - [{ll} ]");
                  Console.WriteLine("=================   This is the list in you cart    ==========\n");
                   Console.WriteLine("=================   This is the item left from inventory cart ==========\n");
               
                Console.WriteLine($" Product Brand    -[{(m.ProductBrand )}]");
                Console.WriteLine($" Categeory        -[{(m.Catgory )}]");
                Console.WriteLine($" Price            -[{(ppp )}]");
                Console.WriteLine($"Availble Quanity  -[{( diff)}]");
                Console.WriteLine($"Location          -[{( ll )}]");
                newProduct = productBL.ProductUpdate(m.ProductBrand,m.Catgory,ppp,diff,ll);
                newProduct = productBL.P_QuantityUpdate(diff,m.ProductBrand);
                 Console.WriteLine("=================   This is the item left from inventory cart    ==========\n");
                 
               // Console.WriteLine ($"Brand:{pid}ID:{orderCusomerID}Price:{ppp}Quantity:{quantity}Location{ll}");
                Console.WriteLine("=================You made an order ! ========================\n");
                //Console.WriteLine($"Quantity -[{(diff )}]");
               // Console.WriteLine($"[{(m.ProductBrand )}]");
                     


                 }
                
                 
                  
          }
            

                                
                          
            }
              
           
      } 
      

              
           

}

          

      

    
        

