// Lab_03_2.cs
// <Возняк Едвард>
// Лабораторна робота №3.2
// Розгалуження, задане формулою: функція з параметрами.
// Варіант 5
class Lab3_2
{
    static void Main(String[] args)
    {
        double f = 0;
        double a, b, c, x;

        Console.WriteLine("Enter x value:");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter a value:");
        a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter b value:");
        b = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter c value:");
        c = double.Parse(Console.ReadLine());

        // short if
        if (x < 0 && b != 0)
            f = a - (x / 10.0 + b);
        if (x > 0 && b == 0)
            f = (x - a) / (x - c);
        if(!(x<0 && b != 0) && !(x>0&&b==0))
            f = 3 * x + (2.0 / c);

        Console.WriteLine($"F = {f:F8} using long if");


        // long if
        if (x < 0 && b != 0)
        {
            f = a - (x / 10.0 + b);
        }
        else if (x > 0 && b == 0)
        {
            f = (x - a) / (x - c);
        }
        else
        {
            f = 3 * x + (2.0 / c);
        }

        Console.WriteLine($"F = {f:F8} using long if");
    }
}
