using System;
public class Enumvariables
{
    public enum Values
    {
        a,b,c,d,e,f,g,h,i
    }
    public static void Main()
    {
        Console.WriteLine("Value of D:");
        int values = (int)Values.d;
        Console.WriteLine(values);
    }
}
