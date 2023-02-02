using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone1
{
    public class Cell
    {
        //properties
        public int X { get; set; }
        public int Y { get; set; }
        public bool Visited { get; set; }
        public bool Live { get; set; }
        public int LiveNeighbors { get; set; }
        public Cell() {
            //set our values
            X = -1;
            Y = -1;
            LiveNeighbors = 0;
            Live = false;
            Visited = false;
        }

        public int GetX()
        { 
            return X;
        }
        public int SetX(int _x) {
            X= _x;
            return X;
        }
        public int GetY()
        {
            return Y;
        }
        public int SetY(int _y) {
        Y= _y;
        return Y;
        }
   
    }
}
