namespace TennisKataStatePattern;

public class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        while (game.State != game.IsWon)
        {
            Console.WriteLine("Who gets the next point? \n 1.Server 2.Receiver");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine(game.Play("server"));
                    break;
                case "2":
                    Console.WriteLine(game.Play("receiver"));
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}