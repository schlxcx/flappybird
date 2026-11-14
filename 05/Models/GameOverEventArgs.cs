using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Models;

public enum GameOverReason
{
    CollisionWithPipe,
    LeftGameField
}

public class GameOverEventArgs : EventArgs
{
    public GameOverReason Reason { get; }
    public GameOverEventArgs(GameOverReason reason)
    {
        Reason = reason;
    }
}
