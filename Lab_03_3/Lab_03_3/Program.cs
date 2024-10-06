// Lab_03_3.cs
// <Возняк Едвард>
// Лабораторна робота №3.3
// Розгалуження, задане графіком функції.
// Варіант 5
class Lab3_3
{
    static void Main(string[] args)
    {
        double y, x;
        double R;

        Console.WriteLine("Enter x value:");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter R value:");
        R = double.Parse(Console.ReadLine());

        if (-4 < x && x < -2)
            y = x + 3;
        else if (-2 < x && x < 4)
            y = 1 + ((-R - 1) / (4 + 2)) * (x + 2);
        else if (4 < x && x < 8 - R)
            y = -R;
        else if(8-R<x && x < 8+R)
            y = -R + Math.Sqrt(Math.Pow(R,2) - Math.Pow(x - 8,2));
        else
            y = -R;

        Console.WriteLine($"y = {y:F8}");
    }
}