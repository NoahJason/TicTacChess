using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using PiecesBeingPiecesLesson;


namespace TicTacChess
{
    public partial class Form1 : Form
    {
        #region Form Vairables
        /* Selected Color */
        string selectedPieceColor = "";

        /* The pictureboxes to use while moving pieces*/
        PictureBox pcbFrom = null;
        PictureBox pcbTo = null;

        /* Variables to move pieces */
        List<Piece> pieceList = null;
        Piece activePiece = null;

        List<Board> boardList = null;
        Board activeBoard = null;

        string pieceOptions = "";
        int horizontal, vertical;
        PictureBox pbxForbidden;
        Board forbidden;

        /* Move when its your turn */
        int onBoardCount = 0;
        bool gameStart = false;
        string turnColor = "";

        /* Check winner */
        List<string> winlist = null;
        string startingBlack = "012";
        string startingWhite = "678";

        // Arduino variables
        bool arduinoOn = false;
        bool moveBusy = false;
        string commando;
        Board oldBoard = null;
        Board newBoard = null;
        int moveArduinoCounter = 0;
        int baseDropVertical = 0;
        Form2 arduinoForm = null;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Start as white */
            selectedPieceColor = "White";
            turnColor = "White";
            rdbWhite.Checked = true;
            UpdatePieceColor();

            foreach (PictureBox item in gbxBoard.Controls.OfType<PictureBox>())
            {
                item.AllowDrop = true;
            }

            SetupGame();
        }

        private void pcbBoard_MouseDown(object sender, MouseEventArgs e)
        {
            pcbFrom = (PictureBox)sender;

            if (pcbFrom.BackColor == Color.White && gameStart == true)
            {
                horizontal = Convert.ToInt32(pcbFrom.Tag.ToString().Substring(0, 1));
                vertical = Convert.ToInt32(pcbFrom.Tag.ToString().Substring(1, 1));

                activeBoard = boardList.FirstOrDefault(x => x.GetHorizontal() == horizontal && x.GetVertical() == vertical);
                activePiece = activeBoard.GetPiece();
                oldBoard = activeBoard;

                GetBoardOptions();
                ResetBoardOptions();
                UpdateBoardpieceOptions();

                /* wizard move check */
                GetWizardMoveOptions();

                CheckForIllegalMoves();

                if (pcbFrom.Image != null)
                {
                    pcbFrom.DoDragDrop(pcbFrom.Image, DragDropEffects.Copy);
                }
            }
        }
        private void pcbBoard_DragDrop(object sender, DragEventArgs e)
        {
            pcbTo = (PictureBox)sender;

            Image getPicture = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            pcbTo.Image = getPicture;
            pcbTo.BackColor = Color.Transparent;

            horizontal = Convert.ToInt32(pcbTo.Tag.ToString().Substring(0, 1));
            vertical = Convert.ToInt32(pcbTo.Tag.ToString().Substring(1, 1));

            if (activeBoard != null)
            {
                activeBoard.SetPiece(null);
                activeBoard = boardList.FirstOrDefault(x => x.GetHorizontal() == horizontal && x.GetVertical() == vertical);
                activePiece.SetCurrentPicturebox(pcbTo.Name);
                activeBoard.SetPiece(activePiece);

                pcbFrom.Image = null;

                /* Change turn color */
                if (turnColor == "White")
                {
                    turnColor = "Black";
                }
                else
                {
                    turnColor = "White";
                }

                CheckWinner();
            }
            else
            {
                /* Dragging pieces to the board */
                activePiece.SetCurrentPicturebox(pcbTo.Name);
                boardList.FirstOrDefault(x => x.GetHorizontal() == horizontal && x.GetVertical() == vertical).SetPiece(activePiece);

                onBoardCount++;
                activePiece.SetOnBoard(true);
                UpdateBoardpieceOptions();

            }

            ResetBoardOptions();
            UpdatePieceOnBoardColors();

            /* Game starts after counting 6 pieces on the board */
            if (onBoardCount == 6)
            {
                rdbBlack.Enabled = false;
                rdbWhite.Enabled = false;

                lblGameState.Text = "Game starts, white begins";
                onBoardCount++;
                gameStart = true;
                turnColor = "White";
            }

            UpdateAllBoardColors();
        }
        private void pcbBoard_DragOver(object sender, DragEventArgs e)
        {
            pcbTo = (PictureBox)sender;
            if (pcbTo.BackColor == Color.Green)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pcbAllPieces_MouseDown(object sender, MouseEventArgs e)
        {
            activeBoard = null;
            pcbFrom = (PictureBox)sender;
            if (pcbFrom.BackColor == Color.White)
            {
                foreach (Piece item in pieceList)
                {
                    if (item.GetBasePictureboxName() == pcbFrom.Name && item.GetColor() == selectedPieceColor)
                    {
                        activePiece = item;

                    }
                }

                GetStartingOptions();

                pcbFrom.DoDragDrop(pcbFrom.Image, DragDropEffects.Copy);
            }
        }
        private void rdbBlack_CheckedChanged(object sender, EventArgs e)
        {
            selectedPieceColor = "Black";
            UpdatePieceColor();
            UpdatePieceOnBoardColors();
        }
        private void rdbWhite_CheckedChanged(object sender, EventArgs e)
        {
            selectedPieceColor = "White";
            UpdatePieceColor();
            UpdatePieceOnBoardColors();
        }
        private void pcbBoard_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap) && ((PictureBox)sender).BackColor == Color.Green)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
                UpdateAllBoardColors();
            }
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        #region Move validation
        public void CheckForIllegalMoves()
        {
            Board right = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() + 1 && x.GetVertical() == activeBoard.GetVertical());
            Board left = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() - 1 && x.GetVertical() == activeBoard.GetVertical());
            Board up = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() && x.GetVertical() == activeBoard.GetVertical() - 1);
            Board down = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() && x.GetVertical() == activeBoard.GetVertical() + 1);


            if (activePiece != null)
            {
                if (activePiece.GetName() == "Rook" || activePiece.GetName() == "Queen" || activePiece.GetName() == "King")
                {
                    CheckForNeighbour(right, "Right");
                    CheckForNeighbour(left, "Left");
                    CheckForNeighbour(up, "Up");
                    CheckForNeighbour(down, "Down");

                }

                if (activePiece.GetName() == "Queen" || activePiece.GetName() == "King")
                {
                    Board upRight = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() + 1 && x.GetVertical() == activeBoard.GetVertical() - 1);
                    Board upLeft = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() - 1 && x.GetVertical() == activeBoard.GetVertical() - 1);
                    Board downRight = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() + 1 && x.GetVertical() == activeBoard.GetVertical() + 1);
                    Board downLeft = boardList.FirstOrDefault(x => x.GetHorizontal() == activeBoard.GetHorizontal() - 1 && x.GetVertical() == activeBoard.GetVertical() + 1);

                    CheckForNeighbour(upRight, "UpRight");
                    CheckForNeighbour(upLeft, "UpLeft");
                    CheckForNeighbour(downRight, "DownRight");
                    CheckForNeighbour(downLeft, "DownLeft");
                }
            }
        }
        private void CheckForNeighbour(Board neighbour, string direction)
        {
            if (neighbour != null && neighbour.GetPiece() != null)
            {
                switch (direction)
                {
                    case "Left":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() - 1 && o.GetVertical() == neighbour.GetVertical());
                        break;
                    case "Right":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() + 1 && o.GetVertical() == neighbour.GetVertical());
                        break;
                    case "Up":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() && o.GetVertical() == neighbour.GetVertical() - 1);
                        break;
                    case "Down":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() && o.GetVertical() == neighbour.GetVertical() + 1);
                        break;
                    case "UpRight":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() + 1 && o.GetVertical() == neighbour.GetVertical() - 1);
                        break;
                    case "UpLeft":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() - 1 && o.GetVertical() == neighbour.GetVertical() - 1);
                        break;
                    case "DownRight":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() + 1 && o.GetVertical() == neighbour.GetVertical() + 1);
                        break;
                    case "DownLeft":
                        forbidden = boardList.FirstOrDefault(o => o.GetHorizontal() == neighbour.GetHorizontal() - 1 && o.GetVertical() == neighbour.GetVertical() + 1);
                        break;
                    default:
                        break;
                }
            }

            if (forbidden != null)
            {
                pbxForbidden = (PictureBox)gbxBoard.Controls.Find(forbidden.GetPictureName(), false)[0];
                pbxForbidden.BackColor = Color.White;
            }
        }
        public void GetBoardOptions()
        {
            pieceOptions = "";
            foreach (Board item in boardList)
            {
                if (activePiece != null && item.GetPiece() == null)
                {
                    pieceOptions += activePiece.GetMoveOptions(horizontal, vertical, item.GetHorizontal(), item.GetVertical());
                }
            }
        }
        #endregion

        #region Game events
        /* Setup Game */
        public void SetupGame()
        {
            pieceList = new List<Piece>();
            /* white */
            pieceList.Add(new Piece("Rook", "White"));
            pieceList.Add(new Piece("Knight", "White"));
            pieceList.Add(new Piece("Queen", "White"));
            pieceList.Add(new Piece("Wizard", "White"));
            pieceList.Add(new Piece("King", "White"));

            /* black */
            pieceList.Add(new Piece("Rook", "Black"));
            pieceList.Add(new Piece("Wizard", "Black"));
            pieceList.Add(new Piece("King", "Black"));
            pieceList.Add(new Piece("Knight", "Black"));
            pieceList.Add(new Piece("Queen", "Black"));

            boardList = new List<Board>();
            boardList.Add(new Board(1, 1, "pcbOne", 320, 20, 1150));
            boardList.Add(new Board(2, 1, "pcbTwo", 400, 135, 1150));
            boardList.Add(new Board(3, 1, "pcbThree", 570, 245, 1150));
            boardList.Add(new Board(1, 2, "pcbFour", 850, 0, 1150));
            boardList.Add(new Board(2, 2, "pcbFive", 900, 110, 1150));
            boardList.Add(new Board(3, 2, "pcbSix", 1050, 200, 1150));
            boardList.Add(new Board(1, 3, "pcbSeven", 1330, 0, 1150));
            boardList.Add(new Board(2, 3, "pcbEight", 1400, 95, 1150));
            boardList.Add(new Board(3, 3, "pcbNine", 1520, 175, 1150));

            winlist = new List<string>();
            winlist.Add("012");
            winlist.Add("345");
            winlist.Add("678");
            winlist.Add("036");
            winlist.Add("147");
            winlist.Add("258");
            winlist.Add("246");
            winlist.Add("048");
        }

        /* check winner */
        public void CheckWinner()
        {
            string boardOne = "";
            string boardTwo = "";
            string boardThree = "";

            int locOne, locTwo, locThree;

            /* Loops through all possible win options*/
            foreach (string item in winlist)
            {
                locOne = Convert.ToInt32(item.Substring(0, 1));
                locTwo = Convert.ToInt32(item.Substring(1, 1));
                locThree = Convert.ToInt32(item.Substring(2, 1));

                if (boardList[locOne].GetPiece() != null && boardList[locTwo].GetPiece() != null && boardList[locThree].GetPiece() != null)
                {
                    boardOne = boardList[Convert.ToInt32(item.Substring(0, 1))].GetPiece().GetColor();
                    boardTwo = boardList[Convert.ToInt32(item.Substring(1, 1))].GetPiece().GetColor();
                    boardThree = boardList[Convert.ToInt32(item.Substring(2, 1))].GetPiece().GetColor();

                    string endpoisitions = $"{locOne}{locTwo}{locThree}";

                    if (endpoisitions == item)
                    {
                        if (boardOne == boardTwo && boardTwo == boardThree && boardOne != "" && boardTwo != "" && boardThree != "")
                        {
                            if (boardOne == "White")
                            {
                                if (endpoisitions != startingWhite)
                                {
                                    MessageBox.Show("White won", "Winner!", MessageBoxButtons.OK);
                                    SetupGame();
                                }
                            }
                            else
                            {
                                if (endpoisitions != startingBlack)
                                {
                                    MessageBox.Show("Black won", "Winner!", MessageBoxButtons.OK);
                                    SetupGame();
                                }
                            }
                        }
                    }
                }

            }

        }

        /* Restart */
        public void Restart()
        {
            /* reset the disabled inputs */
            rdbBlack.Enabled = true;
            rdbWhite.Enabled = true;

            /* Selected Color */
            selectedPieceColor = "";

            /* The pictureboxes to use while moving pieces */
            pcbFrom = null;
            pcbTo = null;

            /* Variables to move pieces */
            activePiece = null;
            activeBoard = null;

            pieceOptions = "";
            horizontal = 0;
            vertical = 0;
            pbxForbidden = null;
            forbidden = null;

            /*  Move when its your turn */
            onBoardCount = 0;
            gameStart = false;

            /* Check winner */
            winlist = null;
            startingBlack = "012";
            startingWhite = "678";

            /* Start as white */
            selectedPieceColor = "White";
            turnColor = "White";
            rdbWhite.Checked = true;

            /* clear board */
            foreach (PictureBox pb in gbxBoard.Controls.OfType<PictureBox>())
            {
                pb.Image = null;
                lblGameState.Text = "Start game, Setup pieces";
                pb.BackColor = Color.White;
            }

            /* clear pieces */
            foreach (Piece item in pieceList)
            {
                foreach (PictureBox pb in gbxPieces.Controls.OfType<PictureBox>())
                {
                    if (item.GetBasePictureboxName() == pb.Name && item.GetColor() == selectedPieceColor)
                    {
                        pb.BackColor = Color.White;
                    }
                }
            }

            SetupGame();
        }

        /* starting options */
        public void GetStartingOptions()
        {
            if (selectedPieceColor == "White")
            {
                pieceOptions = "132333";
            }
            else
            {
                pieceOptions = "112131";
            }

            UpdateBoardpieceOptions();
        }

        /* change color */
        public void UpdatePieceColor()
        {
            if (selectedPieceColor == "White")
            {
                pcbKing.Image = Properties.Resources.white_king;
                pcbWizard.Image = Properties.Resources.white_wizard;
                pcbKnight.Image = Properties.Resources.white_knight;
                pcbQueen.Image = Properties.Resources.white_queen;
                pcbRook.Image = Properties.Resources.white_rook;
            }
            else if (selectedPieceColor == "Black")
            {
                pcbKing.Image = Properties.Resources.black_king;
                pcbWizard.Image = Properties.Resources.black_wizard;
                pcbQueen.Image = Properties.Resources.black_queen;
                pcbRook.Image = Properties.Resources.black_rook;
                pcbKnight.Image = Properties.Resources.black_knight;
            }

            ResetBoardOptions();
        }
        #endregion

        #region Update move

        /* Show all possible places to go to */
        public void UpdateBoardpieceOptions()
        {

            for (int i = 0; i < pieceOptions.Length; i += 2)
            {
                foreach (PictureBox pb in gbxBoard.Controls.OfType<PictureBox>())
                {
                    if (pb.Tag.ToString() == pieceOptions[i].ToString() + pieceOptions[i + 1].ToString() && pb.Image == null)
                    {
                        pb.BackColor = Color.Green;
                    }

                }
            }

        }

        /* Before calculating a pieceoptions the old ones have to be cleared */
        public void ResetBoardOptions()
        {
            foreach (PictureBox pb in gbxBoard.Controls.OfType<PictureBox>())
            {
                pb.BackColor = Color.White;
            }
        }

        /* You can not have multiple of the same pieces */
        public void UpdatePieceOnBoardColors()
        {
            if (pieceList != null)
            {
                foreach (Piece item in pieceList)
                {
                    foreach (PictureBox pb in gbxPieces.Controls.OfType<PictureBox>())
                    {
                        if (item.GetBasePictureboxName() == pb.Name && item.GetColor() == selectedPieceColor)
                        {
                            if (item.GetIsOnBoard())
                            {
                                pb.BackColor = Color.Red;
                            }
                            else
                            {
                                pb.BackColor = Color.White;
                            }
                        }
                    }
                }
            }
        }

        /* Loop trough all the board pieces and handle the turns */
        public void UpdateAllBoardColors()
        {
            foreach (PictureBox pb in gbxBoard.Controls.OfType<PictureBox>())
            {
                Board c = boardList.FirstOrDefault(x => x.GetPictureName() == pb.Name);
                if (c.GetPiece() != null)
                {
                    if (c.GetPiece().GetColor() == turnColor)
                    {
                        pb.BackColor = Color.White;
                    }
                    else
                    {
                        pb.BackColor = Color.Gray;
                    }
                }
            }
        }
        #endregion

        #region Wizard
        public void GetWizardMoveOptions()
        {
            if ((activePiece != null) && (activePiece.GetName() == "Wizard"))
            {
                foreach (PictureBox pb in gbxBoard.Controls.OfType<PictureBox>())
                {
                    Board c = boardList.FirstOrDefault(x => x.GetPictureName() == pb.Name);
                    if (pb.Image == null || c.GetPiece().GetColor() == turnColor)
                    {
                        pb.BackColor = Color.Green;
                    }
                }
            }

        }
        #endregion

        private void ckxArduino_CheckedChanged_1(object sender, EventArgs e)
        {
            arduinoOn = ckxArduino.Checked;
            if (arduinoOn)
            {
                arduinoForm = new Form2();
                arduinoForm.Show();
            }
            else
            {
                arduinoForm.Close();
            }
        }

        private void tmrArduino_Tick_1(object sender, EventArgs e)
        {
            lblGameState.Text = "Arduino is busy";
            if (moveArduinoCounter == 0)
            {
                commando = $"RS:{oldBoard.GetArduinoRot()}";
            }
            else if (moveArduinoCounter == 1)
            {
                commando = $"HS:{oldBoard.GetArduinoHor()}";
            }
            else if (moveArduinoCounter == 2)
            {
                commando = $"VS:{oldBoard.GetArduinoVer()}";
            }
            else if (moveArduinoCounter == 3)
            {
                commando = $"CS:1";
            }
            else if (moveArduinoCounter == 4)
            {
                commando = $"SS:1";
            }
            else if (moveArduinoCounter == 5)
            {
                commando = $"VS:{baseDropVertical}";
            }
            else if (moveArduinoCounter == 6)
            {
                commando = $"RS:{newBoard.GetArduinoRot()}";
            }
            else if (moveArduinoCounter == 7)
            {
                commando = $"HS:{newBoard.GetArduinoHor()}";
            }
            else if (moveArduinoCounter == 8)
            {
                commando = $"VS:{baseDropVertical}";
            }
            else if (moveArduinoCounter == 9)
            {
                commando = $"SS:0";
            }
            else if (moveArduinoCounter == 10)
            {
                commando = $"CS:0";
            }
            else if (moveArduinoCounter == 11)
            {
                commando = $"ZS:3";
            }
            else if (moveArduinoCounter == 12)
            {
                commando = $"ZS:2";
            }
            else if (moveArduinoCounter == 13)
            {
                commando = $"ZS:1";
            }
            else if (moveArduinoCounter == 14)
            {
                tmrArduino.Enabled = false;
                if (turnColor == "White")
                {
                    lblGameState.Text = "Black's turn";
                    turnColor = "Black";
                }
                else
                {
                    lblGameState.Text = "White's turn";
                    turnColor = "White";
                }
            }
            UpdateAllBoardColors();
            gameStart = true;
            CheckWinner();


            if (moveBusy == false)
            {
                moveBusy = true;
                arduinoForm.WriteArduino(commando);
            }
        }

        public void NextArduinoStep()
        {
            // Increment the Arduino counter to allow for a new command to run
            moveArduinoCounter++;
            moveBusy = false;
        }
    }
}