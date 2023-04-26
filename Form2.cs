using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiecesBeingPiecesLesson;

namespace TicTacChess
{
    public partial class Form2 : Form
    {
        private delegate void SafeCallDelegate();
        String receivedString = "";
        String receivedStringLast = "";

        string sendCommando = "";

        Form1 mainform = new Form1();

        public Form2()
        {
            InitializeComponent();
        }

        #region Setup connection
        private void btnScanPortsDkal_Click(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            string m_portWithOutLastCharacter;
            rtbLogging.Clear();

            //Close the connection if there already is one open
            if (serialPortArduinoConnection.IsOpen)
            {
                PrintLn("Connection was open. Closing..", "B");
                serialPortArduinoConnection.Close();
            }
            cbbSerialPortsDkal.Items.Clear();

            //Each port that is connected wil be shown in the combobox
            foreach (String port in ports)
            {
                m_portWithOutLastCharacter = port;

                cbbSerialPortsDkal.Items.Add(m_portWithOutLastCharacter);
                PrintLn("Found port:" + m_portWithOutLastCharacter.ToString(), "W");
            }
        }

        private void cbbSerialPortsDkal_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPortArduinoConnection.PortName = cbbSerialPortsDkal.Text;
            PrintLn("Port selected: " + serialPortArduinoConnection.PortName, "W");
            PrintLn("Default baudrate: " + serialPortArduinoConnection.BaudRate.ToString(), "W");
            btnSerialPortOpenDkal.Enabled = true;
        }

        private void btnSerialPortOpenDkal_Click(object sender, EventArgs e)
        {
            //This is to settup the default baudrate
            serialPortArduinoConnection.BaudRate = Convert.ToInt32(115200);
            PrintLn("Selected baudrate: " + serialPortArduinoConnection.BaudRate.ToString(), "W");

            //If there is no open connection the connection will be opened
            if (!serialPortArduinoConnection.IsOpen)
            {
                try
                {
                    serialPortArduinoConnection.Open();

                    Thread.Sleep(200); //wait 100 ms to open port

                    this.Text = "Main - using com port: " + cbbSerialPortsDkal.Text;
                    PrintLn("Using com port: " + cbbSerialPortsDkal.Text, "W");
                    btnSendMessage.Enabled = true;
                    txbSendMessage.Enabled = true;
                    btnZeroAll.Enabled = true;
                }
                catch
                {
                    PrintLn("ERROR: Please make sure that the correct port was selected, and the device, plugged in.", "R");
                }
            }
        }
        /// <summary>
        /// Printing message to the Richtextbox in a choosable color
        /// </summary>
        /// <param name="a_text"></param>
        /// <param name="a_color"></param>
        public void PrintLn(string a_text, string a_color)
        {
            string m_color;

            m_color = a_color.ToUpper();//eliminate a possible problem of the letter casing

            switch (a_color)
            {
                case "R": rtbLogging.SelectionColor = Color.Red; break;
                case "G": rtbLogging.SelectionColor = Color.Green; break;
                case "B": rtbLogging.SelectionColor = Color.Blue; break;
                case "Y": rtbLogging.SelectionColor = Color.Orange; break;
                default: rtbLogging.SelectionColor = Color.Black; break;
            }

            rtbLogging.AppendText(a_text + "\n");
            //This scrolls always to the last message
            rtbLogging.ScrollToCaret();
        }

        // Function to write commands to the Arduino
        public void WriteArduino(string a_action)
        {
            int m_length = a_action.Length;
            char[] m_data = new char[m_length];

            String m_carriageReturn = "\r";
            char[] m_cr = new char[2];

            String m_newLine = "\n";
            char[] m_nl = new char[2];

            for (int m_index = 0; m_index < m_length; m_index++)
            {
                m_data[m_index] = Convert.ToChar(a_action[m_index]);
            }

            for (int m_index = 0; m_index < 1; m_index++)
            {
                m_cr[m_index] = Convert.ToChar(m_carriageReturn[m_index]);
            }

            for (int m_index = 0; m_index < 1; m_index++)
            {
                m_nl[m_index] = Convert.ToChar(m_newLine[m_index]);
            }

            if (serialPortArduinoConnection.IsOpen == true)
            {
                serialPortArduinoConnection.Write(m_data, 0, m_length);

                PrintLn("Transmitted message from Main: " + a_action, "Y");
            }
            else
            {
                PrintLn("ERROR. Please make sure that the correct port was selected, and the device, plugged in.", "R");
            }
        }

        private void serialPortArduinoConnection_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            HandleReceivedData();
        }

        private void HandleReceivedData()
        {
            if (serialPortArduinoConnection.IsOpen)
            {
                try
                {
                    //Check if this is the same thread
                    if (rtbLogging.InvokeRequired)
                    {
                        var d = new SafeCallDelegate(HandleReceivedData);
                        //Allow changes in this thread from another thread
                        rtbLogging.Invoke(d, new object[] { });
                    }
                    else
                    {
                        receivedString = serialPortArduinoConnection.ReadLine();
                        PrintLn(receivedString, "G");
                    }
                }
                catch
                {
                    PrintLn("ERROR: Time out of: " + serialPortArduinoConnection.ReadTimeout.ToString() + "ms. Data read failed", "R");
                }
            }
        }
        public string ReadArduino()
        {
            if (receivedString != receivedStringLast)
            {
                PrintLn(receivedString, "G");
            }
            receivedStringLast = receivedString;

            return receivedString;
        }
        #endregion

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            sendCommando = txbSendMessage.Text;
            WriteArduino(sendCommando);
        }

        private void btnPossibleMessages_Click(object sender, EventArgs e)
        {
            //These are all the string messages you can send. The 0000 should NOT become higher than 1500!
            //To use the suction you first have to turn on the compressor: CS:1, SS:1, move to location, SS:0, CS:0
            MessageBox.Show($"VS:0000 == Vertical" +
                            $"\nHS:0000 == Horizontal" +
                            $"\nRS:0000 == Rotation" +
                            $"\nCS:0 == Compressor OFF / CS:1 Compressor ON" +
                            $"\nSS:0 == Suction OFF / SS:1 Suction ON" +
                            $"\n\nZS:0 == Zero all" +
                            $"\nZS:1 == Zero Vertical" +
                            $"\nZS:2 == Zero Horizontal" +
                            $"\nZS:3 == Zero Rotation"
                            , $"The messages you can send to the arduino");
        }

        private void btnZeroAll_Click(object sender, EventArgs e)
        {
            WriteArduino("ZS:0");
        }

        private void rtbLogging_TextChanged(object sender, EventArgs e)
        {
            // Check for the last command sent to the Arduino
            int totalLines = rtbLogging.Lines.Length;
            string lastLine = rtbLogging.Lines[totalLines - 2];
            if (lastLine.Contains("VS:Ready"))
            {
                // Vertical axis is ready
                mainform.NextArduinoStep();
            }
            if (lastLine.Contains("HS:Ready"))
            {
                // Horizontal axis is ready
                mainform.NextArduinoStep();
            }
            if (lastLine.Contains("RS:Ready"))
            {
                // Rotational axis is ready
                mainform.NextArduinoStep();
            }
            if (lastLine.Contains("CS:Ready"))
            {
                // Compressor is ready
                mainform.NextArduinoStep();
            }
            if (lastLine.Contains("SS:Ready"))
            {
                // Suction cup is ready
                mainform.NextArduinoStep();
            }
            if (lastLine.Contains("Ready-LT"))
            {
                // Completely zeroed out
                mainform.NextArduinoStep();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Left = mainform.Right + 10;
            this.Top = mainform.Top;
        }

    }
}
