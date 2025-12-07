class Product
{
    private string _name;
    private int _id;
    private double _price;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetID()
    {
        return _id;
    }

    public double GetTotalPrice()
    {
        return _price * _quantity;
    }
}
