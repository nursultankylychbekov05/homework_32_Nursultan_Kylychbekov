namespace homeWork_32_1;

public struct Pyramid : ICalculatable
{
    public string Name { get; set; }
    public double BaseLength { get; set; }
    public double BaseWidth { get; set; }
    public double Height { get; set; }

    public Pyramid(string name, double baseLength, double baseWidth, double height)
    {
        Name = name;
        BaseLength = baseLength;
        BaseWidth = baseWidth;
        Height = height;
    }

    public double CalculateVolume()
    {
        return (BaseLength * BaseWidth * Height) / 3.0;
    }

    public double CalculateSquare()
    {
        double baseArea = BaseLength * BaseWidth;
        double slantLength = Math.Sqrt(Height * Height + (BaseWidth / 2.0) * (BaseWidth / 2.0));
        double slantWidth = Math.Sqrt(Height * Height + (BaseLength / 2.0) * (BaseLength / 2.0));
        double lateralArea = (BaseLength * slantLength) + (BaseWidth * slantWidth);
        
        return baseArea + lateralArea;
    }
}