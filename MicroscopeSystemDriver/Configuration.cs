/*-----------------------------------------------------------------------------------------------*
 * Class to configurate the device driver                                                        *
 *                                                                                               *
 * Author: Dipl.-Ing. Franz Demmel                                                               *
 * Email:  demmel@tum.de                                                                         *
 * last update: 06.04.2011                                                                       *
 *-----------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Shz.Imros.Utils; // for SerialPortConfiguration

namespace MicroscopeSystemDriver
{
    public class Configuration      // ATTENTION: class must be "public" !!!
    {


        /// <summary>
        /// The settings of the COM-port, where the incubator is connected.
        /// </summary>
        public SerialPortConfiguration xyTableComport { get; set; }
        public SerialPortConfiguration MicroscopeComport { get; set; }

        public Configuration()      // constructor -> fill here the structure with the sensible defaults
        {
            xyTableComport = new SerialPortConfiguration();
            MicroscopeComport = new SerialPortConfiguration();
            
        } 

    }
}
