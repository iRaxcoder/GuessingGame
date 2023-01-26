namespace GuessingGame
{
    public class Game
    {
        public void RunGame()
        {
            //init variables
            int attemps = 1;

            //random number between 0 and 9999
            int secretNumber = new Random().Next(0, 9999);

            Console.WriteLine("-Enter a integer number to start guessing");
            int userNumber = this.validateNumber(Console.ReadLine());

            //main while cicle. It will ask for a number while user's number is different to the secret number.
            while (userNumber != secretNumber)
            {
                /*is the user's number the secret number??? smaller or larger?
                  if smaller then display is too small
                */
                if (userNumber < secretNumber)
                {
                    Console.WriteLine("Tip: Number is too small!");
                }
                //if larger then display is too large
                else
                {
                    Console.WriteLine("Tip: Number is too large!");
                }
                //count the attemps of the user when guessing!
                attemps += 1;
                /*again, whe need a valid integer number for the guessing.
                  The try will count only if number is valid. Because if number is valid that means you have tried for real.
                */
                userNumber = validateNumber(Console.ReadLine());
            }
            Console.WriteLine("Congrats! You have guessed the number with " + attemps + " attemps.");
            Console.WriteLine("***THANK YOU FOR THE OPPORTUNITY!. END OF THE GAME***");
        }

        //this method basically ask if number is valid.
        //while cycle is here because we cannot continue while valid integer number is not valid.
        private int validateNumber(string number)
        {
            int cleanNumber = 0;
            while (!int.TryParse(number, out cleanNumber)){
                Console.WriteLine("Write a valid number (integer), please.");
                number = Console.ReadLine();
            }
            return cleanNumber;
        }
    }
}
