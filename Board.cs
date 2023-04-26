using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiecesBeingPiecesLesson
{
    internal class Board
    {

        private int horizontal;
        private int vertical;
        private Piece currentPiece = null;
        public int arduinoRot;
        private int arduinoHor;
        private int arduinoVer;
        private string pictureName = "";

        public Board(int c_horizontal, int c_vertical, string c_pictureName, int c_arduinoHor, int c_arduinoRot, int c_arduinoVer)
        {
            horizontal = c_horizontal;
            vertical = c_vertical;
            pictureName = c_pictureName;
            arduinoHor = c_arduinoHor;
            arduinoRot = c_arduinoRot;
            arduinoVer = c_arduinoVer;
        }

        //gets
        public int GetHorizontal() { return horizontal; }
        public int GetVertical() { return vertical; }
        public Piece GetPiece() {  return currentPiece; }
        public string GetPictureName() {  return pictureName; }

        public int GetArduinoRot() { return arduinoRot; }
        public int GetArduinoHor() { return arduinoHor; }
        public int GetArduinoVer() { return arduinoVer; }

        //sets
        public void SetPiece(Piece piece) { currentPiece = piece; }
    }
}
