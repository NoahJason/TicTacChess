using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiecesBeingPiecesLesson
{
    internal class Piece
    {
        private string name = "";
        private string color = "";
        // Original piece location
        private string basePictureboxName = "";
        // The picturebox that the piece is currently occupying
        private string currentPictureboxName = "";
        private bool isOnBoard = false;
        // Available spaces to move the piece to, old & new location axis'
        private string moveOptions;
        int oldHor, oldVer, newHor, newVer;

        // Public piece constructor with current name, color and location
        public Piece(string c_name, string c_color)
        {
            name = c_name;
            color = c_color;
            basePictureboxName = "pcb" + name;
        }

        // Get
        public string GetName() { return name; }
        public string GetColor() { return color; }
        public string GetBasePictureboxName() { return basePictureboxName; }
        public string GetCurrentPicturebox() { return currentPictureboxName; }
        public bool GetIsOnBoard() { return isOnBoard; }

        //Set
        public void SetCurrentPicturebox(string newCurrentPicturebox)
        {
            currentPictureboxName = newCurrentPicturebox;
        }

        public void SetOnBoard(bool newIsOnBoard)
        {
            isOnBoard = newIsOnBoard;
        }

        public string GetMoveOptions(int curHor, int curVer, int _newHor, int _newVer)
        {
            oldHor = curHor;
            oldVer = curVer;
            newHor = _newHor;
            newVer = _newVer;
            moveOptions = "";
            switch (name)
            {
                case "Rook": MoveRook(); break;
                case "Knight": MoveKnight(); break;
                case "Queen": MoveQueen(); break;
                case "King": MoveKing(); break;
                default:
                    break;
            }
            return moveOptions;
        }

        public void MoveRook()
        {
            int tempHor = Math.Abs(newHor - oldHor);
            int tempVer = Math.Abs(newVer - oldVer);
            if (tempVer == 2 || tempVer == 1)
            {
                if (tempHor == 0)
                {
                    // Shortened statement to declare axis' as strings
                    moveOptions = $"{newHor}{newVer}";
                }
            }
            else if (tempHor == 2 || tempHor == 1)
            {
                if (tempVer == 0)
                {
                    moveOptions = $"{newHor}{newVer}";
                }
            }
        }

        public void MoveQueen()
        {
            int temp_x = Math.Abs(newHor - oldHor);
            int temp_y = Math.Abs(newVer - oldVer);

            if (temp_x == temp_y)
            {
                moveOptions = $"{newHor}{newVer}";
            }
            else if (temp_y == 2 || temp_y == 1)
            {
                if (temp_x == 0)
                {
                    moveOptions = $"{newHor}{newVer}";
                }
            }
            else if (temp_x == 2 || temp_x == 1)
            {
                if (temp_y == 0)
                {
                    moveOptions = $"{newHor}{newVer}";
                }
            }
        }

        public void MoveKnight()
        {
            int temp_x = Math.Abs(newHor - oldHor);
            int temp_y = Math.Abs(newVer - oldVer);

            if (temp_y == 2)
            {
                if (temp_x == 1)
                {
                    moveOptions = $"{newHor}{newVer}";
                }
            }
            else
            {
                if (temp_x == 2)
                {
                    if (temp_y == 1)
                    {
                        moveOptions = $"{newHor}{newVer}";
                    }
                }
            }
        }
        public void MoveKing()
        {
            int tempHor = Math.Abs(newHor - oldHor);
            int tempVer = Math.Abs(newVer - oldVer);

            /* Check if the king can move one square in any direction, including diagonally */
            if (tempHor <= 1 && tempVer <= 1 && (tempHor != 0 || tempVer != 0))
            {
                moveOptions = newHor.ToString() + newVer.ToString();
            }
        }
    }
}


