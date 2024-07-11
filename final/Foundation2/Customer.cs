class Customer
{
    private string _customerName;
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string customerName
    {
        get {return _customerName;}
        set {_customerName = value;}
    }
    public Address address
    {
        get {return _address;}
        set {_address = value;}
    }
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
}