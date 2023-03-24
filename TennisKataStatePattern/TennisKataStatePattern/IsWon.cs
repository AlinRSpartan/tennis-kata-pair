namespace TennisKataStatePattern;
public class IsWon : IScoreState
{
    private Game _game;

    public IsWon(Game game)
    {
        _game = game;
    }

    public string BallWinner(string winner)
    {
        return _game.State.Score();
    }

    public string Score()
    {
       
        return _game.serverScore == 5 ? "Server wins!" : "Receiver wins!";
    }
}
