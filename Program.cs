// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using System.Net.Quic;

Console.WriteLine("Hello, World!");

var s = new Solution();

var mc = s.MinDifference([1,5,0,10,14]);





public static class Cls
{
    public static int[][] GetArray(this string input)
    {
        input = input.Trim('[', ']');

        var rows = input.Split(new string[] { "],[" }, StringSplitOptions.None);

        int[][] array = new int[rows.Length][];

        for (int i = 0; i < rows.Length; i++)
        {
            array[i] = rows[i].Split(',').Select(int.Parse).ToArray();
        }
        return array;
    }

    public static void ToConsole<T>(this T[][] arr)
    {
        Console.WriteLine();
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(string.Join(",", arr[i]));
        }
    }

    public static void ToConsole<T>(this T[,] arr)
    {
        Console.WriteLine();
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + ",");
            }
            Console.WriteLine();
        }
    }
}