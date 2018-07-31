namespace MicroscopeSystemDriver
{
    partial class ConfigurationDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationDialog));
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.serialPortGroupBoxTable = new System.Windows.Forms.GroupBox();
            this.serialPortConfigurationControlTable = new Shz.Imros.Utils.SerialPortConfigurationControl();
            this.getXButton = new System.Windows.Forms.Button();
            this.getYButton = new System.Windows.Forms.Button();
            this.getZButton = new System.Windows.Forms.Button();
            this.setXButton = new System.Windows.Forms.Button();
            this.setYButton = new System.Windows.Forms.Button();
            this.setZButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getXLabel = new System.Windows.Forms.Label();
            this.getYLabel = new System.Windows.Forms.Label();
            this.getZLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.inputZCoordinate = new System.Windows.Forms.TextBox();
            this.serialPortConfigurationControlMicroscopeModule = new Shz.Imros.Utils.SerialPortConfigurationControl();
            this.serialPortGroupBoxMicroscope = new System.Windows.Forms.GroupBox();
            this.initZButton = new System.Windows.Forms.Button();
            this.initYButton = new System.Windows.Forms.Button();
            this.initXButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.serialPortGroupBoxTable.SuspendLayout();
            this.serialPortGroupBoxMicroscope.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(670, 678);
            this.okButton.Margin = new System.Windows.Forms.Padding(6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(150, 44);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(832, 678);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 44);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Canel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // serialPortGroupBoxTable
            // 
            this.serialPortGroupBoxTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPortGroupBoxTable.Controls.Add(this.serialPortConfigurationControlTable);
            this.serialPortGroupBoxTable.Location = new System.Drawing.Point(24, 23);
            this.serialPortGroupBoxTable.Margin = new System.Windows.Forms.Padding(6);
            this.serialPortGroupBoxTable.Name = "serialPortGroupBoxTable";
            this.serialPortGroupBoxTable.Padding = new System.Windows.Forms.Padding(6);
            this.serialPortGroupBoxTable.Size = new System.Drawing.Size(958, 142);
            this.serialPortGroupBoxTable.TabIndex = 4;
            this.serialPortGroupBoxTable.TabStop = false;
            this.serialPortGroupBoxTable.Text = "Port for the Table";
            // 
            // serialPortConfigurationControlTable
            // 
            this.serialPortConfigurationControlTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPortConfigurationControlTable.Location = new System.Drawing.Point(14, 38);
            this.serialPortConfigurationControlTable.Margin = new System.Windows.Forms.Padding(12);
            this.serialPortConfigurationControlTable.Name = "serialPortConfigurationControlTable";
            this.serialPortConfigurationControlTable.Size = new System.Drawing.Size(932, 94);
            this.serialPortConfigurationControlTable.TabIndex = 0;
            // 
            // getXButton
            // 
            this.getXButton.Location = new System.Drawing.Point(24, 328);
            this.getXButton.Name = "getXButton";
            this.getXButton.Size = new System.Drawing.Size(113, 34);
            this.getXButton.TabIndex = 7;
            this.getXButton.Text = "get X";
            this.getXButton.UseVisualStyleBackColor = true;
            this.getXButton.Click += new System.EventHandler(this.getXButton_Click);
            // 
            // getYButton
            // 
            this.getYButton.Location = new System.Drawing.Point(24, 368);
            this.getYButton.Name = "getYButton";
            this.getYButton.Size = new System.Drawing.Size(113, 34);
            this.getYButton.TabIndex = 8;
            this.getYButton.Text = "get Y";
            this.getYButton.UseVisualStyleBackColor = true;
            this.getYButton.Click += new System.EventHandler(this.getYButton_Click);
            // 
            // getZButton
            // 
            this.getZButton.Location = new System.Drawing.Point(24, 408);
            this.getZButton.Name = "getZButton";
            this.getZButton.Size = new System.Drawing.Size(113, 34);
            this.getZButton.TabIndex = 9;
            this.getZButton.Text = "get Z";
            this.getZButton.UseVisualStyleBackColor = true;
            this.getZButton.Click += new System.EventHandler(this.getZButton_Click);
            // 
            // setXButton
            // 
            this.setXButton.Location = new System.Drawing.Point(231, 328);
            this.setXButton.Name = "setXButton";
            this.setXButton.Size = new System.Drawing.Size(113, 34);
            this.setXButton.TabIndex = 10;
            this.setXButton.Text = "set X";
            this.setXButton.UseVisualStyleBackColor = true;
            this.setXButton.Click += new System.EventHandler(this.setXButton_Click);
            // 
            // setYButton
            // 
            this.setYButton.Location = new System.Drawing.Point(231, 368);
            this.setYButton.Name = "setYButton";
            this.setYButton.Size = new System.Drawing.Size(113, 34);
            this.setYButton.TabIndex = 11;
            this.setYButton.Text = "set Y";
            this.setYButton.UseVisualStyleBackColor = true;
            this.setYButton.Click += new System.EventHandler(this.setYButton_Click);
            // 
            // setZButton
            // 
            this.setZButton.Location = new System.Drawing.Point(231, 408);
            this.setZButton.Name = "setZButton";
            this.setZButton.Size = new System.Drawing.Size(113, 34);
            this.setZButton.TabIndex = 12;
            this.setZButton.Text = "set Z";
            this.setZButton.UseVisualStyleBackColor = true;
            this.setZButton.Click += new System.EventHandler(this.setZButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // getXLabel
            // 
            this.getXLabel.AutoSize = true;
            this.getXLabel.Location = new System.Drawing.Point(143, 333);
            this.getXLabel.Name = "getXLabel";
            this.getXLabel.Size = new System.Drawing.Size(70, 25);
            this.getXLabel.TabIndex = 13;
            this.getXLabel.Text = "label2";
            // 
            // getYLabel
            // 
            this.getYLabel.AutoSize = true;
            this.getYLabel.Location = new System.Drawing.Point(143, 373);
            this.getYLabel.Name = "getYLabel";
            this.getYLabel.Size = new System.Drawing.Size(70, 25);
            this.getYLabel.TabIndex = 14;
            this.getYLabel.Text = "label3";
            // 
            // getZLabel
            // 
            this.getZLabel.AutoSize = true;
            this.getZLabel.Location = new System.Drawing.Point(143, 413);
            this.getZLabel.Name = "getZLabel";
            this.getZLabel.Size = new System.Drawing.Size(70, 25);
            this.getZLabel.TabIndex = 15;
            this.getZLabel.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 324);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 31);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(350, 367);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(268, 31);
            this.textBox2.TabIndex = 17;
            // 
            // inputZCoordinate
            // 
            this.inputZCoordinate.Location = new System.Drawing.Point(350, 407);
            this.inputZCoordinate.Name = "inputZCoordinate";
            this.inputZCoordinate.Size = new System.Drawing.Size(268, 31);
            this.inputZCoordinate.TabIndex = 18;
            // 
            // serialPortConfigurationControlMicroscopeModule
            // 
            this.serialPortConfigurationControlMicroscopeModule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPortConfigurationControlMicroscopeModule.Location = new System.Drawing.Point(14, 38);
            this.serialPortConfigurationControlMicroscopeModule.Margin = new System.Windows.Forms.Padding(12);
            this.serialPortConfigurationControlMicroscopeModule.Name = "serialPortConfigurationControlMicroscopeModule";
            this.serialPortConfigurationControlMicroscopeModule.Size = new System.Drawing.Size(932, 94);
            this.serialPortConfigurationControlMicroscopeModule.TabIndex = 0;
            // 
            // serialPortGroupBoxMicroscope
            // 
            this.serialPortGroupBoxMicroscope.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serialPortGroupBoxMicroscope.Controls.Add(this.serialPortConfigurationControlMicroscopeModule);
            this.serialPortGroupBoxMicroscope.Location = new System.Drawing.Point(24, 177);
            this.serialPortGroupBoxMicroscope.Margin = new System.Windows.Forms.Padding(6);
            this.serialPortGroupBoxMicroscope.Name = "serialPortGroupBoxMicroscope";
            this.serialPortGroupBoxMicroscope.Padding = new System.Windows.Forms.Padding(6);
            this.serialPortGroupBoxMicroscope.Size = new System.Drawing.Size(958, 142);
            this.serialPortGroupBoxMicroscope.TabIndex = 20;
            this.serialPortGroupBoxMicroscope.TabStop = false;
            this.serialPortGroupBoxMicroscope.Text = "Port for the Microscope";
            // 
            // initZButton
            // 
            this.initZButton.Location = new System.Drawing.Point(624, 409);
            this.initZButton.Name = "initZButton";
            this.initZButton.Size = new System.Drawing.Size(113, 34);
            this.initZButton.TabIndex = 23;
            this.initZButton.Text = "init Z";
            this.initZButton.UseVisualStyleBackColor = true;
            this.initZButton.Click += new System.EventHandler(this.initZButton_Click);
            // 
            // initYButton
            // 
            this.initYButton.Location = new System.Drawing.Point(624, 369);
            this.initYButton.Name = "initYButton";
            this.initYButton.Size = new System.Drawing.Size(113, 34);
            this.initYButton.TabIndex = 22;
            this.initYButton.Text = "init Y";
            this.initYButton.UseVisualStyleBackColor = true;
            this.initYButton.Click += new System.EventHandler(this.initYButton_Click);
            // 
            // initXButton
            // 
            this.initXButton.Location = new System.Drawing.Point(624, 329);
            this.initXButton.Name = "initXButton";
            this.initXButton.Size = new System.Drawing.Size(113, 34);
            this.initXButton.TabIndex = 21;
            this.initXButton.Text = "init X";
            this.initXButton.UseVisualStyleBackColor = true;
            this.initXButton.Click += new System.EventHandler(this.initXButton_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(743, 408);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(155, 34);
            this.button10.TabIndex = 26;
            this.button10.Text = "Go";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(743, 368);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(155, 34);
            this.button11.TabIndex = 25;
            this.button11.Text = "Go";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(743, 328);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(155, 34);
            this.button12.TabIndex = 24;
            this.button12.Text = "Go";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // ConfigurationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 745);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.initZButton);
            this.Controls.Add(this.initYButton);
            this.Controls.Add(this.initXButton);
            this.Controls.Add(this.serialPortGroupBoxMicroscope);
            this.Controls.Add(this.inputZCoordinate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.getZLabel);
            this.Controls.Add(this.getYLabel);
            this.Controls.Add(this.getXLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.setZButton);
            this.Controls.Add(this.setYButton);
            this.Controls.Add(this.setXButton);
            this.Controls.Add(this.getZButton);
            this.Controls.Add(this.getYButton);
            this.Controls.Add(this.getXButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.serialPortGroupBoxTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationDialog";
            this.Text = "Configurate your MicroscopeSystemDriver";
            this.serialPortGroupBoxTable.ResumeLayout(false);
            this.serialPortGroupBoxMicroscope.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox serialPortGroupBoxTable;
        private Shz.Imros.Utils.SerialPortConfigurationControl serialPortConfigurationControlTable;
        private System.Windows.Forms.Button getXButton;
        private System.Windows.Forms.Button getYButton;
        private System.Windows.Forms.Button getZButton;
        private System.Windows.Forms.Button setXButton;
        private System.Windows.Forms.Button setYButton;
        private System.Windows.Forms.Button setZButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label getXLabel;
        private System.Windows.Forms.Label getYLabel;
        private System.Windows.Forms.Label getZLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox inputZCoordinate;
        private Shz.Imros.Utils.SerialPortConfigurationControl serialPortConfigurationControlMicroscopeModule;
        private System.Windows.Forms.GroupBox serialPortGroupBoxMicroscope;
        private System.Windows.Forms.Button initZButton;
        private System.Windows.Forms.Button initYButton;
        private System.Windows.Forms.Button initXButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
    }
}