namespace IfElse
{
    class Program
    {
        
        static void Main()
        {
            Console.Write("How old are you? ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 19)
            {
                if (age > 12)
                {
                    Console.WriteLine("You are a teenager.");
                }
                else
                {
                    Console.WriteLine("You are a child.");
                }
            }
            else
            {
                Console.WriteLine("You are a grown-up.");
            }
            
            Console.Write("Give me an integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(age, num);
            Console.WriteLine("The higher number is: " + max);
            if (num % 2 == 0)
            {
                Console.WriteLine("The number you gave is even.");
            }
            else
            {
                Console.WriteLine("The number you gave is odd.");
            }
        }
    }
}