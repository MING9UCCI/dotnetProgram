class Battery(int initialLevel = 100)
{
    public int Level { get; private set; } = Math.Clamp(initialLevel, 0, 100);

    public void Charge(int amount) => Level = Math.Clamp(Level + amount, 0, 100);
    public void Drain(int amount) => Level = Math.Clamp(Level - amount, 0, 100);

    public bool IsEmpty => Level == 0;
    public bool IsFull => Level == 100;

    public override string ToString() => $"Battery: {Level}%";
}

class Program
{
    static void Main()
    {
        var battery = new Battery(50);
        Console.WriteLine(battery);     // Battery: 50%

        battery.Charge(60);
        Console.WriteLine(battery);     // Battery: 100% (상한 초과 방지)

        battery.Drain(110);
        Console.WriteLine(battery);     // Battery: 0% (하한 초과 방지)

        Console.WriteLine(battery.IsEmpty); // True
    }
}
