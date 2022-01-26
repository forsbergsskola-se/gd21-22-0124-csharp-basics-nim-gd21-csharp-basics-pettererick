namespace Conversion
{
    class Program
    {
        static void Main()
        {
            double number = 5;
            string numberString = number.ToString();
            Console.WriteLine(numberString);
            numberString = "56.3";
            number = Convert.ToDouble(numberString);
            Console.WriteLine(number);
            
        }
    }
}

