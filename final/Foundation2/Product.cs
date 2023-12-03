class Product
{
    private string _name;

    private Guid _id;
    private double _price;
    private int _quantity;

    public Product(string name, double price, int quantity)
    {
        _name = name;
        _price = price;
        _quantity = quantity;
        _id = Guid.NewGuid();
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public string Id
    {
        get => _id.ToString();
        // set => _id = value;
    }

    public double Price
    {
        get => _price * _quantity;
        set => _price = value;
    }

    public int Quantity
    {
        get => _quantity;
        set => _quantity = value;
    }

    public override string ToString()
    {
        return $"({Id}): {Name} - {Price} ({Quantity} in stock)";
    }

    public override bool Equals(object obj)
    {
        if (obj is Product)
        {
            var other = (Product)obj;
            return Id.Equals(other.Id);
        }

        return false;
    }


}