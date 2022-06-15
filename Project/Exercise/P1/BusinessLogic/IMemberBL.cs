using Model;
using DataAccess;
namespace BusinessLogic
{
    public interface IMemberBL
    
    {
         
      
        /// add customer information to the database.
      
         ( Cu p_customer);

       
        /// Updates a customer to the database

        /// <returns> Returns customer that was updated. </returns>
        Customer UpdateCustomer(Customer p_customer);

      
        /// Will give back all customers in the database in the form of a list.
       /// Returns a list collection of all customers in database. 
        List<Customer> GetAllCustomer();

       
        
        List<Orders> GetOrderbyCustomerID(int p_customerID);

       
        List<Customer> GetCustomerbyName(string p_Name);

      
        List<Customer> GetCustomerbyEmail(string p_Email);

 
    }
}