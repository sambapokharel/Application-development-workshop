public class TypeConversion
{
    public static void Main()
    {
        byte byteValue = 25;
        short shortValue = 12;
        int intValue = 42;
        long longValue = 123456789L;
        float floatValue = 5.75f;
        double doubleValue = 9.99;
        decimal decimalValue = 19.99M;
        char charValue = 'A';
        bool boolValue = true;

        String strValue = Convert.ToString(intValue);
        double convertedDouble = Convert.ToDouble("3.14");

        Console.WriteLine($"Byte: {byteValue}, type: {byteValue.GetType()}");
        Console.WriteLine($"Short: {shortValue}, type: {shortValue.GetType()}");
        Console.WriteLine($"Int: {intValue}, type: {intValue.GetType()}");
        Console.WriteLine($"Long: {longValue}, type: {longValue.GetType()}");
        Console.WriteLine($"Float: {floatValue}, type: {floatValue.GetType()}");
        Console.WriteLine($"Double: {doubleValue}, type: {doubleValue.GetType()}");
        Console.WriteLine($"Decimal: {decimalValue}, type: {decimalValue.GetType()}");
        Console.WriteLine($"Char: {charValue}, type: {charValue.GetType()}");
        Console.WriteLine($"Bool: {boolValue}, type: {boolValue.GetType()}");
        Console.WriteLine($"Converted String: {strValue}, type: {strValue.GetType()}");
        Console.WriteLine($"Converted Double: {convertedDouble}, type: {convertedDouble.GetType()}");
    }
}
