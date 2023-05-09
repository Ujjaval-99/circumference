// See https://aka.ms/new-console-template for more information
// Program to implement area of circle in C#
using System;
class Circle
{
    static void Main(string[] args)
    {
        Console.Write("Enter Radius: ");
        double rad = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * rad * rad;
        Console.WriteLine("Area of circle is: " + area);
    }
}
