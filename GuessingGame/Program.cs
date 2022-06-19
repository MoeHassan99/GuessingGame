// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
class GuessingGame
{
    static void Main(string[] args)
    {
        Random random = new Random();//Randomly let the user know what the number. Generates new numbers 
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guesses;//Ger en track på hur många guesses det tar. 
        string respons;


        while (playAgain)
        {
            guess = 0;
            guesses = 0;
            respons = "";
            number = random.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess " + guess);

                if (guess > number)
                {
                    Console.WriteLine(guess + " is too high!");
                }
                else if (guess < number)
                {
                    Console.WriteLine(guess + " is too low!");
                }
                guesses++;
                //Om numret är för högt eller för lågt så ger vi användren en hint.
            }
            Console.WriteLine("Number: " + number);
            Console.WriteLine("YOU WIN!");
            Console.WriteLine("Guesses: " + guesses);


            Console.WriteLine("Would you like to play again? (Y/N) ");
            respons = Console.ReadLine();
            respons = respons.ToUpper();

            if (respons == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
        Console.WriteLine("Thanks for playing!");

        Console.ReadKey();
    }
}

