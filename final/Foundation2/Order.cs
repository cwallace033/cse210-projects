using System.Diagnostics;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order (Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public Customer customer
    {
        get {return _customer;}
    }

    public List<Product> products
    {
        get {return _products;}
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotal();
        }
        if(_customer.LivesInUSA())
        {
            total += 5;
        }
        else{
            total += 35;
        }
        return total;
    }
    public string GetPackingLabel()
    {
        string label = "Items: \n";
        foreach (Product product in _products)
        {
            label += $"- {product.name} {product.productID} Amount: {product.amount} Unit Cost: {product.unitPrice}\n";
        }
        return label;
    }
    public string GetShippingLabel()
    {
        return $"Shipping Address: \n{_customer.customerName} \n{_customer.address.GetFullAddress()}";
    }



}