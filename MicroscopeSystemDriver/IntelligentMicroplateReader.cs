using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace MicroscopeSystemDriver
{


    public class IntelligentMicroplateReader
    {

        public string SET_MICROSCOPE_POSITION = "S INPUT_OFFSET";

        public double micPosZ;      // Helper variable for storing Z Position

        private Communication_RS232 MicroscopeModule;

        public double X { get; }
        public double Y { get; }

        public double Ymin { get; set; }
        public double Ymax { get; set; }

        public double Xmin { get; set; }
        public double Xmax { get; set; }

        public double Z { get; }



        public IntelligentMicroplateReader(Communication_RS232 port)
        {
            MicroscopeModule = port;
        }


        public double iMicPosX
        {
            get { return X; }
            set
            {
                //imic.SetXPos(value);
                //xmlnode = xml_microwellplate.SelectSingleNode(string.Format("/MICROWELLPLATE/Position/{0}_{1}/x", parameter[0], parameter[1]));
                //xmlnode.FirstChild.Value = Convert.ToString(value, NumberFormatInfo.InvariantInfo);
            }
        }

        public double iMicPosY
        {
            get { return Y; }
            set
            {
                //imic.SetYPos(value);
                //xmlnode = xml_microwellplate.SelectSingleNode(string.Format("/MICROWELLPLATE/Position/{0}_{1}/y", parameter[0], parameter[1]));
                //xmlnode.FirstChild.Value = Convert.ToString(value, NumberFormatInfo.InvariantInfo);
            }
        }

        public double iMicPosZ0
        {
            get { return Z; }
            set
            {
                //imic.SetZPos(value);
                //xmlnode = xml_microwellplate.SelectSingleNode(string.Format("/MICROWELLPLATE/Position/{0}_{1}/z0", parameter[0], parameter[1]));
                //xmlnode.FirstChild.Value = Convert.ToString(value, NumberFormatInfo.InvariantInfo);
            }
        }

    }
}
