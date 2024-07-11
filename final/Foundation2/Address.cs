using System.Data;

class Address 
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string street
    {
        get {return _street;}
        set {_street = value;}
    }
    public string city
    {
        get {return _city;}
        set {_city = value;}
    }
    
    public string state
    {
        get {return _state;}
        set {_state = value;}
    }
    public string country
    {
        get {return _country;}
        set {_country = value;}
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}\n{_state}\n{_country}";
    }
}