using System.Reflection.Metadata;

public class Product
{
    private string _name;

    private int _productId;

    private decimal _price;

    private decimal _quantity;

    public Product(string name, int ID, decimal price, decimal quantity)
    {
        _name = name;
        _productId = ID;
        _price = price;
        _quantity= quantity;
    }
    public decimal OrderCost()
    {
        decimal orderPrice = _price * _quantity;
        return orderPrice; 
    }

    public string DisplayProductInfo()
    {
        string productInfo = ($"Item: {_name}, Product ID: {_productId}, Quantity: {_quantity} ");
        return productInfo;

    }
}