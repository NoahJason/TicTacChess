using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacChess
{
    public partial class Form1 : Form
    {
        // What color is selected?
        string SelectedPieceColor = "";

        // The pictureboxes to use while moving pieces
        PictureBox pcbFrom = null;
        PictureBox pcbTo = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectedPieceColor = "White";
            UpdatePieceColor();

            foreach (PictureBox item in gbxBoard.Controls.OfType<PictureBox>())
            {
                item.AllowDrop = true;
            }
        }
        private void UpdatePieceColor()
        {
            if (SelectedPieceColor == "White")
            {
                pcbKnight.Image = Properties.Resources.Knight_White;
                pcbRook.Image = Properties.Resources.Rook_White;
                pcbQueen.Image = Properties.Resources.Queen_White;
            }
            else if (SelectedPieceColor == "Black")
            {
                pcbKnight.Image = Properties.Resources.Knight_Black;
                pcbRook.Image= Properties.Resources.Rook_Black;
                pcbQueen.Image= Properties.Resources.Queen_Black;
            }
        }

        private void rdbWhite_CheckedChanged(object sender, EventArgs e)
        {
            SelectedPieceColor = "White";
            UpdatePieceColor();
        }

        private void rdbBlack_CheckedChanged(object sender, EventArgs e)
        {
            SelectedPieceColor = "Black";
            UpdatePieceColor();
        }

        private void pcbAllPieces_MouseDown(object sender, MouseEventArgs e)
        {
            pcbFrom = (PictureBox)sender;
            pcbFrom.DoDragDrop(pcbFrom.Image, DragDropEffects.Copy);
        }

        private void pcbBoard_DragDrop(object sender, DragEventArgs e)
        {
            pcbTo = (PictureBox)sender;
            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pcbTo.Image = getPicture;
        }

        private void pcbBoard_DragOver(object sender, DragEventArgs e)
        {
            pcbTo = (PictureBox)sender;
            e.Effect = DragDropEffects.Copy;
        }
    }
}
