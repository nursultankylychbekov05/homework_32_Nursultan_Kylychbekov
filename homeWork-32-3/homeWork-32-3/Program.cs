using System.Text.Json;
namespace homeWork_32_3;

class Program
{
    private const string JsonFileName = "../../../results.json";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nСписок фигур: параллелепипед, пирамида, сфера, цилиндр, конус");
            Console.WriteLine("Для завершения работы программы введите: 'выход' или '0' ");
            Console.WriteLine("\nУкажите фигуру:");
            
            string choice = Console.ReadLine();
            
            if (choice != null) 
            {
                choice = choice.ToLower().Trim();
            }
            
            if (choice == "выход" || choice == "0")
            {
                Console.WriteLine("\nПрограмма завершена. Результаты сохранены в файле " + JsonFileName);
                break;
            }

            ICalculatable figure = null;

            switch (choice)
            {
                case "параллелепипед":
                    double? length = ReadNullableDouble("Введите длину:\n");
                    double? width = ReadNullableDouble("Введите ширину:\n");
                    double? height = ReadNullableDouble("Введите высоту:\n");
                    figure = new Parallelepiped("параллелепипед", length, width, height);
                    break;

                case "пирамида":
                    double? bLength = ReadNullableDouble("Введите длину основания:\n");
                    double? bWidth = ReadNullableDouble("Введите ширину основания:\n");
                    double? pHeight = ReadNullableDouble("Введите высоту:\n");
                    figure = new Pyramid("пирамида", bLength, bWidth, pHeight);
                    break;

                case "сфера":
                    double? radius = ReadNullableDouble("Введите радиус:\n");
                    figure = new Sphere("сфера", radius);
                    break;

                case "цилиндр":
                    double? cRadius = ReadNullableDouble("Введите радиус основания:\n");
                    double? cHeight = ReadNullableDouble("Введите высоту:\n");
                    figure = new Cylinder("цилиндр", cRadius, cHeight);
                    break;

                case "конус":
                    double? coRadius = ReadNullableDouble("Введите радиус основания:\n");
                    double? coHeight = ReadNullableDouble("Введите высоту:\n");
                    figure = new Cone("конус", coRadius, coHeight);
                    break;

                default:
                    Console.WriteLine("Такой фигуры нет в списке или команда не распознана.");
                    continue; 
            }
            
            if (figure != null)
            {
                double? volume = figure.CalculateVolume();
                double? square = figure.CalculateSquare();

                Console.WriteLine();

                if (volume.HasValue == false || square.HasValue == false)
                {
                    Console.WriteLine("Ошибка: Произвести расчет невозможно (некорректные параметры).");
                }
                else
                {
                    Console.WriteLine("Фигура | Объем    | Площадь");
                    Console.WriteLine("-------|----------|---------");
                    
                    string namePart = figure.Name.PadRight(6);
                    string volPart = volume.Value.ToString("F2").PadRight(8);
                    string sqPart = square.Value.ToString("F2");

                    Console.WriteLine(namePart + " | " + volPart + " | " + sqPart);
                    
                    SaveToJson(figure.Name, volume.Value, square.Value);
                }
            }
        }
    }
    
    public static void SaveToJson(string name, double volume, double square)
    {
        List<CalculationResult> logList = new List<CalculationResult>();
        
        if (File.Exists(JsonFileName))
        {
            try
            {
                string existingJson = File.ReadAllText(JsonFileName);
                if (string.IsNullOrWhiteSpace(existingJson) == false)
                {
                    logList = JsonSerializer.Deserialize<List<CalculationResult>>(existingJson);
                }
            }
            catch
            {
                logList = new List<CalculationResult>();
            }
        }
        
        CalculationResult currentResult = new CalculationResult(name, volume, square);
        logList.Add(currentResult);
        
        JsonSerializerOptions jsonOptions = new JsonSerializerOptions();
        jsonOptions.WriteIndented = true;
        
        string updatedJsonText = JsonSerializer.Serialize(logList, jsonOptions);
        File.WriteAllText(JsonFileName, updatedJsonText);
        
        Console.WriteLine("\nРезультат успешно добавлен в файл " + JsonFileName);
   
    }

    public static double? ReadNullableDouble(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        
        try
        {
            double result = Convert.ToDouble(input);
            return result;
        }
        catch
        {
            return null;
        }
    }
}