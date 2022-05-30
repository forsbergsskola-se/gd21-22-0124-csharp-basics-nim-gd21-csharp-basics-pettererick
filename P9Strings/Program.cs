namespace Strings
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();
            Console.WriteLine("How old are you?");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + firstname + " " + lastname + ", you are " + age + " years old.");
        }
    }
}

