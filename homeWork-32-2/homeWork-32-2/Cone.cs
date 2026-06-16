namespace homeWork_32_2;

public struct Cone : ICalculatable
{
    public string Name { get; set; }
    public double? Radius { get; set; }
    public double? Height { get; set; }

    public Cone(string name, double? radius, double? height)
    {
        Name = name;
        Radius = radius;
        Height = height;
    }

    public double? CalculateVolume()
    {
        if (Radius == null || Height == null) return null;
        return (1.0 / 3.0) * Math.PI * Math.Pow(Radius.Value, 2) * Height.Value;
    }

    public double? CalculateSquare()
    {
        if (Radius == null || Height == null) return null;
        double slantHeight = Math.Sqrt(Radius.Value * Radius.Value + Height.Value * Height.Value);
        return Math.PI * Radius.Value * (Radius.Value + slantHeight);
    }
}