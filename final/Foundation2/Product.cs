class Product 
{
    private string _name;
    private string _productID;
    private double _unitPrice;
    private int _amount;

    public Product(string name, string productID, double unitPrice, int amount)
    {
        _name = name;
        _productID = productID;
        _unitPrice = unitPrice;
        _amount = amount;
    }

    public double GetTotal()
    {
        return _amount * _unitPrice;
    }

    public string name
    {
        get {return _name;}
        set {_name = value;}
    }
    public string productID
    {
        get {return _productID;}
        set {_productID = value;}
    }
    public double unitPrice
    {
        get {return _unitPrice;}
        set {_unitPrice = value;}
    }
    public int amount
    {
       get {return _amount;}
       set {_amount = value;}
    }
}

