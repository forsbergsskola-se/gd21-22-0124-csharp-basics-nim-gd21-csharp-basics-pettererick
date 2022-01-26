namespace Boolean
{
    class Program
    {
        private static bool isChild = false;
        private static bool isTeenager = false;
        private static bool isAdult = false;
        static void Main()
        {
            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 19)
            {
                if (age > 12)
                {
                    isTeenager = true;
                }
                else
                {
                    isChild = true;
                }
            }
            else
            {
                isAdult = true;
            }
            Console.WriteLine("You are a Child: " + isChild);
            Console.WriteLine("You are a Teenager: " + isTeenager);
            Console.WriteLine("You are a Adult: " + isAdult);
        }
    }
}
