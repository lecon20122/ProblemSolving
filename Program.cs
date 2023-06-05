// See https://aka.ms/new-console-template for more information

using DataStructure;

public class Program
{
    public static void Main(string[] args)
    {
        Area area = new();

        int[] prices = new int[] { 1,1 };

        int result = area.MaxArea(prices); 

        Console.WriteLine(result);
    }
}

