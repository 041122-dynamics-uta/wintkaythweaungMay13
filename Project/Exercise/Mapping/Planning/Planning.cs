// See https://aka.ms/new-console-template for more information
using System;
namespace Mapping
{

    class Planning
    {


         public static void Main(string[] args)
        {
           
            Console.WriteLine("Please tell me your db psd");
            string pswd=Console.ReadLine();
            string connectionString = $"Server=tcp:electronicstoreserver.database.windows.net,1433;Initial Catalog=electronicstoreDb;Persist Security Info=False;User ID=electronicstoreDb;Password={pswd};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

    }
}






