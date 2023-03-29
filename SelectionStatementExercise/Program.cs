namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite number. It's between 1 and 1000");
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine("too low");
                userInput = int.Parse(Console.ReadLine());
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("too high");
                userInput = int.Parse(Console.ReadLine());
            }
            else {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
