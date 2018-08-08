/*-----------------------------------------------------------------------------------------------*
 * Incubator driver for IMROS -> temperature measurement                                         *
 *                                                                                               *
 * Author: Dipl.-Ing. Franz Demmel                                                               *
 * Email:  demmel@tum.de                                                                         *
 * last update: 04.05.2011                                                                       *
 *-----------------------------------------------------------------------------------------------*/

using System;
using System.AddIn;
using System.Data;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using Shz.Imros.DeviceDriver;
using Shz.Imros.Utils;
using System.Threading;



namespace MicroscopeSystemDriver
{

    #region struct definitions

    struct IncubatorResult              // structure to handle sensor data
    {
        public DateTime Timestamp;      // date and time
        public double Temperature;      // temperature of the incubator
    }

    #endregion


    [AddIn("MicroscopeSystemDriver", Version = "2.0.0.0")]                             // The AddInAttribute identifies this pipeline segment as an add-in.
    public class MicroscopeSystemDriver : DeviceDriverBase                             // ATTENTION: class must be "public" !!!
    {

        #region Properties

        //private static Communication_RS232 xyTableModule;                              // define the Rs232 xyTableModule Module
        //private static Communication_RS232 MicroscopeModule;                           // define the Rs232 Microscope Module

        private IntelligentMicroplateReader imr;// = new IntelligentMicroplateReader(); // Helper Class to Store Microscope Data


        private const string _TemperatureSensorName = "Temperature";            // define the sensors of the new device
        private string[] _sensors = new string[] { _TemperatureSensorName };

        Configuration Config = null;                                            // holds the driver configuration

        SynchronizedQueue<IncubatorResult> IncubatorResultQueue = null;         // define a queue to transmit sensor data to IMROS

        #endregion

        #region Constructor
        public MicroscopeSystemDriver()
        {
            imr = new IntelligentMicroplateReader();
        }
        #endregion

        #region Method: Init
        /// <summary>
        /// Initialization of the device driver
        /// It's guaranteed, that this is the first method called on the newly created driver object.
        /// </summary>
        /// <param name="configReader">A reader to the driver's configuration section</param>
        public override void Init(XmlReader configReader)
        {
            

            System.Diagnostics.Debug.WriteLine("Die Init wird aufgerufen");
            // try to deserialize the xml fragment into the configuration object
            // The default values are used in case of a missing config section
            Config = (Configuration)configReader.ReadFragmentAs(typeof(Configuration));

            
            imr.MicroscopeComport = Config.MicroscopeComport;       // configurate the comport of the microscope

            

        }
        #endregion

        #region Method: Setup
        /// <summary>
        /// The setup is called before any actions are executed.
        /// It will never be called from the device file editor, but only from the experiment runner. 
        /// </summary>
        public override void Setup()
        {
            // create and setup the XY Table
            //xyTableModule = new Communication_RS232();
            //xyTableModule.Open(Config.xyTableComport.PortName, Config.xyTableComport.BaudRate);

            // create and setup the Microscope
            //MicroscopeModule = new Communication_RS232();
            //MicroscopeModule.Open(Config.MicroscopeComport.PortName, Config.MicroscopeComport.BaudRate);
            //MicroscopeModule.PortRecievedMessageEvent += new PortRecievedMessageEventHandler(MessageRecievedEvent);
            
            // create a queue to handle the temperature data of the incubator
            IncubatorResultQueue = new SynchronizedQueue<IncubatorResult>();
        }
        #endregion

        #region Method: Shutdown
        /// <summary>
        /// This method will be called only from the experiment runner once the experiment has terminated.
        /// </summary>
        public override void Shutdown()
        {

            //xyTableModule.Close();              // close the connection to the xyTable
            //MicroscopeModule.Close();

        }
        #endregion

        #region Method: Dispose
        /// <summary>
        /// This method is used to perform general clean-up.
        /// Its guaranteed to be the last method called on the driver. 
        /// </summary>
        public override void Dispose()
        {


        }
        #endregion

        #region Method: PerformAction
        /// <summary>
        /// This method is called to perform the actual actions on the controlled device.
        /// </summary>
        /// <param name="action">The name of the action to perform (see the experiment file)</param>
        /// <param name="parameter">The action's parameter (see the experiment file)</param>
        protected override void PerformAction(string action, OrderedStringPairCollection parameter)
        {
            switch (action)
            {
                case "InitializeMicroscope":

                    break;
                case "BlueSignallight":
  
                    break;

                default:
                    throw new Exception("This action is not implemented: " + action);
            }
        }
        #endregion

        #region Property: Sensors
        /// <summary>
        /// This returns an array of strings with the sensor names implemented by this driver.
        /// </summary>
        public override string[] Sensors
        {
            get { return _sensors; }
        }
        #endregion

        #region Method: GetMetaData
        /// <summary>
        /// This method has to return the meta data or the sensor.
        /// </summary>
        /// <param name="sensorName">The name of a sensor as included in <see cref="Sensors"/></param>
        /// <returns>Meta data for the sensor</returns>
        /// <remarks>
        /// The meta data is stored in the result file and can be queued without decompressing the actual sensor data.
        /// It's mainly used by the data visualization.
        /// The field "Indicator" should hold a key to choose the right visualization backend.
        /// Using "Timebase" (either "common" or "per well") and "Wells" (24 or 96) a generic backend can be used.
        /// It's good practice to provide at least these three fields.
        /// </remarks>
        public override OrderedStringPairCollection GetMetaData(string sensor)
        {
            CheckSensor(sensor);                                            // this breaks if the sensor is not defined

            OrderedStringPairCollection metaData = new OrderedStringPairCollection();

            switch (sensor)
            {
                case _TemperatureSensorName:
                    //metaData.Add("Indicator", "incubator temperature");     // name of the sensor
                    break;

                default:
                    break;
            }

            return metaData;
        }
        #endregion

        #region Method: CreateEmptyDataSet
        /// <summary>
        /// This method should return an empty data set with the schema of the sensor's data.
        /// </summary>
        /// <param name="sensor">The name if the sensor in question</param>
        /// <returns>An empty data set with the sensor specific schema</returns>
        public override DataSet CreateEmptyDataSet(string SensorName)
        {
            CheckSensor(SensorName); // this breaks if the sensor is not defined

            DataSet emptySet = new DataSet(SensorName);
            DataTable table;

            switch (SensorName)
            {
                case _TemperatureSensorName:
                    table = emptySet.Tables.Add(SensorName);            // create only one table, using the sensor name as table name
                    table.Columns.Add("Timestamp", typeof(DateTime));   // every table needs a timestamp
                    table.Columns.Add("Temperature", typeof(double));   // save the temperature in a colum of the type "double"
                    break;

                default:
                    break;
            }

            return emptySet;
        }
        #endregion

        #region Method: GetPendingResults
        /// <summary>
        /// This method transmits the available sensor data to IMROS
        /// Since it will be called from a different thread then where <see cref="PerformAction"/> is executed, you need to protect the access to your data cache!
        /// </summary>
        /// <param name="sensorName">The name if the sensor in question</param>
        /// <returns>The result data for the sensor or null, if there is no data</returns>
        public override DataSet GetPendingResults(string sensorName)
        {
            CheckSensor(sensorName);                        // this breaks if the sensor is not defined

            switch (sensorName)
            {

                case _TemperatureSensorName:
                    if (IncubatorResultQueue.Count == 0)
                        return null;                        // no data available
                    else
                        return GetIncubatorResults();       // new data is available -> transmit it to IMROS
                default:
                    throw new ArgumentException("Invalid sensor name");
            }
        }
        #endregion
        
        #region Method: GetIncubatorResults
        /// <summary>
        /// Little helper method to transmit the available sensor data to IMROS
        /// </summary>
        private DataSet GetIncubatorResults()
        {
            DataSet resultSet = CreateEmptyDataSet(_TemperatureSensorName);     // create a dataset, which is defined in the CreateEmptyDataSet()

            while (IncubatorResultQueue.Count != 0)
            {
                IncubatorResult result = IncubatorResultQueue.Dequeue();        // read results from the queue

                DataTable resultTable = resultSet.Tables["Temperature"];        // create a new data table with the sensor name (here "Temperature")
                resultTable.Rows.Add(result.Timestamp, result.Temperature);     // save the incubator results in the data table
            }

            return resultSet;
        }
        #endregion
        

        #region Event: 
        /// <summary>
        /// This event will be fired, when new sensor data can be read out from the incubator
        /// </summary>
        void MessageRecievedEvent()
        {
            /*
            IncubatorResult result;
            result.Timestamp = DateTime.UtcNow;             // save the current UTC time
            result.Temperature = xyTableModule.Message;     // readout the current incubator temperature

            IncubatorResultQueue.Enqueue(result);           // save the data in the queue
            */
            //System.Diagnostics.Debug.WriteLine( this.Message );
        }
        #endregion

        #region Method: Configuration
        /// <summary>
        /// Shows the dialog to configurate the device driver
        /// </summary>
        /// <returns>True if some settings were changed, otherwise false</returns>
        public override bool Configure()
        {
            System.Diagnostics.Debug.WriteLine("Der Dialog wird geöffnet");
            ConfigurationDialog dialog = new ConfigurationDialog(Config, imr);

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                // NewConfigurationWriter() creates an XmlWriter to store the settings back in the ImrMetaFile.
                using (XmlWriter writer = NewConfigurationWriter())
                    writer.WriteFragmentFor(Config); // use xml serialization to write the configuration
                return true;
            }
            else
                return false;
        }
        #endregion

    }
}
