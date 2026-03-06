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

    public int CountNeighbors(int row, int col)
    {
        int count = 0;

        for (int r = row - 1; r <= row + 1; r++)
        {
            for (int c = col - 1; c <= col + 1; c++)
            {
                if (r == row && c == col)
                    continue;

                if (r >= 0 && r < rows && c >= 0 && c < cols)
                {
                    if (grid[r, c])
                    {
                        count++;
                    }
                }
            }
        }

        return count;
    }

    public void SetCell(int r, int c, bool value)
    {
        grid[r, c] = value;
    }

    public void NextGeneration()
    {
        bool[,] nextGrid = new bool[rows, cols];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                int neighbors = CountNeighbors(r, c);

                if (grid[r, c]) // cell is alive
                {
                    if (neighbors == 2 || neighbors == 3)
                        nextGrid[r, c] = true;
                    else
                        nextGrid[r, c] = false;
                }
                else // cell is dead
                {
                    if (neighbors == 3)
                        nextGrid[r, c] = true;
                    else
                        nextGrid[r, c] = false;
                }
            }
        }

        grid = nextGrid;
    }
}