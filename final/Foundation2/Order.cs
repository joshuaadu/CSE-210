using System.Text;
class Order
{
    private Guid _id;
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
        _id = Guid.NewGuid();
    }

    public string Id
    {
        get => _id.ToString();
        // set => _id = value;
    }

    public Customer Customer
    {
        get => _customer;
        set => _customer = value;
    }

    public List<Product> Products
    {
        get => _products;
        set => _products = value;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public double GetTotalPrice()
    {
        var totalPrice = 0.0;
        foreach (var product in Products)
        {
            totalPrice += product.Price;
        }

        if (Customer.IsInUSA())
        {
            return totalPrice += 5.0;
        }
        else
        {
            return totalPrice += 35.0;
        }
    }

    public string GetShippingLabel()
    {
        return $"{Customer.Name}\n{Customer.Address}";
    }
    public string GetPackingLabel()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Products:");
        foreach (var product in Products)
        {
            sb.AppendLine($"\t{product.Name} - {product.Id}");
        }

        return sb.ToString();
    }

    public override string ToString()
    {
        return $"Order ID: {Id}\nCustomer: {Customer}\n{Products.Count} products";
    }



}