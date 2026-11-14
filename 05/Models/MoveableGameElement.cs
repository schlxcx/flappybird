using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace _05.Models;

public class MoveableGameElement : Panel
{
    protected int xMovingSpeed = 0;
    protected int yMovingSpeed = 0;

    protected static readonly List<MoveableGameElement> moveableGameElements = new List<MoveableGameElement>();

    public static ImmutableList<MoveableGameElement> MoveableGameElements => moveableGameElements.ToImmutableList();

    public event EventHandler<LeavingEventArgs>? Leaving;

    public MoveableGameElement()
    {
        moveableGameElements.Add(this);
    }

    public virtual new void Move(Size formSize) 
    {
        Top += yMovingSpeed;
        Left += xMovingSpeed;

        if (Bottom < 0 || Right < 0 || Top > formSize.Height || Left > formSize.Width)
        {
            Leaving?.Invoke(this, new LeavingEventArgs(this));

        }
    }
}
