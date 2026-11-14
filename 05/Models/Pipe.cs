using System;
using System.Collections.Generic;
using System.Text;

namespace _05.Models;

public class Pipe : MoveableGameElement
{
    static readonly Random random = new Random();
    const int PipeWidth = 50;
    static readonly Color PipeColor = Color.DarkOliveGreen;
    const int MinPipeHeight = 5;
    const int gapDenominator = 3;
    const int XMovingSpeed = 1;

    //public Pipe() { }  // Durch fehlenden Konstruktor und private Konstruktor wird verhindert, dass Pipe außerhalb der Klasse instanziiert werden kann.

    private Pipe(int height, bool isTopPipe, Size formSize)
    {
        Width = PipeWidth;
        Height = height;
        Location = new Point(formSize.Width - 1, isTopPipe ? 0 : formSize.Height - height);
        BackColor = PipeColor;
    }

    public static List<MoveableGameElement> CreatePipes(Size formSize)
    {
        int gapHeight = formSize.Height / gapDenominator;
        int PipeTopHeight = random.Next(MinPipeHeight, formSize.Height - gapHeight + 1);
        Pipe pipeTop = new Pipe(PipeTopHeight, true, formSize);
        Pipe pipeBottom = new Pipe(formSize.Height - gapHeight - PipeTopHeight, false, formSize);
        return new List<MoveableGameElement> { pipeTop, pipeBottom };
    }

    public override void Move(Size formSize)
    {
        xMovingSpeed -= XMovingSpeed;
        base.Move(formSize);
    }
}
