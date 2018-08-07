using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MicroscopeSystemDriver;
using Shz.Imros.Utils;

namespace MicroscopeSystemDriver
{

    class Microscope
    {
        private Communication_RS232 port;
        private SerialPortConfiguration configMic;


        public Microscope(SerialPortConfiguration config)
        {
            System.Diagnostics.Debug.WriteLine("Konstruktor iMic1");
            port = new Communication_RS232();
            System.Diagnostics.Debug.WriteLine("Konstruktor iMic2");
            configMic = config;
            System.Diagnostics.Debug.WriteLine("Konstruktor iMic3");
            System.Diagnostics.Debug.WriteLine("Konstruktor iMic4");
            Open();
            System.Diagnostics.Debug.WriteLine("Konstruktor iMic5");

        }

        private void Open()
        {
            try
            {
                port.Open(configMic.PortName, configMic.BaudRate);
                
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
            }
            if (port.isOpen()) { System.Diagnostics.Debug.WriteLine("Der Port ist OFFEN "); }
            else { System.Diagnostics.Debug.WriteLine("Der Port ist GESCHLOSSEN "); }


        }

        public void Close()
        {
            port.Close();
        }

        public void Init()
        {
            port.Write("C");
        }

        public void GetState(){

        }

        public void GetZPos()
        {
            port.Write("G INPUT_OFFSET");
        }

        public void SetZPos(double z0)
        {
            port.Write("S INPUT_OFFSET " + z0);
        }
    }
}
