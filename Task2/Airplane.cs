public class Airplane : Transport
{
      public double Wingspan { get; set; }

    public Airplane(string name, int capacity, int maxSpeed, double wingspan):base(name, capacity, maxSpeed)
    {
        Wingspan = wingspan;
    }
}