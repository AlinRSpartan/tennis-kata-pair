namespace TennisKataStatePattern;
public class ServerMatchPoint : IScoreState
{
    private Game _game;
    public ServerMatchPoint(Game game)
    {
        _game = game;
    }
    public string BallWinner(string winner)
    {

        if(winner == "server")
        {
            _game.serverScore=5;
            _game.State = _game.IsWon;
        }
        else if (++_game.receiverScore == _game.serverScore) 
                _game.State = _game.Deuce;

        return _game.State.Score();
    }

    public string Score()
    {
        return $"{(SCORES)_game.serverScore} {(SCORES)_game.receiverScore}";
    }
}
