using _05.Models;
using Timer = System.Windows.Forms.Timer;

namespace _05;

public partial class FlappyBird : Form
{
    const int FieldWidth = 800;
    const int FieldHeight = 800;
    const int SpawnTime = 50;

    int ticks = 0;
    int point = 0;

    Bird player = null;
    List<MoveableGameElement> allGameElements = new List<MoveableGameElement>();
    Timer gameTick = new Timer() { Interval = 40 };
    Timer pointCounterPerSecond = new Timer() { Interval = 1000 };

    public FlappyBird()
    {
        Width = FieldWidth;
        Height = FieldHeight;

        InitGame();

        gameTick.Tick += OnGameTick;
        pointCounterPerSecond.Tick += OnPointCounterPerSecond;
        KeyDown += OnKeyDown;
    }

    private void OnKeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Space)
            player.Flap();
    }

    private void OnPointCounterPerSecond(object? sender, EventArgs e)
    {
        point += 1;
        Text = $"FlappyBird - {point}s";
    }

    private void OnGameTick(object? sender, EventArgs e)
    {
        ticks++;
        if ( ticks >= SpawnTime)
        {
            ticks = 0;

            allGameElements.AddRange(Pipe.CreatePipes(ClientSize));
            allGameElements[^2].Leaving += OnLeaving;
            allGameElements[^1].Leaving += OnLeaving;
            Controls.AddRange(allGameElements[^2], allGameElements[^1]);
        }
        foreach (MoveableGameElement gameElement in MoveableGameElement.MoveableGameElements)
        {
            gameElement.Move(ClientSize);
        }
    }

    private void OnLeaving(object? sender, LeavingEventArgs e)
    {
        allGameElements.Remove(e.MoveableGameElement);
        Controls.Remove(e.MoveableGameElement);
    }

    private void OnGameOver(object? sender, GameOverEventArgs e)
    {
        gameTick.Stop();
        pointCounterPerSecond.Stop();

        DialogResult = MessageBox.Show($"Gameover: {(e.Reason == GameOverReason.LeftGameField ? "Der Spieler hat das Spiel verlassen." : "Der Spieler ist mit der Pipe kolidiert.")}\nZeit: {point} Sekunden\n\nNochmals spielen?", "Flappybird", MessageBoxButtons.YesNo);
        if (DialogResult == DialogResult.Yes)
        {
            Controls.Clear();
            InitGame();
        }
        else
            Close();
    }

    private void InitGame()
    {
        gameTick.Start();
        pointCounterPerSecond.Start();

        player = new Bird(ClientSize.Height);
        player.GameOver += OnGameOver;
        Controls.Add(player);

        point = 0;
        ticks = 100;
        Text = "FlappyBird - 0s";
    }
}
