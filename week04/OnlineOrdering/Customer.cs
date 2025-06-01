using System.Security.Cryptography;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public bool Domestic()
    {
        return _address.InUsa();
    }

    public string GetCustomerName()
    {
        return _customerName;
    }
    public Address GetAddress()
    {
        return _address;
    }
}