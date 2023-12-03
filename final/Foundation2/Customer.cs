class Customer
{
    private string _name;
    private Guid _id;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        _id = Guid.NewGuid();
    }

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public Guid Id
    {
        get => _id;
        set => _id = value;
    }

    public Address Address
    {
        get => _address;
        set => _address = value;
    }

    public bool IsInUSA()
    {
        return Address.Country.ToUpper() == "USA";
    }

    public override string ToString()
    {
        return $"({_id}): {_name} - {_address}";
    }


}