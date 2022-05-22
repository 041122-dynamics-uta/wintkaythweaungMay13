using ShopModel;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
namespace ShopDL
{
    public class OrderRepo
    {
     public OrderMapper _mapper { get; set; }

    string connectionString=$"Server=tcp:electronicstoreserver.database.windows.net,1433;Initial Catalog=electronicstoreDb;Persist Security Info=False;User ID=electronicstoreDb;Password=100%Wintisperfect;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    // public List<Product> NewProduct()
    // {
    //     throw new NotImplementedException();
    // }

    public OrderRepo()
    {
        // this._repo = r;
        this._mapper = new OrderMapper();
    }
    public List<Order> OrderList()
    {
        string myQuery1 = "SELECT * FROM Orders;";
        //this using block creates teh SqlConnection.
        // the SqlConnection is the object that communicates with the Db.
        using (SqlConnection query1 = new SqlConnection(connectionString))
        {
            //The SqlCommand object uses the query text along with the SqlConnection object to open a connection and send the query.
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Connection.Open();//open the connection to the Db
            SqlDataReader results = command.ExecuteReader();//actually conduct the query.

            //query the FamilyRepository Db for the list of members
            //USE ADO.NET .........
            //use the mapper to transfer the falues in to Member objects in a List<Member>.
            List<Order> ml = new List<Order>();
            while (results.Read())
            {
                //mapp the current table row to a Member class objects
                Order order= this._mapper.DboToOrder(results);
                ml.Add(order);//send in the row of the reader to be mapped.
            }

            query1.Close();
            return ml;
        }
    }
   
    
      public Order NewOrder(string ProudctID,string CustomerID,string UnitPrice,string Quanity,string Location)
    {   string query= $" ";
        string myQuery1 = $"INSERT INTO Customer (FirstName, LastName, UserName, Password,Email) VALUES (@f, @l, @u, @p,@e);";
  
        using (SqlConnection query1 = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(myQuery1, query1);
            command.Parameters.AddWithValue("@f", ProudctID);
            command.Parameters.AddWithValue("@l", CustomerID);
            command.Parameters.AddWithValue("@u", UnitPrice);
            command.Parameters.AddWithValue("@p", Quanity);
            command.Parameters.AddWithValue("@e", Location);

            query1.Open();
            int results = command.ExecuteNonQuery();
            query1.Close();

            if (results == 1)
            {
                Order m = new Order
                {
                    OrderID = 100,
                    ProductID = Int32.Parse(ProudctID),
                    CustomerID =Int32.Parse(CustomerID),
                    UnitPrice = Int32.Parse(UnitPrice),
                    Quantity = Int32.Parse(Quanity),
                    location = Location
                    
                    
                };
                return m;
            }
            return null;

        };
    }
   


    }
}