/*
 *      Ferit Yiğit BALABAN, <f@fybx.dev>
 *      032190002
 */
namespace Assignment2_2;

// ReSharper disable once InconsistentNaming
public static class Assignment2_2
{
    /// <summary>
    /// Field _gameState defines 3 states the game can take.
    /// If state = 0 game is waiting for a keypress to be started
    ///    bigger  0 game is started, every keypress calculates collisions then redraws scene if no collision is made
    ///    smaller 0 game is lost, ask for spesific keypress to restart, if pressed set state to 0
    /// </summary>
    private static int _gameState = 1;

    /// <summary>
    /// Field _snakeBody gives coordinates of snake body parts with the last (4th) element being the head.
    /// </summary>
    private static int[,] _snakeBody;
    
    public static void Main(string[] args)
    {
        ConsoleKeyInfo key;
        start:
        _gameState = 1;
        Redraw(0);
        while (_gameState is 1)
        {
            Redraw(_gameState, _gameState is not 0);
            key = Console.ReadKey();
            int decision = key.Key switch
            {
                ConsoleKey.UpArrow => 1,
                ConsoleKey.RightArrow => 2,
                ConsoleKey.DownArrow => 3,
                ConsoleKey.LeftArrow => 4,
                ConsoleKey.Q => 5,
                _ => 6
            };
            if (decision is 5)
                _gameState = -2;
            CalculateSnakeBody(decision);
            if (CheckCollision())
                _gameState = -1;
            _gameState = _gameState > -1 ? 1 : _gameState;
        }
        
        if (_gameState is -1)
        {
            Console.Clear();
            Console.WriteLine("Kaybettiniz. Tekrar oynamak için \"r\", çıkmak için \"q\" tuşuna basınız...");
            do
            {
                key = Console.ReadKey();
                if (key.Key is ConsoleKey.R)
                    goto start;
            } while (key.Key is not ConsoleKey.Q);
        }
    }

    /// <summary>
    /// Does collision checks against console window borders and itself.
    /// </summary>
    /// <returns>Returns true if collision occurs, otherwise false.</returns>
    private static bool CheckCollision()
    {
        int headX = _snakeBody[4, 0];
        int headY = _snakeBody[4, 1];

        if (headX is -1 || headY is -1) return true;
        if (headX == Console.WindowWidth + 1 || headY == Console.WindowHeight + 1) return true;
        for (int i = 0; i < 4; i++)
            if (_snakeBody[i, 0] == headX && _snakeBody[i, 1] == headY)
                return true;
        return false;
    }

    /// <summary>
    /// Calculates new coordinates of snake's body parts.
    /// </summary>
    /// <param name="direction">Direction player stepped to; up being 1, right 2, down 3 and left 4.</param>
    /// <returns>Returns updated coordinate array of body.</returns>
    private static void CalculateSnakeBody(int direction)
    {
        for (int i = 0; i < 4; i++)
        {
            _snakeBody[i, 0] = _snakeBody[i + 1, 0];
            _snakeBody[i, 1] = _snakeBody[i + 1, 1];
        }
        _snakeBody[4, 0] += direction switch
        {
            2 => 1,
            4 => -1,
            _ => 0
        };
        _snakeBody[4, 1] += direction switch
        {
            1 => -1,
            3 => 1,
            _ => 0
        };
    }
    
    /// <summary>
    /// Draws a scene or state to console according to state parameter.
    /// </summary>
    /// <param name="state">Current game state</param>
    /// <param name="draw">True by default, can be used to skip states</param>
    private static void Redraw(int state, bool draw = true)
    {
        if (!draw)
            return;

        if (state is 0)
        {
            _snakeBody = new[,]
            {
                { 38, 15 },
                { 39, 15 },
                { 40, 15 },
                { 41, 15 },
                { 42, 15 }
            };
        } else
            Console.Clear();
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(_snakeBody[i, 0], _snakeBody[i, 1]);
            Console.Write(i is 4 ? "0" : "*");
        }
    }
}