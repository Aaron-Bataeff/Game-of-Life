using System;

public class Board
{
    private bool[,] grid;
    private int rows;
    private int cols;

    public Board(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        grid = new bool[rows, cols];
    }

    public void Print()
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                Console.Write(grid[r, c] ? "O " : ". ");
            }
            Console.WriteLine();
        }
    }

    public void Clear()
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                grid[r, c] = false;
            }
        }
    }
}
