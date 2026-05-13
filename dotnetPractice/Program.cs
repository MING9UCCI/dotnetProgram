class FlightPerson
{
    public string Name { get; set; }
    public int ID { get; set; }

    public FlightPerson(string name, int id) {
        this.Name = name;
        this.ID = id;
    }
    public virtual void Introduce()
    {
        Console.WriteLine($"안녕하세요 저는 {Name}입니다.(ID : {ID})");
    }
}
class Pilot : FlightPerson
{
    public string License { get; set; }
    public int LicenseId { get; set; }
    public Pilot(string name, int id, string license, int licenseid)
        : base(name, id)
    {
        this.License = license;
        this.LicenseId = licenseid;
    }
    public override void Introduce()
    {
        Console.WriteLine($"안녕하세요 저는 {Name}이고, {License}를 가지고 있습니다. (ID : {ID}, LicenseID : {LicenseId})");
    }
}
class CrewMember : FlightPerson
{
    public int Year { get; set; }
    public double Height { get; set; }
    public CrewMember(string name, int id, int year, double height)
    : base(name, id)
    {
        this.Year = year;
        this.Height = height;
    }
    public override void Introduce()
    {
        Console.WriteLine($"어서오세요 저는 {Year}년차 승무원 {Name}입니다. (ID : {ID}, Height : {Height})");
    }
}
class Passenger : FlightPerson
{
    public string Seat { get; set; }
    public Passenger(string name, int id, string seat)
    : base(name, id)
    {
        this.Seat = seat;
    }
    public override void Introduce()
    {
        Console.WriteLine($"제 이름은 {Name}입니다. 제 자리는 {Seat}입니다. (ID : {ID})");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        List<FlightPerson> flightPeople = new List<FlightPerson>();
        flightPeople.Add(new Pilot("김철수", 001, "비행조종사 1급", 20260512));
        flightPeople.Add(new CrewMember("김유리", 002, 12, 170.3));
        flightPeople.Add(new Passenger("지민우", 003, "17B"));

        foreach(var person in flightPeople)
        {
            person is Pilot ? person.Introduce() : person is CrewMember ? person.Introduce() : person.Introduce();
        }
    }
}