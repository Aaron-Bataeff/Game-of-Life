using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Board board = new Board(25, 25);

        // Centered glider pattern
        board.SetCell(11, 12, true);
        board.SetCell(12, 13, true);
        board.SetCell(13, 11, true);
        board.SetCell(13, 12, true);
        board.SetCell(13, 13, true);

        for (int i = 0; i < 100; i++)
        {
            Console.Clear();
            Console.WriteLine($"Generation {i}");
            board.Print();

            board.NextGeneration();

            Thread.Sleep(500);
        }
    }
}