namespace TennisKataStatePattern;

public class Game
{
    public IScoreState State;
    public IScoreState Default;
    public IScoreState Deuce;
    public IScoreState ServerMatchPoint;
    public IScoreState ReceiverMatchPoint;
    public IScoreState ServerAdvantage;
    public IScoreState ReceiverAdvantage;
    public IScoreState IsWon;


    public int serverScore = 0;
    public int receiverScore = 0;

    public Game()
    {
        Default = new Default(this);
        Deuce = new Deuce(this);
        ServerMatchPoint = new ServerMatchPoint(this);
        ReceiverMatchPoint = new ReceiverMatchPoint(this);
        ServerAdvantage = new ServerAdvantage(this);
        ReceiverAdvantage = new ReceiverAdvantage(this);
        IsWon = new IsWon(this);
        State = Default;
    }

    public string Play(string winner)
    {
        return State.BallWinner(winner);
    }

    
}
