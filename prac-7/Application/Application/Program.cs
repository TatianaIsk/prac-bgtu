public class MainApp
{
    public static void Main()
    {
        const double accelerationOfFreeFall = 9.8; // ускорение свободного падения 
        Console.Write("Введите высоту: ");
        double hieght = double.Parse(Console.ReadLine());
        Console.WriteLine($"Ответ: {Math.Sqrt(2 * hieght / accelerationOfFreeFall)}"); // формула 
    }
}