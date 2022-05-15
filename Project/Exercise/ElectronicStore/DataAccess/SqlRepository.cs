using System.Data.SqlClient;

using DataAccess;



namespace DataAccess
{
    public class SqlRepository : IRepository;
    {
        private readonly string  _connectionStrings;
        public SqlRepository (string p_connectionStrings)
        {
            _connectionStrings= p_connectionStrings;
        }
        
        
        public Customer AddMember(Member p_member)
        {
            string sqlQuery = @"Insert into Member values (@Name,@Address,@Email,@Phone)";

            using(SqlConnection con=new SqlConnection(_connectionStrings))

            {
                con.Open();
                SqlCommand command= new SqlCommand(sqlQuery,con);
                command.Parameters.AddWithValue("@Name",p_customer.Name);
                command.Parameters.AddWithValue("@Address",p_customer.Name);
                command.Parameters.AddWithValue("@Email",p_customer.Name);
                command.Parameters.AddWithValue("@Phone",p_customer.Name);
                command.ExecuteNonQuery();


            }
            return p_member;
        }
        public Customer UpDateMember(Member p_member)
        {
            string sqlQuery = @"Update Member set  Name=@Name,Address=@Address,Email=@Email,Phone=@Phone where customerID=@customerID;";

            using(SqlConnection con=new SqlConnection(_connectionStrings))

            {
                con.Open();
                SqlCommand command= new SqlCommand(sqlQuery,con);
                command.Parameters.AddWithValue("@memberID",p_member.memberID);
                command.Parameters.AddWithValue("@Name",p_customer.Name);
                command.Parameters.AddWithValue("@Address",p_customer.Name);
                command.Parameters.AddWithValue("@Email",p_customer.Name);
                command.Parameters.AddWithValue("@Phone",p_customer.Name);
                command.ExecuteNonQuery();


            }
            return p_member;
        }
        public list <Order>GetOrderByMemberID(int p_memberID)
        {
            List<Order> ListOfOrders=new List<Order>();
            string sqlQuery=@"Select o.orderID,o.customerID,o.storeID.o.DateofOrder,o.TotalPrice from Order o where o.memberID=1 order by DateofOrder,TotalPrice;";
            using (SqlConnection con= new SqlConnection(_connectionStrings))
            {   con.Open();
                    SqlCOmmand command=new SqlCOmmand(sqlQuery,con);
                    command.Parameters..AddWithValue("@CustomerID",p_customerID);
                    SqlDataReader reader =command .ExecuteReader();
                    while(reader.Read())
                    {
                        ListOfOrders.Add(new Order()
                        {
                            orderID=reader.GetGuid(0),
                            p_memberID =reader.GetInt32(1),
                            storeID=reader.GetInt32(2),
                            DateofOrder=reader.GetDateTime(3),
                            TotalPrice-=reader.GetDouble(4),
                            orderHistory=GetOrderByMemberID(reader.GetGuid(0))

                        });


                    }
                        return ListOfOrders;


            }        
        }
        
        public list <Manager>GetManager(int p_managerID,string p_password)
        {
            List<Manager> ListofManager=new List<Manager>();
            string sqlQuery=@"Select * From Manager";
            using (SqlConnection con= new SqlConnection(_connectionStrings))
            {   con.Open();
                    SqlCOmmand command=new SqlCOmmand(sqlQuery,con);
                    SqlDataReader reader =command .ExecuteReader();
                    while(reader.Read())
                    {
                        ListofManager.Add(new Manager()
                        {
                            managerID=reader.GetInt32(0),
                            username =reader.GetString(1),
                            password=reader.GetString(2),
                            isAdmin=reader.GetBoolean(3),
                           
                        });


                    }
                        return ListofManager;


            }        
        }
         public List<Order> GetOrderbyStoreID(int p_storeID)
        {
            List<Order> listofOrders = new List<Order>();

            string sqlQuery = @"select o.orderID, o.storeID, o.customerID, o.DateofOrder, o.TotalPrice from Orders o  
                            where o.storeID = 1
                            order by DateofOrder, TotalPrice;";
            
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@storeID", p_storeID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listofOrders.Add(new Orders()
                    {
                        orderID = reader.GetGuid(0),
                        storeID = reader.GetInt32(1),
                        customerID = reader.GetInt32(2),
                        DateofOrder = reader.GetDateTime(3),
                        TotalPrice = reader.GetDouble(4),
                        LineItem = GetLineItemsbyOrderID(reader.GetGuid(0))
                    });
                }
            }
            return listofOrders;
        }


        public List<Product> GetProductbyStoreID(int p_storeID)
        {
            List<Product> listofProducts = new List<Product>();

            string sqlQuery = @"select p.productID, p.Name, p.Price, p.Category, i.Quantity from Product p
                            inner join Inventory i on i.productID = p.productID
                            inner join StoreFront sf on sf.storeID = i.storeID
                            where sf.storeID = @storeID";
            
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@storeID", p_storeID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listofProducts.Add(new Product()
                    {
                        productID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Price = reader.GetDouble(2),
                        Category = reader.GetString(3),
                        Quantity = reader.GetInt32(4)
                    });
                }
            }
            return listofProducts;
        }
        

        public List<StoreFront> GetAllStoreFront()
        {
            List<StoreFront> listofStoreFront = new List<StoreFront>();

            string sqlQuery = @"select * from StoreFront";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listofStoreFront.Add(new StoreFront()
                    {
                        storeID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        Phone = reader.GetString(3),
                        //Product = GetProductbyStoreID(reader.GetInt32(0)),
                        //Orders = GetOrderbyCustomerID(reader.GetInt32(0))
                    });
                }
            }
            return listofStoreFront;
        }


       

        public Inventory ReplenishInventory(Inventory p_inventory)
        {
            string sqlQuery = @"update Inventory
                            set Quantity = Quantity + @Quantity
                            where productID = @productID
                            and storeID = @storeID";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@Quantity", p_inventory.Quantity);
                command.Parameters.AddWithValue("@productID", p_inventory.productID);
                command.Parameters.AddWithValue("@storeID", p_inventory.storeID);

                command.ExecuteNonQuery();
            }
            return p_inventory;
        }


        public Order PlaceNewOrder(Order p_order)
        {
            //Creates an order, prepares lineitems, and updates the inventory.
            string sqlQuery = @"insert into Orders
                            (orderID, customerID, storeID, DateofOrder, TotalPrice)
                            values(@orderID, @customerID, @storeID, @DateofOrder, @TotalPrice);";
            
            string sqlQuery3 = @"update Inventory
                            set Quantity = Quantity - @Quantity
                            where storeID = @storeID 
                            AND productID = @productID;";
            
            p_order.orderID = Guid.NewGuid();
            
            foreach (var item in p_order.LineItem)
            {
                p_order.TotalPrice += item.ProductPrice * item.Quantity;
            }
            
            p_order.DateofOrder = DateTime.Now;
            
            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@orderID", p_order.orderID);
                command.Parameters.AddWithValue("@TotalPrice", p_order.TotalPrice);
                command.Parameters.AddWithValue("@DateofOrder", p_order.DateofOrder);
                command.Parameters.AddWithValue("@customerID", p_order.customerID);
                command.Parameters.AddWithValue("@storeID", p_order.storeID);
                
                command.ExecuteNonQuery();

                AddLineItem(p_order);

                foreach (var item in p_order.LineItem)
                {

                    SqlCommand command3 = new SqlCommand(sqlQuery3, con);
                    command3.Parameters.AddWithValue("@storeID", p_order.storeID);
                    command3.Parameters.AddWithValue("@productID", item.productID);
                    command3.Parameters.AddWithValue("@Quantity", item.Quantity);

                    command3.ExecuteNonQuery();
                }    
            }
            return p_order;
        }

        public List<LineItem> AddLineItem(Orders p_order)
        {
            string sqlQuery = @"insert into LineItem
                            (orderID, productID, ProductName, ProductPrice, Quantity)
                            values(@orderID, @productID, @ProductName, @ProductPrice, @Quantity);";

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                foreach (var item in p_order.LineItem)
                {
                    SqlCommand command = new SqlCommand(sqlQuery, con);
                    command.Parameters.AddWithValue("@orderID", p_order.orderID);
                    command.Parameters.AddWithValue("@productID", item.productID);
                    command.Parameters.AddWithValue("@ProductName", item.ProductName);
                    command.Parameters.AddWithValue("@ProductPrice", item.ProductPrice);
                    command.Parameters.AddWithValue("@Quantity", item.Quantity);

                    command.ExecuteNonQuery();
                }
            }
            return p_order.LineItem;
        }

        public List<LineItem> GetLineItemsbyOrderID(Guid p_orderID)
        {
            string sqlQuery = @"select productID, ProductName, ProductPrice, Quantity from LineItem
                            where orderID = @orderID;";

            List<LineItem> lineitem = new List<LineItem>();

            using (SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@orderID", p_orderID);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    lineitem.Add(new LineItem()
                    {
                        orderID = p_orderID,
                        productID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        ProductPrice = reader.GetDouble(2),
                        Quantity = reader.GetInt32(3)
                    });
                }
            }
            return lineitem;
        }
    }
       
        
        

    }
