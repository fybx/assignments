/*
 *      Ferit Yiğit BALABAN, <f@fybx.dev>
 *      032190002
 */

using System;
using System.Security.Principal;

namespace Assignment2_2;

// ReSharper disable once InconsistentNaming
public static class Assignment2_2
{
    /// <summary>
    /// Field gameState defines 3 states the game can take.
    /// If state = 0 game is waiting for a keypress to be started
    ///    bigger  0 game is started, every keypress calculates collisions then redraws scene if no collision is made
    ///    smaller 0 game is lost, ask for spesific keypress to restart, if pressed set state to 0
    /// </summary>
    private static int gameState;

    /// <summary>
    /// Field snakeBody gives coordinates of snake body parts with the last (4th) element being the head.
    /// </summary>
    private static int[,] snakeBody = new int[5,2]
    {
        { 38, 15 },
        { 39, 15 },
        { 40, 15 },
        { 41, 15 },
        { 42, 15 }
    };
    
    public static void Main(string[] args)
    {
        bool gameGoesOn = true;

        while (gameGoesOn)
        {
            // GetArrowKeypress
            // CalculateNewState
            // CheckCollision
            // Redraw
        }
    }

    /// <summary>
    /// Does collision checks against console window borders and itself.
    /// </summary>
    /// <returns>Returns true if collision occurs, otherwise false.</returns>
    private static bool CheckCollision()
    {
        int headX = snakeBody[4, 0];
        int headY = snakeBody[4, 1];

        if (headX is -1 || headY is -1) return true;
        if (headX == Console.WindowWidth + 1 || headY == Console.WindowHeight + 1) return true;
        for (int i = 0; i < 4; i++)
            if (snakeBody[i, 0] == headX && snakeBody[i, 1] == headY)
                return true;
        return false;
    }

    /// <summary>
    /// Calculates new coordinates of snake's body parts.
    /// </summary>
    /// <param name="direction">Direction player stepped to; up being 1, right 2, down 3 and left 4.</param>
    /// <returns>Returns updated coordinate array of body.</returns>
    private static int[,] CalculateSnakeBody(int direction)
    {
        for (int i = 0; i < 4; i++)
        {
            snakeBody[i, 0] = snakeBody[i + 1, 0];
            snakeBody[i, 1] = snakeBody[i + 1, 1];
        }
        snakeBody[4, 0] += direction switch
        {
            1 => -1,
            3 => 1,
            _ => 0
        };
        snakeBody[4, 1] += direction switch
        {
            2 => 1,
            4 => -1,
            _ => 0
        };

        return snakeBody;
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
        
        Console.Clear();
        for (int i = 0; i < 5; i++)
        {
            Console.SetCursorPosition(snakeBody[i, 0], snakeBody[i, 1]);
            Console.Write(i is 4 ? "0" : "*");
        }
    }

    public static bool CheckCollision(int[,] snakeBody)
    {
        Assignment2_2.snakeBody = snakeBody;
        return CheckCollision();
    }

    public static int[,] CalculateSnakeBody(int[,] snakeBody, int direction)
    {
        return CalculateSnakeBody(direction);
    }
}