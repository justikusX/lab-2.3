try
{
    Console.Write("Введите переменнную X : ");
    double X = double.Parse(Console.ReadLine());
    Console.Write("Введите вариант от 1 до 3 V: ");
    double V = double.Parse(Console.ReadLine());
    double a1 = -1.2, b1 = 0.75, z1 = Math.Log(Math.Abs(Math.Tan(b1 * X)));
    double a2 = 0.4, b2 = 2.4, z2 = Math.Log(Math.Abs(Math.Tan(b2 * X)));
    double a3 = 1.1, b3 = 6.1, z3 = Math.Log(Math.Abs(Math.Tan(b3 * X)));
    switch (V)
    {
        case 1:
            if (X <= a1)
            {
                double Y1 = (a1 + Math.Sin(b1 * X) + Math.Cos(Math.Pow(X, 2))); Console.WriteLine($" y1 = {Y1:F2}");
            }; break;
        case 2:
            if (a2 < X || X < Math.Log(b2))
            {
                double Y2 = Math.Sqrt(a2 + b2 * X) + Math.Sin(z2 * X); Console.WriteLine($"y2 = {Y2:F2}");
            }; break;
        case 3:
            if (X >= Math.Log(b3))
            {
                double Y3 = Math.Log(a3 + b2 * X + z3); Console.WriteLine($"y3 = {Y3:F2}");
            }; break;
        default: Console.WriteLine("увы нету"); break;
    }
}
catch
{
    Console.WriteLine("Error");
}