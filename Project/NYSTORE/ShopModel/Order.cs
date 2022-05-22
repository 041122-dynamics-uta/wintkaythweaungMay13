namespace ShopModel
{
    public class Order
    {
        
    public int OrderID { get; set; } = -1;
    
   
    public int? UnitPrice { get; set; }
    public int? Quantity { get; set; }
   
    public string? location{get;set;}
   
    public int CustomerID {get;set;}
    public int ProductID{get;set;}
    
    }
}