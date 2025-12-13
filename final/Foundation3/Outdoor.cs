class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather)
        : base(title, description, date, time, address, "Outdoor Gathering")
    {
        _weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{_title}\n{_description}\n{_date}\n{_time}\n{_address.GetFullAddress()}\nWeather: {_weather}";
    }
}
