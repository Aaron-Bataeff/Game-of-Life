using System;

class Program
{
    static void Main()
    {
        Board board = new Board(5, 5);

        Console.WriteLine("Initial board:");
        board.Print();

        Console.WriteLine("\nClearing board...");
        board.Clear();

        Console.WriteLine("\nBoard after clear:");
        board.Print();
    }
}