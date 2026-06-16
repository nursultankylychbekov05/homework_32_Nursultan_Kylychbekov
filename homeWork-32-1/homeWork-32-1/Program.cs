namespace homeWork_32_1;

class Program
{
    static void Main(string[] args)
    {
        ICalculatable[] figures = new ICalculatable[]
        {
            new Parallelepiped("Параллелепипед", 5.0, 4.0, 3.0),
            new Pyramid("Пирамида", 6.0, 6.0, 5.0),
            new Sphere("Сфера", 3.5),
            new Cylinder("Цилиндр", 2.0, 6.0),
            new Cone("Конус", 3.0, 7.0)
        };

        Console.WriteLine("======== Список геометрических фигур ========");
        for (int i = 0; i < figures.Length; i++)
        {
            Console.WriteLine("Название: " + figures[i].Name + " | Объем: " + figures[i].CalculateVolume().ToString("F2") + " | Площадь поверхности: " + figures[i].CalculateSquare().ToString("F2"));
        }
        Console.WriteLine("=============================================");
        FindAndPrintMaxFigures(figures);
    }

    public static void FindAndPrintMaxFigures(ICalculatable[] figures)
    {
        if (figures == null || figures.Length == 0)
        {
            Console.WriteLine("Массив фигур пуст.");
            return;
        }

        ICalculatable maxVolumeFigure = figures[0];
        ICalculatable maxSquareFigure = figures[0];

        for (int i = 1; i < figures.Length; i++)
        {
            if (figures[i].CalculateVolume() > maxVolumeFigure.CalculateVolume())
            {
                maxVolumeFigure = figures[i];
            }

            if (figures[i].CalculateSquare() > maxSquareFigure.CalculateSquare())
            {
                maxSquareFigure = figures[i];
            }
        }

        Console.WriteLine("Фигура с НАИБОЛЬШИМ объемом: " + maxVolumeFigure.Name + " (V = " + maxVolumeFigure.CalculateVolume().ToString("F2") + ")");
                          
        Console.WriteLine("Фигура с НАИБОЛЬШЕЙ площадью поверхности: " + maxSquareFigure.Name + " (S = " + maxSquareFigure.CalculateSquare().ToString("F2") + ")");
    }
}