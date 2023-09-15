using System.Reflection.Metadata.Ecma335;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            //_____________Ecercise 1___________________
            //Name: Tommy
            //Favorite color: Green
            //Favorite animal: Tiger
            //Favorite band: Beatles

            //Console.WriteLine("Hello - What is your first name?");
            //String userName = Console.ReadLine();

            //Console.WriteLine($"Hi, {userName}- What is your favorite color?");
            //String color = Console.ReadLine();

            //Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            //String animal = Console.ReadLine();

            //Console.WriteLine("great! now, What is your favorite band?");
            //String band = Console.ReadLine();

            //Console.WriteLine($"Hello, {userName}! You're favorite color {color}, and you love {animal}'s , and the band {band}");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse (Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse (Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number to add");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

        }
        public static int Sum(params int[] list)
        {
            int sum = 0;
            foreach (var item in list)
            {
                sum = sum + item;
            }

            return sum;
        }
        
        public static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}
