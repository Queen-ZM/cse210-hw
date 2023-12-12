// Derived OutdoorGathering class
class OutdoorGathering : Event
{
    private string weather;

    public OutdoorGathering(string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address)
    {
        // For simplicity, assuming good weather
        weather = "Good Weather";
    }

    public override string GetFullDetails()
    {
        return $"{base.GetFullDetails()}\nWeather Forecast: {weather}";
    }

    public override string ToString()
    {
        return GetFullDetails();
    }
}