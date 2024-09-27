// Lab_03_1.cs
// <Возняк Едвард>
// Лабораторна робота №3.1
// Розгалуження, задане формулою: функція однієї змінної.
// Варіант 5
class Lab3_1
{
    static void Main(String[] args)
    {
        double y;
        double x;
        double A;
        double B = 0;


        Console.WriteLine("Enter x value:");
        x = double.Parse(Console.ReadLine());

        A = ((1.0) / (Math.Abs(x + 2))) + 1;
        // short if
        if (x < 1)
            B = 7 * Math.Pow(x, 2) + x - 8;

        if (1 <= x && x <= 4)
            B = (1.0 / Math.Tan((x + 4) / Math.Sqrt(11))) + 3; // ctg = 1/tan x

        if (x > 4)
            B = Math.Sqrt(1 + Math.Abs(Math.Pow(Math.Cos(x), 3)));

        y = A - B;
        Console.WriteLine($"y = {y:F8} using short if");

        // long if
        if (x < 1)
        {
            B = 7 * Math.Pow(x, 2) + x - 8;
        }
        else if (1 <= x && x <= 4)
        {
            B = (1.0 / Math.Tan((x + 4) / Math.Sqrt(11))) + 3; // ctg = 1/tan x
        }
        else
        {
            B = Math.Sqrt(1 + Math.Abs(Math.Pow(Math.Cos(x), 3)));
        }

        y = A - B;

        Console.WriteLine($"y = {y:F8} using long if");

    }
}
