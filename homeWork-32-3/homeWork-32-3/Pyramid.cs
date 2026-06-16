namespace homeWork_32_3;

public struct Pyramid : ICalculatable
{
    public string Name { get; set; }
    public double? BaseLength { get; set; }
    public double? BaseWidth { get; set; }
    public double? Height { get; set; }

    public Pyramid(string name, double? baseLength, double? baseWidth, double? height)
    {
        Name = name;
        BaseLength = baseLength;
        BaseWidth = baseWidth;
        Height = height;
    }

    public double? CalculateVolume()
    {
        if (BaseLength == null || BaseWidth == null || Height == null) return null;
        return (BaseLength.Value * BaseWidth.Value * Height.Value) / 3.0;
    }

    public double? CalculateSquare()
    {
        if (BaseLength == null || BaseWidth == null || Height == null) return null;
        
        double baseArea = BaseLength.Value * BaseWidth.Value;
        double slantLength = Math.Sqrt(Height.Value * Height.Value + (BaseWidth.Value / 2.0) * (BaseWidth.Value / 2.0));
        double slantWidth = Math.Sqrt(Height.Value * Height.Value + (BaseLength.Value / 2.0) * (BaseLength.Value / 2.0));
        double lateralArea = (BaseLength.Value * slantLength) + (BaseWidth.Value * slantWidth);
        
        return baseArea + lateralArea;
    }
}