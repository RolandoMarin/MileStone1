using MileStone1;

internal class Program
{
   static Board board = new Board(11);
    private static void Main(string[] args)
    {
        //use our methods to display game :)
        board.SetupLiveNeighbors(25);
        board.CalculateLiveNeighbors();
        PrintBoard(board);
    }
    //Print Method
    private static void PrintBoard(Board myBoard)
    {
        for (int i = 0; i < board.Grid.GetLength(0); i++)
        {
            for (int k = 0; k < board.Size; k++)
            {
                Console.Write("+---");
            }
         
            for (int j = 0; j < board.Grid.GetLength(1); j++)
            {
                Console.Write("| ");
              
                if (board.Grid[i, j].Live == false)
                {
                    Console.Write(board.Grid[i, j].LiveNeighbors + " ");
                }
                if (board.Grid[i, j].Live == true)
                {
                    Console.Write("* ");
                }

            }
            Console.Write("|");
            Console.WriteLine();
        }
        Console.WriteLine("+-------------------------------------------+");
    }
}