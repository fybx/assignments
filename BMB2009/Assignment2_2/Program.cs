/*
 *      Ferit Yiğit BALABAN, <f@fybx.dev>
 *      032190002
 */

using System;

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
        throw new NotImplementedException();
    }

    /// <summary>
    /// Calculates new coordinates of snake's body parts.
    /// </summary>
    /// <param name="direction">Direction player stepped to; up being 1, right 2, down 3 and left 4.</param>
    /// <returns>Returns updated coordinate array of body.</returns>
    private static int[,] CalculateSnakeBody(int direction)
    {
        throw new NotImplementedException();
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
        throw new NotImplementedException();
    }

    public static bool CheckCollision(int[,] snakeBody)
    {
        return CheckCollision();
    }

    public static int[,] CalculateSnakeBody(int[,] snakeBody, int direction)
    {
        return CalculateSnakeBody(direction);
    }
}