class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "HollyWood", "CA", "USA");
        Address address2 = new Address("161 Umjelo Cresent", "Johannesburg", "Gauteng", "South Africa");

        Lecture lecture = new Lecture("Medical Lecture", "An informative session", "2023-01-15", "14:00", address2, "Dr Lonke", 50);
        Reception reception = new Reception("Networking Reception", "An opportunity to network", "2023-02-20", "18:00", address1, "reply@events.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Enjoy the outdoors", "2023-07-10", "12:00", address2);

        Event[] events = { lecture, reception, outdoorGathering };

        foreach (var ev in events)
        {
            Console.WriteLine(ev.ToString());
            Console.WriteLine();
        }
    }
}
