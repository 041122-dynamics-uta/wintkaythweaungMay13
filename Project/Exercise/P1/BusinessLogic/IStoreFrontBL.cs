namespace BusinessLogic
{
    public class IStoreFrontBL
    
    {
      
        List<StoreFront> GetAllStoreFront();
        
        List<Orders> GetOrderbyStoreID(int p_storeID);      
        
        List<Product> GetProductbyStoreID(int p_storeID);       
         Inventory ReplenishInventory(Inventory p_inventory);       
        List<Manager> GetManager(int p_managerID, string p_password);
   
        bool isAdmin(int p_managerID, string p_password);
         Orders PlaceNewOrder(Orders p_order);
    }
}