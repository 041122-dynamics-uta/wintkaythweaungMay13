using System;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace DataAccess
{
    public interface IRepository
    {
     Add Memeber(Cusomer p_Member);
        Custmer UpdateMemeber(Customer p_member);
        List<Member>GetAllCustomer();
        List<Order>GetOrderByMemberID (int p_memberID);
        List<StoreFront>GetAllStoreFront();
        List<Order>GetOrderByStoreID(int p_storeID);
        List<Product>GetProductByID(int p_storeID);
        List<Manager>GetManager(int p_managerID,string p_password);
        Inventory ReplenishInventory (inventory p_inventory);
        Order PlaceNewOrder (Order p_order);
        List<OrderHistory>AddOrderHistory(Order p_order);
        List <OrderHistory>GetOrderHistoryByOrderID(Guid p_orderID);
        }   
}