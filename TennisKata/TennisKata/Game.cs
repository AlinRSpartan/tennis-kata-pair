namespace TennisKata;

public class Game
{
    private static Game? _instance;

    public static Game? Instance
    {
        get
        {
            if (_instance == null) _instance = new Game();
            return _instance;
        }
    }

    private Player server = new Player();
    private Player receiver = new Player();


    private Game()
    {

    }

    public void Play(string winner)
    {
        if (!server.Winner && !receiver.Winner)
        {
            if (winner.ToLower() == "server")
            {
                if (CheckDeuce())
                {
                    server.ToggleAdvantage();
                    if (receiver.Advantage) receiver.ToggleAdvantage();
                }
                server.AddPoint();

            }

            if (winner.ToLower() == "receiver")
            {
                if (CheckDeuce())
                {
                    receiver.ToggleAdvantage();
                    if (server.Advantage) server.ToggleAdvantage();
                }
                receiver.AddPoint();
            }

            if (server.Score == 3 && receiver.Score == 3)
            {
                server.ToggleDeuce();
                receiver.ToggleDeuce();
            }
        }

        Console.WriteLine(Score());

    }
    public bool CheckDeuce()
    {
        return server.Deuce && receiver.Deuce;
    }

    public string Score()
    {
        if (server.Winner) return "Server Wins!";
        if (receiver.Winner) return "Receiver Wins!";

        if (server.Advantage) return "Adv. Server";
        if (receiver.Advantage) return "Adv. Receiver";
        if (CheckDeuce()) return "Deuce";

        return $"{(TENNISSCORE)server.Score} {(TENNISSCORE)receiver.Score}";
    }

    public void GameSetup(int sScore, int rScore, bool serverAdv, bool receiverAdv)
    {
        server.Deuce = receiver.Deuce = false;
        server.Advantage = serverAdv;
        receiver.Advantage = receiverAdv;

        if (rScore == 3 && sScore == 3)
        {
            server.Deuce = receiver.Deuce = true;
        }

        receiver.Score = rScore;
        server.Score = sScore;
    }
}
