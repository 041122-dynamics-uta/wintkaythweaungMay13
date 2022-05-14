namespace Models;
using System.Configuration;
using System.Data.SqlTypes;
public class Models
{

 public class ProductDataController
 {

    // SqlCommand command;
    // SqlConnection connection;
     public ProductDataController()
     {
       //  connection= new SqlConnection(ConfigurationManager.connectionString["ElectronicStore"].connectionString);

     }
     public void Insert(int productID,string productname,string productBrand,string version,int unitprice,int quantity)
     {
      // command =new SqlCommand("SPProductInsert",connection);
       


     }

 }
}
