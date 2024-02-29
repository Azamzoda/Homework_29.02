public class   Transport
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public int MaxSpeed { get; set; }
    public string  Model { get; set; }
    public int price { get; set; }
    public  string color { get; set; }

    public Transport(string name, int capacity, int maxSpeed)
    {
        Name = name;
        Capacity = capacity;
        MaxSpeed = maxSpeed;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Transport Type: {Name}");
        Console.WriteLine($"Capacity: {Capacity}");
        Console.WriteLine($"Max Speed: {MaxSpeed}");
    }
}
