namespace Input
{
    class Program
    {
        private static string name;
        static void Main()
        {
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
        }
    }
}
