namespace P10Random
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("give me a seed number (integer please): ");
            int seed = Convert.ToInt32(Console.ReadLine());
            Random random = new Random(seed);
            Console.WriteLine("Three integers between 0 and 5:");
            for (int i = 0; i < 3; i++)
            {
                int num1 = random.Next(0, 5);
                Console.WriteLine(num1);
            }
            Console.WriteLine("Three numbers between 0.0 and 0.5:");
            for (int i = 0; i < 3; i++)
            {
                double num2 = random.NextDouble()*0.5;
                Console.WriteLine(num2);
            }
            Console.WriteLine("Three numbers between 0.2 and 0.7:");
            for (int i = 0; i < 3; i++)
            {
                double num3 = random.NextDouble()*(0.7-0.2)+0.2;
                Console.WriteLine(num3);
            }
            Console.WriteLine("Give me a crit chance between 0.0 (0%) and 1.0 (100%)");
            Double crit = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {
                double num3 = random.NextDouble() * 1.0;
                if (num3 < crit)
                {
                    Console.WriteLine("Crit");
                }
                else
                {
                    Console.WriteLine("No Crit");
                }
            }
        }
    }
}