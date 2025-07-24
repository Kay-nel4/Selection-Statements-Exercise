using System.ComponentModel.Design;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(
                "Hello I will let the computer choose a random number, I think my favorite number will\nbe too easy to guess! You Have 5 tries...\nGood Luck!");
            var r = new Random();
            var favoriteNumber = r.Next(1, 100);
            for (int i = 0; i < 5; i++)
                do
                {

                    Console.WriteLine("Guess any Number between 1 and 100!");
                    var userInput = int.Parse(Console.ReadLine());


                    if (userInput > 1 && userInput < 100)
                    {

                        if (userInput < favoriteNumber)
                        {
                            Console.WriteLine("Too Low!");
                        }
                        else if (userInput > favoriteNumber)
                        {
                            Console.WriteLine("Too High!");
                        }
                        else
                        {
                            Console.WriteLine("Woah How Did You Get That?\nGreat Job!!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid answer.");
                    }

                } while (favoriteNumber != favoriteNumber);


            Console.WriteLine("Ooh too bad try again");
        }
    }
}
