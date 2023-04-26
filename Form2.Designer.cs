
namespace TicTacChess
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.gbxConnectionDkal = new System.Windows.Forms.GroupBox();
            this.lblPortText = new System.Windows.Forms.Label();
            this.lblArduinoConnectionSettingsHelpDkal = new System.Windows.Forms.Label();
            this.btnScanPortsDkal = new System.Windows.Forms.Button();
            this.cbbSerialPortsDkal = new System.Windows.Forms.ComboBox();
            this.btnSerialPortOpenDkal = new System.Windows.Forms.Button();
            this.gbxLoggingDkal = new System.Windows.Forms.GroupBox();
            this.rtbLogging = new System.Windows.Forms.RichTextBox();
            this.serialPortArduinoConnection = new System.IO.Ports.SerialPort(this.components);
            this.gbxSend = new System.Windows.Forms.GroupBox();
            this.btnPossibleMessages = new System.Windows.Forms.Button();
            this.btnZeroAll = new System.Windows.Forms.Button();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.txbSendMessage = new System.Windows.Forms.TextBox();
            this.gbxConnectionDkal.SuspendLayout();
            this.gbxLoggingDkal.SuspendLayout();
            this.gbxSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxConnectionDkal
            // 
            this.gbxConnectionDkal.Controls.Add(this.lblPortText);
            this.gbxConnectionDkal.Controls.Add(this.lblArduinoConnectionSettingsHelpDkal);
            this.gbxConnectionDkal.Controls.Add(this.btnScanPortsDkal);
            this.gbxConnectionDkal.Controls.Add(this.cbbSerialPortsDkal);
            this.gbxConnectionDkal.Controls.Add(this.btnSerialPortOpenDkal);
            this.gbxConnectionDkal.Location = new System.Drawing.Point(16, 15);
            this.gbxConnectionDkal.Margin = new System.Windows.Forms.Padding(4);
            this.gbxConnectionDkal.Name = "gbxConnectionDkal";
            this.gbxConnectionDkal.Padding = new System.Windows.Forms.Padding(4);
            this.gbxConnectionDkal.Size = new System.Drawing.Size(191, 133);
            this.gbxConnectionDkal.TabIndex = 28;
            this.gbxConnectionDkal.TabStop = false;
            this.gbxConnectionDkal.Text = "Arduino connection";
            // 
            // lblPortText
            // 
            this.lblPortText.AutoSize = true;
            this.lblPortText.Location = new System.Drawing.Point(8, 66);
            this.lblPortText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPortText.Name = "lblPortText";
            this.lblPortText.Size = new System.Drawing.Size(34, 16);
            this.lblPortText.TabIndex = 26;
            this.lblPortText.Text = "Port:";
            // 
            // lblArduinoConnectionSettingsHelpDkal
            // 
            this.lblArduinoConnectionSettingsHelpDkal.AutoSize = true;
            this.lblArduinoConnectionSettingsHelpDkal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblArduinoConnectionSettingsHelpDkal.Location = new System.Drawing.Point(504, 0);
            this.lblArduinoConnectionSettingsHelpDkal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArduinoConnectionSettingsHelpDkal.Name = "lblArduinoConnectionSettingsHelpDkal";
            this.lblArduinoConnectionSettingsHelpDkal.Size = new System.Drawing.Size(14, 16);
            this.lblArduinoConnectionSettingsHelpDkal.TabIndex = 10;
            this.lblArduinoConnectionSettingsHelpDkal.Text = "?";
            // 
            // btnScanPortsDkal
            // 
            this.btnScanPortsDkal.Location = new System.Drawing.Point(12, 23);
            this.btnScanPortsDkal.Margin = new System.Windows.Forms.Padding(4);
            this.btnScanPortsDkal.Name = "btnScanPortsDkal";
            this.btnScanPortsDkal.Size = new System.Drawing.Size(171, 28);
            this.btnScanPortsDkal.TabIndex = 3;
            this.btnScanPortsDkal.Text = "Scan USB ports";
            this.btnScanPortsDkal.UseVisualStyleBackColor = true;
            this.btnScanPortsDkal.Click += new System.EventHandler(this.btnScanPortsDkal_Click);
            // 
            // cbbSerialPortsDkal
            // 
            this.cbbSerialPortsDkal.FormattingEnabled = true;
            this.cbbSerialPortsDkal.Location = new System.Drawing.Point(55, 63);
            this.cbbSerialPortsDkal.Margin = new System.Windows.Forms.Padding(4);
            this.cbbSerialPortsDkal.Name = "cbbSerialPortsDkal";
            this.cbbSerialPortsDkal.Size = new System.Drawing.Size(123, 24);
            this.cbbSerialPortsDkal.TabIndex = 2;
            this.cbbSerialPortsDkal.SelectedIndexChanged += new System.EventHandler(this.cbbSerialPortsDkal_SelectedIndexChanged);
            // 
            // btnSerialPortOpenDkal
            // 
            this.btnSerialPortOpenDkal.Enabled = false;
            this.btnSerialPortOpenDkal.Location = new System.Drawing.Point(16, 96);
            this.btnSerialPortOpenDkal.Margin = new System.Windows.Forms.Padding(4);
            this.btnSerialPortOpenDkal.Name = "btnSerialPortOpenDkal";
            this.btnSerialPortOpenDkal.Size = new System.Drawing.Size(167, 28);
            this.btnSerialPortOpenDkal.TabIndex = 6;
            this.btnSerialPortOpenDkal.Text = "Open port";
            this.btnSerialPortOpenDkal.UseVisualStyleBackColor = true;
            this.btnSerialPortOpenDkal.Click += new System.EventHandler(this.btnSerialPortOpenDkal_Click);
            // 
            // gbxLoggingDkal
            // 
            this.gbxLoggingDkal.Controls.Add(this.rtbLogging);
            this.gbxLoggingDkal.Location = new System.Drawing.Point(215, 15);
            this.gbxLoggingDkal.Margin = new System.Windows.Forms.Padding(4);
            this.gbxLoggingDkal.Name = "gbxLoggingDkal";
            this.gbxLoggingDkal.Padding = new System.Windows.Forms.Padding(4);
            this.gbxLoggingDkal.Size = new System.Drawing.Size(557, 133);
            this.gbxLoggingDkal.TabIndex = 29;
            this.gbxLoggingDkal.TabStop = false;
            this.gbxLoggingDkal.Text = "Logging: double click to clear";
            // 
            // rtbLogging
            // 
            this.rtbLogging.BackColor = System.Drawing.Color.White;
            this.rtbLogging.Location = new System.Drawing.Point(8, 23);
            this.rtbLogging.Margin = new System.Windows.Forms.Padding(4);
            this.rtbLogging.Name = "rtbLogging";
            this.rtbLogging.Size = new System.Drawing.Size(540, 100);
            this.rtbLogging.TabIndex = 0;
            this.rtbLogging.Text = "";
            this.rtbLogging.WordWrap = false;
            this.rtbLogging.TextChanged += new System.EventHandler(this.rtbLogging_TextChanged);
            // 
            // serialPortArduinoConnection
            // 
            this.serialPortArduinoConnection.BaudRate = 115200;
            this.serialPortArduinoConnection.DtrEnable = true;
            this.serialPortArduinoConnection.ReadBufferSize = 19200;
            this.serialPortArduinoConnection.ReadTimeout = 5000;
            this.serialPortArduinoConnection.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortArduinoConnection_DataReceived);
            // 
            // gbxSend
            // 
            this.gbxSend.Controls.Add(this.btnPossibleMessages);
            this.gbxSend.Controls.Add(this.btnZeroAll);
            this.gbxSend.Controls.Add(this.btnSendMessage);
            this.gbxSend.Controls.Add(this.txbSendMessage);
            this.gbxSend.Location = new System.Drawing.Point(16, 155);
            this.gbxSend.Margin = new System.Windows.Forms.Padding(4);
            this.gbxSend.Name = "gbxSend";
            this.gbxSend.Padding = new System.Windows.Forms.Padding(4);
            this.gbxSend.Size = new System.Drawing.Size(756, 57);
            this.gbxSend.TabIndex = 30;
            this.gbxSend.TabStop = false;
            this.gbxSend.Text = "Send message";
            // 
            // btnPossibleMessages
            // 
            this.btnPossibleMessages.Location = new System.Drawing.Point(368, 18);
            this.btnPossibleMessages.Margin = new System.Windows.Forms.Padding(4);
            this.btnPossibleMessages.Name = "btnPossibleMessages";
            this.btnPossibleMessages.Size = new System.Drawing.Size(184, 30);
            this.btnPossibleMessages.TabIndex = 3;
            this.btnPossibleMessages.Text = "Options";
            this.btnPossibleMessages.UseVisualStyleBackColor = true;
            this.btnPossibleMessages.Click += new System.EventHandler(this.btnPossibleMessages_Click);
            // 
            // btnZeroAll
            // 
            this.btnZeroAll.Enabled = false;
            this.btnZeroAll.Location = new System.Drawing.Point(560, 18);
            this.btnZeroAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnZeroAll.Name = "btnZeroAll";
            this.btnZeroAll.Size = new System.Drawing.Size(184, 30);
            this.btnZeroAll.TabIndex = 2;
            this.btnZeroAll.Text = "Zero all";
            this.btnZeroAll.UseVisualStyleBackColor = true;
            this.btnZeroAll.Click += new System.EventHandler(this.btnZeroAll_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Enabled = false;
            this.btnSendMessage.Location = new System.Drawing.Point(16, 20);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(184, 30);
            this.btnSendMessage.TabIndex = 1;
            this.btnSendMessage.Text = "Send";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // txbSendMessage
            // 
            this.txbSendMessage.Enabled = false;
            this.txbSendMessage.Location = new System.Drawing.Point(208, 23);
            this.txbSendMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txbSendMessage.Name = "txbSendMessage";
            this.txbSendMessage.Size = new System.Drawing.Size(132, 22);
            this.txbSendMessage.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 226);
            this.Controls.Add(this.gbxSend);
            this.Controls.Add(this.gbxConnectionDkal);
            this.Controls.Add(this.gbxLoggingDkal);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbxConnectionDkal.ResumeLayout(false);
            this.gbxConnectionDkal.PerformLayout();
            this.gbxLoggingDkal.ResumeLayout(false);
            this.gbxSend.ResumeLayout(false);
            this.gbxSend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxConnectionDkal;
        private System.Windows.Forms.Label lblPortText;
        private System.Windows.Forms.Label lblArduinoConnectionSettingsHelpDkal;
        private System.Windows.Forms.Button btnScanPortsDkal;
        private System.Windows.Forms.ComboBox cbbSerialPortsDkal;
        private System.Windows.Forms.Button btnSerialPortOpenDkal;
        private System.Windows.Forms.GroupBox gbxLoggingDkal;
        private System.Windows.Forms.RichTextBox rtbLogging;
        private System.IO.Ports.SerialPort serialPortArduinoConnection;
        private System.Windows.Forms.GroupBox gbxSend;
        private System.Windows.Forms.Button btnPossibleMessages;
        private System.Windows.Forms.Button btnZeroAll;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.TextBox txbSendMessage;
    }
}