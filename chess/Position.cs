using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess {
    /// <summary>
    /// Position Object. Holds x and y coordinates relating to the board.
    /// </summary>
    class Position {
        private int x;
        private int y;

        //Constructor
        public Position(int x, int y) {
            this.x = x;
            this.y = y;
        }

        //Returns the x coordinate
        public int getX() {
            return x;
        }

        //Returns the y coordinate
        public int getY() {
            return y;
        }

        //Sets the x coordinate if it exists on the board.
        public void setX(int x) {
                this.x = x;
        }

        //Sets the y coordinate if it exists on the board.
        public void setY(int y) {
                this.y = y;
        }
    }
}
