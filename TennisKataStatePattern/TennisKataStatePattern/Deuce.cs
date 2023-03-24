namespace TennisKataStatePattern;
public class Deuce : IScoreState
{
    private Game _game;
    public Deuce(Game game)
    {
        _game = game;
    }
    public string BallWinner(string winner)
    {
        if(winner == "server")
        {
            _game.serverScore++;
            _game.State = _game.ServerAdvantage;
        }
        else
        {
            _game.receiverScore++;
            _game.State = _game.ReceiverAdvantage;
        }

        return _game.State.Score();
    }

    public string Score()
    {
        return "Deuce";
    }
}
