using GuessingGame;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the guessing game!");
        Game game = new Game();
        game.RunGame();
        return;
    }

}