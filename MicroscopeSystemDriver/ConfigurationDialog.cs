﻿/*-----------------------------------------------------------------------------------------------*
 * Dialog for the driver configuration                                                           *
 *                                                                                               *
 * Author: Dipl.-Ing. Franz Demmel                                                               *
 * Email:  demmel@tum.de                                                                         *
 * last update: 06.04.2011                                                                       *
 *-----------------------------------------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using MicroscopeSystemDriver;


namespace MicroscopeSystemDriver
{


    public partial class ConfigurationDialog : Form
    {

        IntelligentMicroplateReader imr;
        //Communication_RS232 PortMicroscope;
        Configuration config;


        public ConfigurationDialog(Configuration config, IntelligentMicroplateReader imr)
        {
            this.config = config;
            this.imr = imr;
            
            InitializeComponent();


            // setup data bindings to connect the config values to the GUI elements
            serialPortConfigurationControlTable.DataBindings.Add("SerialPortConfiguration", config, "PortSettingsTable");
            serialPortConfigurationControlMicroscopeModule.DataBindings.Add("SerialPortConfiguration", config, "PortSettingsMicroscope");

            //// create and setup the Microscope
            //PortMicroscope = new Communication_RS232();
            //PortMicroscope.Open(config.MicroscopeComport.PortName, config.MicroscopeComport.BaudRate);
            //PortMicroscope.PortRecievedMessageEvent += new PortRecievedMessageEventHandler(MessageRecievedEvent);


        }

        private void getXButton_Click(object sender, EventArgs e)
        {
            
        }

        private void getYButton_Click(object sender, EventArgs e)
        {

        }

        private void getZButton_Click(object sender, EventArgs e)
        {

            getZLabel.Text = imr.micPosZ.ToString();
        }

        private void setXButton_Click(object sender, EventArgs e)
        {
            
        }

        private void setYButton_Click(object sender, EventArgs e)
        {

        }

        private void setZButton_Click(object sender, EventArgs e)
        {
            imr.micPosZ = Convert.ToDouble(inputZCoordinate.Text);
            
            getZLabel.Text = imr.micPosZ.ToString();
            System.Diagnostics.Debug.WriteLine("S INPUT_OFFSET " + imr.iMicPosZ);
            //PortMicroscope.Write("S INPUT_OFFSET " + imr.micPosZ);
        }

        private void initXButton_Click(object sender, EventArgs e)
        {

        }

        private void initYButton_Click(object sender, EventArgs e)
        {

        }

        private void initZButton_Click(object sender, EventArgs e)
        {
            imr.iMicInit();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            imr.iMicClose();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            imr.iMicClose();
        }

        #region Event: Microscope Answering
        /// <summary>
        /// This event will be fired, when new sensor data can be read out from the incubator
        /// </summary>
        void MessageRecievedEvent()
        {

            System.Diagnostics.Debug.WriteLine("Es wurde etwas empfangen");
        }
        #endregion
    }
}


