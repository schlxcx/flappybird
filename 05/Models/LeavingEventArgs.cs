using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Models;

public class LeavingEventArgs : EventArgs
{
    public MoveableGameElement MoveableGameElement { get; }
    public LeavingEventArgs(MoveableGameElement moveableGameElement)
    {
        MoveableGameElement = moveableGameElement;
    }
}
