namespace ShopModel
{
    public class Product
    {
        
    public int ProductID { get; set; } = -1;
    public string? ProductBrand { get; set; }
    public string? Catgory { get; set; }
    public int? UnitPrice { get; set; }
    public int? Quantity { get; set; }
    public int? StoreID{get;set;}
    public string? location{get;set;}
    public int OrderID {get;set;}=-1;
    public int CustomerID {get;set;}
    
    }
}