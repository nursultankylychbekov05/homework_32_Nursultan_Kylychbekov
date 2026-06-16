namespace homeWork_32_2;

public struct Parallelepiped : ICalculatable
{
    public string Name { get; set; }
    public double? Length { get; set; }
    public double? Width { get; set; }
    public double? Height { get; set; }

    public Parallelepiped(string name, double? length, double? width, double? height)
    {
        Name = name;
        Length = length;
        Width = width;
        Height = height;
    }

    public double? CalculateVolume()
    {
        if (Length == null || Width == null || Height == null) return null;
        return Length.Value * Width.Value * Height.Value;
    }

    public double? CalculateSquare()
    {
        if (Length == null || Width == null || Height == null) return null;
        return 2.0 * (Length.Value * Width.Value + Length.Value * Height.Value + Width.Value * Height.Value);
    }
}