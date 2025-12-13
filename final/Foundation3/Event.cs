abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    protected string _type;

    protected Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public string GetStandardDetails()
    {
        return $"{_title}\n{_description}\n{_date}\n{_time}\n{_address.GetFullAddress()}";
    }

    public string GetShortDetails()
    {
        return $"{_type}\n{_title}\n{_date}";
    }

    public abstract string GetFullDetails();
}
