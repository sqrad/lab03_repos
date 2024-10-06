// Lab_03_4.cs
// <Возняк Едвард>
// Лабораторна робота №3.4
// Розгалуження, задане плоскою фігурою.
// Варіант 5
class Lab3_4
{
    static void Main(string[] args)
    {
        double x;
        double y;
        double R;

        Console.WriteLine("Enter x value:");
        x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y value:");
        y = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter R value:");
        R = double.Parse(Console.ReadLine());

        if (x >= 0 && y >= 0 && Math.Pow(x + y, 2) <= Math.Pow(R, 2) ||
            x <= 0 && y <= 0 && Math.Pow(x + y, 2) <= Math.Pow(R, 2) ||
            x <= 0 && y >= 0 && Math.Pow(x + y, 2) <= Math.Pow(R, 2) && y >= -x)
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");

    }
}
