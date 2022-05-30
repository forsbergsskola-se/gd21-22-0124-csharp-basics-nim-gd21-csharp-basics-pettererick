namespace Math
{
    class Program
    {
        static void Main()
        {
            Console.Write("Number 1: ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number 2: ");
            double second = Convert.ToDouble(Console.ReadLine());
            double max = System.Math.Max(first, second);
            Console.WriteLine("Max = " + max);
            double min = System.Math.Min(first, second);
            Console.WriteLine("Min = " + min);
            double square = System.Math.Sqrt(first);
            Console.WriteLine("Square Root of " + first + " = " + square);
            double absolute = System.Math.Abs(first);
            Console.WriteLine("Absolute of " + first + " = " + absolute);
            double round = System.Math.Round(first);
            Console.WriteLine("Round of " + first + " = " + round);
            double floor = System.Math.Floor(first);
            Console.WriteLine("Floor of " + first + " = " + floor);
            double ceiling = System.Math.Ceiling(first);
            Console.WriteLine("Ceiling of " + first + " = " + ceiling);
            double clamp = System.Math.Clamp(first, 0, second);
            Console.WriteLine("Clamp = " + clamp);
            double power = System.Math.Pow(first, second);
            Console.WriteLine("Power = " + power);
        }
    }
}

