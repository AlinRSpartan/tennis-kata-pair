namespace TennisKataStatePattern;
public class ServerAdvantage : IScoreState
{
    private Game _game;
    public ServerAdvantage(Game game)
    {
        _game = game;
    }
    public string BallWinner(string winner)
    {
        if(winner == "server")
        {
            _game.serverScore++;
            _game.State = _game.IsWon;
        }
        else
        {
            _game.serverScore--;
            _game.State = _game.Deuce;
        }

        return _game.State.Score();
    }

    public string Score()
    {
        return "Advantage Server";
    }
}
