public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> products)
    {
        _products.AddRange(products);
        _customer = customer;
    }

    public double TotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.ProductCost();
        }
        return total;
    }

    public void GetPackingLabel()
    {
        Console.WriteLine("Packing Label");
        Console.WriteLine(_customer.GetCustomerName());
        Console.WriteLine();
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product: {product.GetProductName()}");
            Console.WriteLine($"ID: {product.GetProductId()}");
            Console.WriteLine($"Quantity: {product.GetQuantity()}");
            Console.WriteLine();

        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine(_customer.GetCustomerName());
        _customer.GetAddress().DisplayAddress();
        if (_customer.Domestic())
        {
            Console.WriteLine("Domestic Shipping");
        }
        else
        {
            Console.WriteLine("International Shipping");
        }
    }

    public double GetShippingCost()
    {
        if (_customer.Domestic())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
}