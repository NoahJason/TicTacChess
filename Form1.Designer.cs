namespace TicTacChess
{
        partial class Form1
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.rdbWhite = new System.Windows.Forms.RadioButton();
            this.gbxBoard = new System.Windows.Forms.GroupBox();
            this.pcbOne = new System.Windows.Forms.PictureBox();
            this.pcbNine = new System.Windows.Forms.PictureBox();
            this.pcbTwo = new System.Windows.Forms.PictureBox();
            this.pcbEight = new System.Windows.Forms.PictureBox();
            this.pcbSeven = new System.Windows.Forms.PictureBox();
            this.pcbSix = new System.Windows.Forms.PictureBox();
            this.pcbThree = new System.Windows.Forms.PictureBox();
            this.pcbFive = new System.Windows.Forms.PictureBox();
            this.pcbFour = new System.Windows.Forms.PictureBox();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.rdbBlack = new System.Windows.Forms.RadioButton();
            this.gbxPieces = new System.Windows.Forms.GroupBox();
            this.pcbPawn = new System.Windows.Forms.PictureBox();
            this.pcbKing = new System.Windows.Forms.PictureBox();
            this.pcbQueen = new System.Windows.Forms.PictureBox();
            this.pcbBishop = new System.Windows.Forms.PictureBox();
            this.pcbRook = new System.Windows.Forms.PictureBox();
            this.pcbKnight = new System.Windows.Forms.PictureBox();
            this.gbxBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSeven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFour)).BeginInit();
            this.gbxPieces.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBishop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKnight)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbWhite
            // 
            this.rdbWhite.AutoSize = true;
            this.rdbWhite.Checked = true;
            this.rdbWhite.Location = new System.Drawing.Point(495, 57);
            this.rdbWhite.Margin = new System.Windows.Forms.Padding(4);
            this.rdbWhite.Name = "rdbWhite";
            this.rdbWhite.Size = new System.Drawing.Size(62, 20);
            this.rdbWhite.TabIndex = 51;
            this.rdbWhite.TabStop = true;
            this.rdbWhite.Text = "White";
            this.rdbWhite.UseVisualStyleBackColor = true;
            this.rdbWhite.CheckedChanged += new System.EventHandler(this.rdbWhite_CheckedChanged);
            // 
            // gbxBoard
            // 
            this.gbxBoard.Controls.Add(this.pcbOne);
            this.gbxBoard.Controls.Add(this.pcbNine);
            this.gbxBoard.Controls.Add(this.pcbTwo);
            this.gbxBoard.Controls.Add(this.pcbEight);
            this.gbxBoard.Controls.Add(this.pcbSeven);
            this.gbxBoard.Controls.Add(this.pcbSix);
            this.gbxBoard.Controls.Add(this.pcbThree);
            this.gbxBoard.Controls.Add(this.pcbFive);
            this.gbxBoard.Controls.Add(this.pcbFour);
            this.gbxBoard.Controls.Add(this.pnlLeft);
            this.gbxBoard.Controls.Add(this.pnlBottom);
            this.gbxBoard.Controls.Add(this.pnlRight);
            this.gbxBoard.Controls.Add(this.pnlTop);
            this.gbxBoard.Location = new System.Drawing.Point(8, 85);
            this.gbxBoard.Margin = new System.Windows.Forms.Padding(4);
            this.gbxBoard.Name = "gbxBoard";
            this.gbxBoard.Padding = new System.Windows.Forms.Padding(4);
            this.gbxBoard.Size = new System.Drawing.Size(479, 455);
            this.gbxBoard.TabIndex = 49;
            this.gbxBoard.TabStop = false;
            this.gbxBoard.Text = "Board";
            // 
            // pcbOne
            // 
            this.pcbOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbOne.Location = new System.Drawing.Point(8, 23);
            this.pcbOne.Margin = new System.Windows.Forms.Padding(4);
            this.pcbOne.Name = "pcbOne";
            this.pcbOne.Size = new System.Drawing.Size(133, 123);
            this.pcbOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbOne.TabIndex = 4;
            this.pcbOne.TabStop = false;
            this.pcbOne.Tag = "11";
            this.pcbOne.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbOne.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            // 
            // pcbNine
            // 
            this.pcbNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbNine.Location = new System.Drawing.Point(335, 324);
            this.pcbNine.Margin = new System.Windows.Forms.Padding(4);
            this.pcbNine.Name = "pcbNine";
            this.pcbNine.Size = new System.Drawing.Size(133, 123);
            this.pcbNine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbNine.TabIndex = 11;
            this.pcbNine.TabStop = false;
            this.pcbNine.Tag = "33";
            this.pcbNine.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbNine.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            // 
            // pcbTwo
            // 
            this.pcbTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbTwo.Location = new System.Drawing.Point(171, 23);
            this.pcbTwo.Margin = new System.Windows.Forms.Padding(4);
            this.pcbTwo.Name = "pcbTwo";
            this.pcbTwo.Size = new System.Drawing.Size(133, 123);
            this.pcbTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTwo.TabIndex = 0;
            this.pcbTwo.TabStop = false;
            this.pcbTwo.Tag = "21";
            this.pcbTwo.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbTwo.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            // 
            // pcbEight
            // 
            this.pcbEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbEight.Location = new System.Drawing.Point(171, 324);
            this.pcbEight.Margin = new System.Windows.Forms.Padding(4);
            this.pcbEight.Name = "pcbEight";
            this.pcbEight.Size = new System.Drawing.Size(133, 123);
            this.pcbEight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEight.TabIndex = 10;
            this.pcbEight.TabStop = false;
            this.pcbEight.Tag = "23";
            this.pcbEight.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbEight.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            // 
            // pcbSeven
            // 
            this.pcbSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbSeven.Location = new System.Drawing.Point(8, 324);
            this.pcbSeven.Margin = new System.Windows.Forms.Padding(4);
            this.pcbSeven.Name = "pcbSeven";
            this.pcbSeven.Size = new System.Drawing.Size(133, 123);
            this.pcbSeven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSeven.TabIndex = 9;
            this.pcbSeven.TabStop = false;
            this.pcbSeven.Tag = "13";
            this.pcbSeven.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbSeven.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            // 
            // pcbSix
            // 
            this.pcbSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbSix.Location = new System.Drawing.Point(333, 174);
            this.pcbSix.Margin = new System.Windows.Forms.Padding(4);
            this.pcbSix.Name = "pcbSix";
            this.pcbSix.Size = new System.Drawing.Size(133, 123);
            this.pcbSix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSix.TabIndex = 8;
            this.pcbSix.TabStop = false;
            this.pcbSix.Tag = "32";
            this.pcbSix.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbSix.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            // 
            // pcbThree
            // 
            this.pcbThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbThree.Location = new System.Drawing.Point(333, 23);
            this.pcbThree.Margin = new System.Windows.Forms.Padding(4);
            this.pcbThree.Name = "pcbThree";
            this.pcbThree.Size = new System.Drawing.Size(133, 123);
            this.pcbThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbThree.TabIndex = 5;
            this.pcbThree.TabStop = false;
            this.pcbThree.Tag = "31";
            this.pcbThree.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbThree.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            // 
            // pcbFive
            // 
            this.pcbFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFive.Location = new System.Drawing.Point(171, 174);
            this.pcbFive.Margin = new System.Windows.Forms.Padding(4);
            this.pcbFive.Name = "pcbFive";
            this.pcbFive.Size = new System.Drawing.Size(133, 123);
            this.pcbFive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFive.TabIndex = 7;
            this.pcbFive.TabStop = false;
            this.pcbFive.Tag = "22";
            this.pcbFive.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbFive.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            // 
            // pcbFour
            // 
            this.pcbFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbFour.Location = new System.Drawing.Point(8, 174);
            this.pcbFour.Margin = new System.Windows.Forms.Padding(4);
            this.pcbFour.Name = "pcbFour";
            this.pcbFour.Size = new System.Drawing.Size(133, 123);
            this.pcbFour.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFour.TabIndex = 6;
            this.pcbFour.TabStop = false;
            this.pcbFour.Tag = "12";
            this.pcbFour.DragDrop += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragDrop);
            this.pcbFour.DragOver += new System.Windows.Forms.DragEventHandler(this.pcbBoard_DragOver);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.Black;
            this.pnlLeft.Location = new System.Drawing.Point(149, 23);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(13, 425);
            this.pnlLeft.TabIndex = 1;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Black;
            this.pnlBottom.Location = new System.Drawing.Point(8, 304);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(460, 12);
            this.pnlBottom.TabIndex = 4;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.Color.Black;
            this.pnlRight.Location = new System.Drawing.Point(312, 23);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(13, 425);
            this.pnlRight.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Black;
            this.pnlTop.Location = new System.Drawing.Point(8, 154);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(460, 12);
            this.pnlTop.TabIndex = 3;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(16, 15);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(133, 63);
            this.btnRestart.TabIndex = 50;
            this.btnRestart.Text = "Restart game";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // rdbBlack
            // 
            this.rdbBlack.AutoSize = true;
            this.rdbBlack.Location = new System.Drawing.Point(636, 57);
            this.rdbBlack.Margin = new System.Windows.Forms.Padding(4);
            this.rdbBlack.Name = "rdbBlack";
            this.rdbBlack.Size = new System.Drawing.Size(62, 20);
            this.rdbBlack.TabIndex = 52;
            this.rdbBlack.Text = "Black";
            this.rdbBlack.UseVisualStyleBackColor = true;
            this.rdbBlack.CheckedChanged += new System.EventHandler(this.rdbBlack_CheckedChanged);
            // 
            // gbxPieces
            // 
            this.gbxPieces.Controls.Add(this.pcbPawn);
            this.gbxPieces.Controls.Add(this.pcbKing);
            this.gbxPieces.Controls.Add(this.pcbQueen);
            this.gbxPieces.Controls.Add(this.pcbBishop);
            this.gbxPieces.Controls.Add(this.pcbRook);
            this.gbxPieces.Controls.Add(this.pcbKnight);
            this.gbxPieces.Location = new System.Drawing.Point(495, 85);
            this.gbxPieces.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPieces.Name = "gbxPieces";
            this.gbxPieces.Padding = new System.Windows.Forms.Padding(4);
            this.gbxPieces.Size = new System.Drawing.Size(292, 455);
            this.gbxPieces.TabIndex = 53;
            this.gbxPieces.TabStop = false;
            this.gbxPieces.Text = "Pieces";
            // 
            // pcbPawn
            // 
            this.pcbPawn.BackColor = System.Drawing.Color.Transparent;
            this.pcbPawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbPawn.Location = new System.Drawing.Point(141, 174);
            this.pcbPawn.Margin = new System.Windows.Forms.Padding(4);
            this.pcbPawn.Name = "pcbPawn";
            this.pcbPawn.Size = new System.Drawing.Size(133, 123);
            this.pcbPawn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPawn.TabIndex = 33;
            this.pcbPawn.TabStop = false;
            this.pcbPawn.Tag = "0";
            this.pcbPawn.Visible = false;
            // 
            // pcbKing
            // 
            this.pcbKing.BackColor = System.Drawing.Color.Transparent;
            this.pcbKing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbKing.Location = new System.Drawing.Point(141, 324);
            this.pcbKing.Margin = new System.Windows.Forms.Padding(4);
            this.pcbKing.Name = "pcbKing";
            this.pcbKing.Size = new System.Drawing.Size(133, 123);
            this.pcbKing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbKing.TabIndex = 40;
            this.pcbKing.TabStop = false;
            this.pcbKing.Tag = "0";
            this.pcbKing.Visible = false;
            // 
            // pcbQueen
            // 
            this.pcbQueen.BackColor = System.Drawing.Color.Transparent;
            this.pcbQueen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbQueen.Location = new System.Drawing.Point(0, 324);
            this.pcbQueen.Margin = new System.Windows.Forms.Padding(4);
            this.pcbQueen.Name = "pcbQueen";
            this.pcbQueen.Size = new System.Drawing.Size(133, 123);
            this.pcbQueen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbQueen.TabIndex = 39;
            this.pcbQueen.TabStop = false;
            this.pcbQueen.Tag = "0";
            this.pcbQueen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbAllPieces_MouseDown);
            // 
            // pcbBishop
            // 
            this.pcbBishop.BackColor = System.Drawing.Color.Transparent;
            this.pcbBishop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbBishop.Location = new System.Drawing.Point(141, 23);
            this.pcbBishop.Margin = new System.Windows.Forms.Padding(4);
            this.pcbBishop.Name = "pcbBishop";
            this.pcbBishop.Size = new System.Drawing.Size(133, 123);
            this.pcbBishop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBishop.TabIndex = 36;
            this.pcbBishop.TabStop = false;
            this.pcbBishop.Tag = "0";
            this.pcbBishop.Visible = false;
            // 
            // pcbRook
            // 
            this.pcbRook.BackColor = System.Drawing.Color.Transparent;
            this.pcbRook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbRook.Location = new System.Drawing.Point(0, 23);
            this.pcbRook.Margin = new System.Windows.Forms.Padding(4);
            this.pcbRook.Name = "pcbRook";
            this.pcbRook.Size = new System.Drawing.Size(133, 123);
            this.pcbRook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbRook.TabIndex = 38;
            this.pcbRook.TabStop = false;
            this.pcbRook.Tag = "0";
            this.pcbRook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbAllPieces_MouseDown);
            // 
            // pcbKnight
            // 
            this.pcbKnight.BackColor = System.Drawing.Color.Transparent;
            this.pcbKnight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbKnight.Location = new System.Drawing.Point(0, 174);
            this.pcbKnight.Margin = new System.Windows.Forms.Padding(4);
            this.pcbKnight.Name = "pcbKnight";
            this.pcbKnight.Size = new System.Drawing.Size(133, 123);
            this.pcbKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbKnight.TabIndex = 37;
            this.pcbKnight.TabStop = false;
            this.pcbKnight.Tag = "0";
            this.pcbKnight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pcbAllPieces_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 546);
            this.Controls.Add(this.rdbWhite);
            this.Controls.Add(this.gbxBoard);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.rdbBlack);
            this.Controls.Add(this.gbxPieces);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSeven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFour)).EndInit();
            this.gbxPieces.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBishop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbKnight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.RadioButton rdbWhite;
            private System.Windows.Forms.GroupBox gbxBoard;
            private System.Windows.Forms.PictureBox pcbOne;
            private System.Windows.Forms.PictureBox pcbNine;
            private System.Windows.Forms.PictureBox pcbTwo;
            private System.Windows.Forms.PictureBox pcbEight;
            private System.Windows.Forms.PictureBox pcbSeven;
            private System.Windows.Forms.PictureBox pcbSix;
            private System.Windows.Forms.PictureBox pcbThree;
            private System.Windows.Forms.PictureBox pcbFive;
            private System.Windows.Forms.PictureBox pcbFour;
            private System.Windows.Forms.Panel pnlLeft;
            private System.Windows.Forms.Panel pnlBottom;
            private System.Windows.Forms.Panel pnlRight;
            private System.Windows.Forms.Panel pnlTop;
            private System.Windows.Forms.Button btnRestart;
            private System.Windows.Forms.RadioButton rdbBlack;
            private System.Windows.Forms.PictureBox pcbKing;
            private System.Windows.Forms.PictureBox pcbQueen;
            private System.Windows.Forms.PictureBox pcbBishop;
            private System.Windows.Forms.PictureBox pcbRook;
            private System.Windows.Forms.PictureBox pcbPawn;
            private System.Windows.Forms.GroupBox gbxPieces;
            private System.Windows.Forms.PictureBox pcbKnight;
        }
    }
