using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Shz.Imros.Utils;
using System.Xml;                       // XML file handling


namespace MicroscopeSystemDriver
{


    public class IntelligentMicroplateReader
    {

        private Microscope imic;
        //private xyTable xyTable;
        //private pH_mini phmini;
        private SerialPortConfiguration comport_microscope;
        //private SerialPortConfiguration comport_xyTable;
        private SerialPortConfiguration comport_phmini;

        public double micPosZ;      // Helper variable for storing Z Position

        //private Communication_RS232 MicroscopeModule;
        //private Communication_RS232 xyTableModule;

        public double X { get; }
        public double Y { get; }

        public double Ymin { get; set; }
        public double Ymax { get; set; }

        public double Xmin { get; set; }
        public double Xmax { get; set; }

        public double Z { get; }

        public double Zmin { get; set; }
        public double Zmax { get; set; }



        public IntelligentMicroplateReader()
        {

            //--- open xml files ---

            //xml_sequences = new XmlDocument();                  // sequences of the automatic mode
            //xml_microwellplate = new XmlDocument();             // markers (positions) on the microwellplate


            //--- iMIC ---
            System.Diagnostics.Debug.WriteLine("Init iMic");
            imic = new Microscope(comport_microscope);                                                          // create iMIC object
            /*
            imic.OpenEvent += new OpenEventHandler(iMIC_ReadyEvent);                    // register handler for "iMIC is open and initialized" event
            setpositionseventhandler = new SetPositionsEventHandler(iMIC_CmdDoneEvent); // init setpositionseventhandler variable
            imic.SetPositionsEvent += setpositionseventhandler;                         // register handler for "iMIC cmd executed" event
            setz0poseventhandler = new SetZ0PosEventHandler(positioning);               // init setz0poseventhandler variable
            Z0FindFocusEventHandler = new SetZ0PosEventHandler(FindFocusStatemachine);  // this event will be fired, when the iMIC has done the Z0 positioning (FindFocus)
            Z1AutofocusEventHandler = new SetZ1PosEventHandler(AutofocusStatemachine);  // this event will be fired, when the iMIC has reached the desired Z1 position -> then running the autofocus statemachine


            //--- pH-1 mini ---
            phmini = new pH_mini();                 // create pH-1 mini object
            phmini.InitFinishedEvent += new PreSens.InitFinishedEventHandler(phmini_InitFinishedEvent);                     // register event handler
            phmini.MeasurementCompletedEvent += new MeasurementCompletedEventHandler(pHmini_MeasurementCompletedEvent);     // register event handler


            //--- create configuration objects ---
            calibrationdata = new CalibrationData();
            microscope_config = new MicroscopeConfiguration();
            autofocus_config = new AutofocusConfiguration();
            datapath = new DataPath();
            pHrates = new MetabolicRates();
            pO2rates = new MetabolicRates();


            //--- linear regression ---
            pH_counter = 1;
            pH_point1 = 1;
            pH_point2 = 7;
            pO2_counter = 1;
            pO2_point1 = 1;
            pO2_point2 = 7;

            first_measurement = DateTime.MinValue;      // reset this datetime variable to 1. Januar 1, 00:00:00.0000000
            */
        }

        #region Parameter encapsulation

        public SerialPortConfiguration MicroscopeComport
        {
            get { System.Diagnostics.Debug.WriteLine("Der Comport wird geholt"); return comport_microscope; }
            set { System.Diagnostics.Debug.WriteLine("HIER IST DER FEEEEEEEEEEEEEEEEEEEEEEEEEEEEEHLER!! - >> ZU spät"); comport_microscope = value; }
        }

        public SerialPortConfiguration OpticalDeviceComport
        {
            get { return comport_phmini; }
            set { comport_phmini = value; }
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

        public double iMicPosZ
        {
            get { return Z; }
            set
            {
                System.Diagnostics.Debug.WriteLine("Jetzt wird die Z Position gesetzt");
                imic.SetZPos(value);
                //xmlnode = xml_microwellplate.SelectSingleNode(string.Format("/MICROWELLPLATE/Position/{0}_{1}/z0", parameter[0], parameter[1]));
                //xmlnode.FirstChild.Value = Convert.ToString(value, NumberFormatInfo.InvariantInfo);
            }
        }

        public void iMicInit()
        {
            imic.Init();
            System.Diagnostics.Debug.WriteLine("iMic wird initialisiert");
        }
        public void iMicClose()
        {
            System.Diagnostics.Debug.WriteLine("iMic wird geschlossen");
            imic.Close();
        }

        #endregion

    }
}
