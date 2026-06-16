namespace homeWork_32_3;

public struct CalculationResult
{
    public string FigureName { get; set; }
    public double Volume { get; set; }
    public double Square { get; set; }

    public CalculationResult(string figureName, double volume, double square)
    {
        FigureName = figureName;
        Volume = volume;
        Square = square;
    }
}