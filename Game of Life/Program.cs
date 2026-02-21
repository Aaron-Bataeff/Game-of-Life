using System;

class Program
{
    static void Main()
    {
        Board board = new Board(5, 5);

        // Turn on some cells around (1,1)
        board.SetCell(0, 1, true);
        board.SetCell(1, 2, true);
        board.SetCell(2, 1, true);

        board.Print();

        int neighbors = board.CountNeighbors(1, 1);
        Console.WriteLine($"\nNeighbors of (1,1): {neighbors}");
    }
}