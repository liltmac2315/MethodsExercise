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

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}- What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is an awesome color! What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("great! now, What is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Hello, {userName}! You're favorite color {color}, and you love {animal}'s , and the band {band}");



        }
    }
}
