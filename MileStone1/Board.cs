using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MileStone1
{
    public class Board
    {
        //properties
        public int Size { get; set; }
        public Cell[,] Grid { get; set; }
        public int Difficulty { get; set; }
        
        //constructor
        public Board(int size)
        {
            Grid = new Cell[size, size];
            this.Size = size;
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    Grid[i, j] = new Cell();
                }
            }
        }
        public bool ValidateRange(int x, int y)
        {
            return x < Size && y < Size && x >= 0 && y >= 0;
        }
        public void SetupLiveNeighbors(int difficulty)
        {
            Random random = new Random();

            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    int ranNumber = random.Next(1, difficulty);
                    if (ranNumber == 1)
                    {
                        Grid[i, j].Live = true;
                    }
                }
            }
        }
        //public void CalculateLiveNeighbors()
        //{
        //    Random rand = new Random();
        //    for (int i = 0; i < Grid.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < Grid.GetLength(1); j++)
        //        {
        //            int ranNumber = rand.Next(0, 8);
        //            if (Grid[i, j].Live == false)
        //            {
        //                Grid[i, j].LiveNeighbors = ranNumber;
        //            }
        //            else if (Grid[i, j].Live == true)
        //            {
        //                Grid[i, j].LiveNeighbors = 9;
        //            }
        //        }
        //    }
        //}

        //Determines how many neighboring grids have mines
        public void CalculateLiveNeighbors()
        {
            //Change this for future milestones due to many for loops
            for (int i = 0; i < Grid.GetLength(0); i++)
            {
                for (int j = 0; j < Grid.GetLength(1); j++)
                {
                    // N
                    if (ValidateRange(i - 1, j))
                    {
                        if (Grid[i - 1, j].Live == true)
                        {
                            Grid[i, j].LiveNeighbors++;
                        }
                    }
                    // E
                    if (ValidateRange(i, j + 1))
                    {
                        if (Grid[i, j + 1].Live == true)
                        {
                            Grid[i, j].LiveNeighbors++;
                        }

                    }
                    // S
                    if (ValidateRange(i + 1, j))
                    {
                        if (Grid[i + 1, j].Live == true)
                        {
                            Grid[i, j].LiveNeighbors++;
                        }
                    }
                    // W
                    if (ValidateRange(i, j - 1))
                    {
                        if (Grid[i, j - 1].Live == true)
                        {
                            Grid[i, j].LiveNeighbors++;
                        }
                    }
                    // NW
                    if (ValidateRange(i - 1, j - 1))
                    {
                        if (Grid[i - 1, j - 1].Live == true)
                        {
                            Grid[i, j].LiveNeighbors++;
                        }
                    }
                    // NE
                    if (ValidateRange(i - 1, j + 1))
                    {
                        if (Grid[i - 1, j + 1].Live == true)
                        {
                            Grid[i, j].LiveNeighbors++;
                        }
                    }
            
          
                    // SW
                    if (ValidateRange(i + 1, j - 1))
                    {
                        if (Grid[i + 1, j - 1].Live == true)
                        {
                            Grid[i, j].LiveNeighbors++;
                        }
                    }
                    // SE
                    if (ValidateRange(i + 1, j + 1))
                    {
                        if (Grid[i + 1, j + 1].Live == true)
                        {
                            Grid[i, j].LiveNeighbors++;
                        }
                    }
                 
                }
            }
        }
    }
}
