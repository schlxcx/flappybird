using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Models;

public class Bird : MoveableGameElement
{
    const int BirdWidth = 15;
    const int BirdHeight = 10;
    const int YGravity = 10;
    const int FlapHeight = 20;
    static readonly Color BirdColor = Color.Blue;
    static readonly Color GameOverColor = Color.Red;

    public event EventHandler<GameOverEventArgs>? GameOver;

    public Bird(int formHeight)
    {
        Width = BirdWidth;
        Height = BirdHeight;
        BackColor = BirdColor;
        Location = new Point(100, formHeight / 2);
    }

    public override void Move(Size formSize)
    {
        Top += YGravity;

        if (Top < 0 || Bottom > formSize.Height)
        {
            Invoke();
        }

        foreach (MoveableGameElement? moveableGameElement in MoveableGameElements)
        {
            if (moveableGameElement != null && ! (moveableGameElement is Bird) && (this.Right > moveableGameElement.Left && this.Left < moveableGameElement.Right && this.Bottom > moveableGameElement.Top && this.Top < moveableGameElement.Bottom))
            {
                Invoke();
            }
        }
    }

    private void Invoke()
    {
        moveableGameElements.Clear();
        this.BackColor = GameOverColor;
        GameOver?.Invoke(null, new GameOverEventArgs(GameOverReason.CollisionWithPipe));
    }

    public void Flap()
    {
        Top -= FlapHeight;
    }
}
