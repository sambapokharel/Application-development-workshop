using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // declare and initialize variables
        byte b = 255;
        short s = -32768;
        int i = 42;
        long l = 1234567890123L;
        float f = 3.14f;
        double d = 2.71828;
        decimal dec = 79.99M;
        char c = 'A';
        bool bo = true;

        // conversions
        string iAsString = i.ToString();
        double parsedDouble = double.Parse("3.14", CultureInfo.InvariantCulture);

        // print variables with labels, types and values
        Console.WriteLine($"byte   (b) : {b} (Type: {b.GetType()})");
        Console.WriteLine($"short  (s) : {s} (Type: {s.GetType()})");
        Console.WriteLine($"int    (i) : {i} (Type: {i.GetType()})");
        Console.WriteLine($"long   (l) : {l} (Type: {l.GetType()})");
        Console.WriteLine($"float  (f) : {f} (Type: {f.GetType()})");
        Console.WriteLine($"double (d) : {d} (Type: {d.GetType()})");
        Console.WriteLine($"decimal(dec): {dec} (Type: {dec.GetType()})");
        Console.WriteLine($"char   (c) : {c} (Type: {c.GetType()})");
        Console.WriteLine($"bool   (bo): {bo} (Type: {bo.GetType()})");
        Console.WriteLine();
        Console.WriteLine($"int -> string      : {iAsString} (Type: {iAsString.GetType()})");
        Console.WriteLine($"\"3.14\" -> double  : {parsedDouble} (Type: {parsedDouble.GetType()})");
    }
}