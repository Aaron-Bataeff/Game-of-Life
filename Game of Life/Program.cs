using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Board board = new Board(25, 25);

        // Starting pattern
        board.SetCell(0, 1, true);
        board.SetCell(1, 2, true);
        board.SetCell(2, 0, true);
        board.SetCell(2, 1, true);
        board.SetCell(2, 2, true);

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