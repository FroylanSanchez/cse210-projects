class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double GetTotalCost()
    {
        double subtotal = 0;

        foreach (Product p in _products)
        {
            subtotal += p.GetTotalPrice();
        }

        double shipping = _customer.LivesInUSA() ? 5 : 35;

        return subtotal + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product p in _products)
        {
            label += $"{p.GetName()} (ID: {p.GetID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}
