namespace TennisKata;

internal class Program
{
    static void Main(string[] args)
    {
        Game game = Game.Instance;
        Console.WriteLine(game.Score());
        while ( game.GameInProgress)
        {
            Console.WriteLine("Who gets the next point? \n 1.Server 2.Receiver");
            switch (Console.ReadLine())
                {
                case "1": game.Play("server");
                    break;
                case "2": game.Play("receiver");
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}