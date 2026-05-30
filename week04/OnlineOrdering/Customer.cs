public class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
       return _address.InUSA();
    }

    public string DisplayCustInfo()
    {
        string custInfo = ($"{_name} {_address.CompleteAddress()}");
        return custInfo;
    }
}