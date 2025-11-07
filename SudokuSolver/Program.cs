namespace SudokuSolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SudokuEngine engine = new("530070000600195000098000060800060003400803001700020006060000280000419005000080079");
            Console.WriteLine("Sudoku puzzle");
            engine.DisplayBoard();
            Console.WriteLine();
            if (engine.SolveWithDepthFirstSearch())
            {
                Console.WriteLine("Solution");
                engine.DisplayBoard();
            }
            else
            {
                Console.WriteLine("Invalid puzzle.");
            }

        }
    }
}