class Address
{
    private string _street;
    private string _city;
    private string _stateProv;
    private string _country;

    public Address(string street, string city, string stateProv, string country)
    {
        _street = street;
        _city = city;
        _stateProv = stateProv;
        _country = country;
    }

    public bool IsUSA()
    {
        return _country.Trim().ToUpper() == "USA" || _country.Trim().ToUpper() == "UNITED STATES";
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_stateProv}\n{_country}";
    }
}
