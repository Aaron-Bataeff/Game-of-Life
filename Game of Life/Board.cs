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
}
