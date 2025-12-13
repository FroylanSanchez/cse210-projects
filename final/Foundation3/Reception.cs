class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email)
        : base(title, description, date, time, address, "Reception")
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
        return $"{_title}\n{_description}\n{_date}\n{_time}\n{_address.GetFullAddress()}\nRSVP Email: {_email}";
    }
}
