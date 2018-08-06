/*-----------------------------------------------------------------------------------------------*
 * A class to handle with the Communication with RS232                                           *
 *                                                                                               *
 * Author: Ing. Alexander Thees                                                                  *
 * Email:  alexander.thees@gmx.de                                                                *
 * last update: 25.07.2018                                                                       *
 *-----------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Globalization;                     // dot vs. semincolon
using System.IO;                                // file handling
using System.IO.Ports;                          // serial port
using System.Threading;                         // multi threading
using System.Text;

namespace MicroscopeSystemDriver
{

    #region Event delegates
    public delegate void PortRecievedMessageEventHandler();     // declare delegate for the "temperature measured" event
    #endregion

    public class Communication_RS232
    {

        #region Properties

        #region property declaration

        private SerialPort rs232;
        private byte[] rs232buffer = new byte[255];                     // receive buffer -> serial port

        private string message;             // rs232 Message

        #endregion

        #region property encapsulation

        public string Message
        {
            get { return message; }
        }

        #endregion

        #endregion

        #region Methods

        #region Method: Open
        /// <summary>
        /// Open a connection to the incubator via a serial port.
        /// </summary>
        /// <param name="port">COM-Port where the incubator is connected, e.g. COM1</param>
        /// <param name="baudrate">Baudrate of the transmission, e.g. 9600</param>
        public void Open(string port, int baudrate)
        {
            rs232 = new SerialPort();
            rs232.DataReceived += new SerialDataReceivedEventHandler(rs232_DataReceived);

            rs232.PortName = port;              // set comport
            rs232.BaudRate = baudrate;          // set baudrate

            try
            {
                rs232.Open();                   // open serial port
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }
        #endregion

        #region Method: Close
        /// <summary>
        /// Close a existing connection to the incubator.
        /// </summary>
        public void Close()
        {
            try
            {
                rs232.Close();                  // close serial port
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Method: isOpen
        /// <summary>
        /// Check if Incubator ComPort via serialport is open
        /// </summary>
        
        public bool isOpen()
        {
            if (rs232.IsOpen) {
                return true;
            }
            else
            {
                return false;
            }


        }
        #endregion

        #region Method: Write
        /// <summary>
        /// Write the data to the SerialPort
        /// </summary>

        public void Write(string text)
        {
            if (rs232.IsOpen)
            {
                rs232.DiscardInBuffer();
                rs232.WriteLine(text);
            }
        }
        #endregion

        #endregion

        #region Events

        #region event declaration
        public event PortRecievedMessageEventHandler PortRecievedMessageEvent;      // temperature measurement has been finished
        #endregion

        #region Event: RS232 data received
        /// <summary>
        /// RS232 data received event handler -> readout and save the incubator temperature.
        /// </summary>
        private void rs232_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            message = rs232.ReadExisting();

            System.Diagnostics.Debug.WriteLine(Message);

            if (PortRecievedMessageEvent != null)   // event is handled in the calling thread
                PortRecievedMessageEvent();         // fire the event
    }
        #endregion

        #endregion

    }
}
