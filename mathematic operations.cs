//easy mathematical calculations

using System;

public class Program
{
    public static void Main()
    {
        int firstNumber=12;
        int secondNumber=7;
        Console.WriteLine(firstNumber + secondNumber);
    }
}


//example 2
using System;
public class Program{
    public static void Main()
    {
        string firstName="Bob";
        int widgetsSold=7;
        Console.WriteLine(firstName + " sold " + widgetsSold + " widget. ");
    }
}



//multiplication
using System;

public class Program
{
    public static void Main()
    {
        string firstName="Marry";
        int widgetsSold=7;
        Console.WriteLine(firstName + " sold "+ (widgetsSold * 7) + " widgets.");
    }
}


//division
using System;

public class Program
{
    public static void Main()
    {
        string firstName="Marry";
        int widgetsSold=7;
        Console.WriteLine(firstName + " sold "+ (widgetsSold / 7 )+ " widgets.");
    }
}






using System;

public class Program
{
    public static void Main()
    {
        int sum = 7 + 5;
        int difference = 7 - 5;
        int product = 7 * 5;
        int quotient = 7 / 5;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quotient: " + quotient);
    }
}




//To see division working properly, you need to use a data type that supports fractional digits after the decimal point like decimal.
using System;

public class Program
{
    public static void Main()
    {
        decimal decimalQuotient = 7.0m / 5;
        Console.WriteLine($"Decimal quotient: {decimalQuotient}");
    }
}



using System;

public class Program
{
    public static void Main()
    {
        int first = 7;
        int second = 5;
        decimal quotient = (decimal)first / (decimal)second;
        Console.WriteLine(quotient);
    }
}


//In math, PEMDAS is an acronym that helps students remember the order of operations. The order is:

//Parentheses (whatever is inside the parenthesis is performed first)
//Exponents
//Multiplication and Division (from left to right)
//Addition and Subtraction (from left to right)
//C# follows the same order as PEMDAS except for exponents. While there's no exponent operator in C#, you can use the System.Math.Pow method. The module "Call methods from the .NET Class Library using C#" will feature this method and others.
using System;

public class Program
{
    public static void Main()
    {
        int value1 = 3 + 4 * 5;
        int value2 = (3 + 4) * 5;
        Console.WriteLine(value1);
        Console.WriteLine(value2);
    }
}
