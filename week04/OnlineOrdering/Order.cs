public class Order
{
    private List<Product> _productList = new List<Product>();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
        
    }

    public decimal GetTotalCost()
    {
        decimal runningTotal = 0;
        foreach (Product product in _productList)
        {
         runningTotal += product.OrderCost();
        }

        if (_customer.LivesInUSA())
        {
            runningTotal += 5;
        }
        else
        {
            runningTotal += 35;
        }
        return runningTotal;
    }

    public string DisplayShippingLabel()
    {
        string shippingLabel = ($"{_customer.DisplayCustInfo()}");
        return shippingLabel;
    }

    public string DisplayPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _productList)
        {
            packingLabel += ($"{product.DisplayProductInfo()}");
        }
            return packingLabel;
    }
}