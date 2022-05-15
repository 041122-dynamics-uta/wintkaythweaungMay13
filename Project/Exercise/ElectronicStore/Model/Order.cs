using System.Data.SqlClient;
using System;

namespace Model
{
    public class Order
    {
        public Guid orderID {get;set;}
        public int customerID {get;set;}
        public int storeID {get;set;}
        public DateTime DateofOrder{get;set;}
        private List <orderHistory> _orderHistory;
        public List<OrderHistory> orderHistory
        {
            get{return _orderHistory;}
            set{ _orderHistory= value;}
        }
        public double TotalPrice {get;set;}

        public Order()
        {
                orderID=Guid.NewGuid();
                customerID=0;
                storeID=0;
                DateofOrder=DateTime.UtcNow;
                _orderHistory=new List<OrderHistory>()
                {
                    new OrderHistory()

                };
                TotalPrice =0.00;
                
        }
        public override string ToString()
        {
            return $"OrderID: {orderID}\nCustomerID: {customerID}\nStoreID: {storeID}\nDate of Order: {DateofOrder}\nTotal Price: {TotalPrice}";
        }
        
    }
}