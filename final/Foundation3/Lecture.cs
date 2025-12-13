class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    private int _attending;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity, int attending)
        : base(title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _capacity = capacity;
        _attending = attending;
    }

    public override string GetFullDetails()
    {
        return $"{_title}\n{_description}\n{_date}\n{_time}\n{_address.GetFullAddress()}\nSpeaker: {_speaker}\nAvailable Seats: {_capacity - _attending}";
    }
}
