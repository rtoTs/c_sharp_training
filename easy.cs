using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("整数を入力して下しあ");
        var x = int.Parse(Console.ReadLine());
        var y = x * x;
        Console.WriteLine("{0} * {0} = {1}", x, y);
    }
}