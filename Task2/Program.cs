public class Circle
{
    const double pi = 3.14;

    public  static void Main()
    {
        Console.WriteLine(CalculateArea(5));
        Console.WriteLine(CalculateCircumference(5));
    }

     public static double CalculateArea(double radius)
    {
        return pi * radius * radius;
    }
    public static double CalculateCircumference(double radius)
    {
        return 2 * pi * radius;
    }
}