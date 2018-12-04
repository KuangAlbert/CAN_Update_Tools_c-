using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text; 

namespace neoCSNet2003
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	/// 

	public class Form1 : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.CheckBox chkExtendedID;
		internal System.Windows.Forms.TextBox txtDataByte11;
		internal System.Windows.Forms.TextBox txtDataByte10;
		internal System.Windows.Forms.TextBox txtDataByte9;
		internal System.Windows.Forms.ComboBox lstNumberOfBytes;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.ComboBox lstNetwork;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtDataByte2;
		internal System.Windows.Forms.Button cmdTransmit;
		internal System.Windows.Forms.TextBox txtDataByte3;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtDataByte4;
		internal System.Windows.Forms.TextBox txtDataByte5;
		internal System.Windows.Forms.TextBox txtDataByte6;
		internal System.Windows.Forms.TextBox txtDataByte7;
		internal System.Windows.Forms.TextBox txtArbID;
		internal System.Windows.Forms.TextBox txtDataByte8;
		internal System.Windows.Forms.TextBox txtDataByte1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.Button cmdVersion;
		internal System.Windows.Forms.Label lblneoInfo;
		internal System.Windows.Forms.Button CmdOpenFirstDevice;
		internal System.Windows.Forms.Button cmdCloseDevice;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.Label lblWaitForRxMessageWithTimeOutResult;
		internal System.Windows.Forms.Button cmdWaitForMessageWithTimeOut;
		internal System.Windows.Forms.CheckBox chkAutoRead;
		internal System.Windows.Forms.Label lblReadErrors;
		internal System.Windows.Forms.Label lblReadCount;
		internal System.Windows.Forms.ListBox lstMessage;
		internal System.Windows.Forms.Button cmdReceive;
		internal System.Windows.Forms.ListBox lstErrorHolder;
		internal System.Windows.Forms.Button cmdGetErrors;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Button cmd3GGetSettings;
		public System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.TabControl tccBaudSetType;
		internal System.Windows.Forms.TabPage TabPage1;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.ComboBox lstNetworkBaudRate;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.ComboBox lstBaudRateToUse;
		internal System.Windows.Forms.Button cmdSetBitRate;
		internal System.Windows.Forms.TabPage TabPage2;
		internal System.Windows.Forms.TabControl tccHardwareSelect;
		internal System.Windows.Forms.TabPage TabPage3;
		internal System.Windows.Forms.GroupBox Group2;
		internal System.Windows.Forms.Button cmdSet250K;
		internal System.Windows.Forms.Button cmdSet500K;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Button cmdSendHSCanInfo;
		internal System.Windows.Forms.TextBox txtCNF3;
		internal System.Windows.Forms.TextBox txtCNF2;
		internal System.Windows.Forms.TextBox txtCNF1;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Button cmdGetConfig;
		internal System.Windows.Forms.ListBox lstConfigInformation;
		internal System.Windows.Forms.TabPage TabPage4;
		internal System.Windows.Forms.TextBox txt3GBRP;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.Button cmd3GSetSettings;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Label Label20;
		internal System.Windows.Forms.TextBox txt3GSJumpW;
		internal System.Windows.Forms.TextBox txt3GPropDelay;
		internal System.Windows.Forms.TextBox txt3GPSeg2;
		internal System.Windows.Forms.TextBox txt3GPSeg1;
		internal System.Windows.Forms.Label label7;
		internal System.Windows.Forms.Button cmd3GGetSetting;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.chkExtendedID = new System.Windows.Forms.CheckBox();
			this.txtDataByte11 = new System.Windows.Forms.TextBox();
			this.txtDataByte10 = new System.Windows.Forms.TextBox();
			this.txtDataByte9 = new System.Windows.Forms.TextBox();
			this.lstNumberOfBytes = new System.Windows.Forms.ComboBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.lstNetwork = new System.Windows.Forms.ComboBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtDataByte2 = new System.Windows.Forms.TextBox();
			this.cmdTransmit = new System.Windows.Forms.Button();
			this.txtDataByte3 = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtDataByte4 = new System.Windows.Forms.TextBox();
			this.txtDataByte5 = new System.Windows.Forms.TextBox();
			this.txtDataByte6 = new System.Windows.Forms.TextBox();
			this.txtDataByte7 = new System.Windows.Forms.TextBox();
			this.txtArbID = new System.Windows.Forms.TextBox();
			this.txtDataByte8 = new System.Windows.Forms.TextBox();
			this.txtDataByte1 = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.cmdVersion = new System.Windows.Forms.Button();
			this.lblneoInfo = new System.Windows.Forms.Label();
			this.CmdOpenFirstDevice = new System.Windows.Forms.Button();
			this.cmdCloseDevice = new System.Windows.Forms.Button();
			this.GroupBox4 = new System.Windows.Forms.GroupBox();
			this.lblWaitForRxMessageWithTimeOutResult = new System.Windows.Forms.Label();
			this.cmdWaitForMessageWithTimeOut = new System.Windows.Forms.Button();
			this.chkAutoRead = new System.Windows.Forms.CheckBox();
			this.lblReadErrors = new System.Windows.Forms.Label();
			this.lblReadCount = new System.Windows.Forms.Label();
			this.lstMessage = new System.Windows.Forms.ListBox();
			this.cmdReceive = new System.Windows.Forms.Button();
			this.lstErrorHolder = new System.Windows.Forms.ListBox();
			this.cmdGetErrors = new System.Windows.Forms.Button();
			this.Label21 = new System.Windows.Forms.Label();
			this.cmd3GGetSettings = new System.Windows.Forms.Button();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.tccBaudSetType = new System.Windows.Forms.TabControl();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.Label6 = new System.Windows.Forms.Label();
			this.lstNetworkBaudRate = new System.Windows.Forms.ComboBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.lstBaudRateToUse = new System.Windows.Forms.ComboBox();
			this.cmdSetBitRate = new System.Windows.Forms.Button();
			this.TabPage2 = new System.Windows.Forms.TabPage();
			this.tccHardwareSelect = new System.Windows.Forms.TabControl();
			this.TabPage3 = new System.Windows.Forms.TabPage();
			this.Group2 = new System.Windows.Forms.GroupBox();
			this.cmdSet250K = new System.Windows.Forms.Button();
			this.cmdSet500K = new System.Windows.Forms.Button();
			this.Label15 = new System.Windows.Forms.Label();
			this.cmdSendHSCanInfo = new System.Windows.Forms.Button();
			this.txtCNF3 = new System.Windows.Forms.TextBox();
			this.txtCNF2 = new System.Windows.Forms.TextBox();
			this.txtCNF1 = new System.Windows.Forms.TextBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.cmdGetConfig = new System.Windows.Forms.Button();
			this.lstConfigInformation = new System.Windows.Forms.ListBox();
			this.TabPage4 = new System.Windows.Forms.TabPage();
			this.txt3GBRP = new System.Windows.Forms.TextBox();
			this.Label23 = new System.Windows.Forms.Label();
			this.cmd3GSetSettings = new System.Windows.Forms.Button();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.txt3GSJumpW = new System.Windows.Forms.TextBox();
			this.txt3GPropDelay = new System.Windows.Forms.TextBox();
			this.txt3GPSeg2 = new System.Windows.Forms.TextBox();
			this.txt3GPSeg1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cmd3GGetSetting = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			this.tccBaudSetType.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.TabPage2.SuspendLayout();
			this.tccHardwareSelect.SuspendLayout();
			this.TabPage3.SuspendLayout();
			this.Group2.SuspendLayout();
			this.TabPage4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox2
			// 
			this.GroupBox2.Controls.Add(this.chkExtendedID);
			this.GroupBox2.Controls.Add(this.txtDataByte11);
			this.GroupBox2.Controls.Add(this.txtDataByte10);
			this.GroupBox2.Controls.Add(this.txtDataByte9);
			this.GroupBox2.Controls.Add(this.lstNumberOfBytes);
			this.GroupBox2.Controls.Add(this.Label14);
			this.GroupBox2.Controls.Add(this.lstNetwork);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.txtDataByte2);
			this.GroupBox2.Controls.Add(this.cmdTransmit);
			this.GroupBox2.Controls.Add(this.txtDataByte3);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.txtDataByte4);
			this.GroupBox2.Controls.Add(this.txtDataByte5);
			this.GroupBox2.Controls.Add(this.txtDataByte6);
			this.GroupBox2.Controls.Add(this.txtDataByte7);
			this.GroupBox2.Controls.Add(this.txtArbID);
			this.GroupBox2.Controls.Add(this.txtDataByte8);
			this.GroupBox2.Controls.Add(this.txtDataByte1);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Location = new System.Drawing.Point(0, 88);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(536, 118);
			this.GroupBox2.TabIndex = 46;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Transmit Messages";
			// 
			// chkExtendedID
			// 
			this.chkExtendedID.Location = new System.Drawing.Point(312, 40);
			this.chkExtendedID.Name = "chkExtendedID";
			this.chkExtendedID.Size = new System.Drawing.Size(160, 16);
			this.chkExtendedID.TabIndex = 26;
			this.chkExtendedID.Text = "Send Extended ID";
			// 
			// txtDataByte11
			// 
			this.txtDataByte11.Location = new System.Drawing.Point(400, 64);
			this.txtDataByte11.Name = "txtDataByte11";
			this.txtDataByte11.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte11.TabIndex = 16;
			this.txtDataByte11.Text = "00";
			// 
			// txtDataByte10
			// 
			this.txtDataByte10.Location = new System.Drawing.Point(368, 64);
			this.txtDataByte10.Name = "txtDataByte10";
			this.txtDataByte10.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte10.TabIndex = 15;
			this.txtDataByte10.Text = "00";
			// 
			// txtDataByte9
			// 
			this.txtDataByte9.Location = new System.Drawing.Point(336, 64);
			this.txtDataByte9.Name = "txtDataByte9";
			this.txtDataByte9.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte9.TabIndex = 14;
			this.txtDataByte9.Text = "00";
			// 
			// lstNumberOfBytes
			// 
			this.lstNumberOfBytes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstNumberOfBytes.Items.AddRange(new object[] {
																  "0",
																  "1",
																  "2",
																  "3",
																  "4",
																  "5",
																  "6",
																  "7",
																  "8",
																  "9",
																  "10",
																  "11"});
			this.lstNumberOfBytes.Location = new System.Drawing.Point(8, 88);
			this.lstNumberOfBytes.Name = "lstNumberOfBytes";
			this.lstNumberOfBytes.Size = new System.Drawing.Size(48, 21);
			this.lstNumberOfBytes.TabIndex = 17;
			// 
			// Label14
			// 
			this.Label14.Location = new System.Drawing.Point(80, 16);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(48, 16);
			this.Label14.TabIndex = 21;
			this.Label14.Text = "Network";
			// 
			// lstNetwork
			// 
			this.lstNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstNetwork.Location = new System.Drawing.Point(80, 32);
			this.lstNetwork.Name = "lstNetwork";
			this.lstNetwork.Size = new System.Drawing.Size(104, 21);
			this.lstNetwork.TabIndex = 20;
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(232, 40);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(64, 16);
			this.Label3.TabIndex = 15;
			this.Label3.Text = "Data Bytes";
			// 
			// txtDataByte2
			// 
			this.txtDataByte2.Location = new System.Drawing.Point(112, 64);
			this.txtDataByte2.Name = "txtDataByte2";
			this.txtDataByte2.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte2.TabIndex = 7;
			this.txtDataByte2.Text = "00";
			// 
			// cmdTransmit
			// 
			this.cmdTransmit.Location = new System.Drawing.Point(80, 88);
			this.cmdTransmit.Name = "cmdTransmit";
			this.cmdTransmit.Size = new System.Drawing.Size(352, 24);
			this.cmdTransmit.TabIndex = 18;
			this.cmdTransmit.Text = "Transmit";
			this.cmdTransmit.Click += new System.EventHandler(this.cmdTransmit_Click);
			// 
			// txtDataByte3
			// 
			this.txtDataByte3.Location = new System.Drawing.Point(144, 64);
			this.txtDataByte3.Name = "txtDataByte3";
			this.txtDataByte3.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte3.TabIndex = 8;
			this.txtDataByte3.Text = "00";
			// 
			// Label4
			// 
			this.Label4.Cursor = System.Windows.Forms.Cursors.SizeAll;
			this.Label4.Location = new System.Drawing.Point(8, 56);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(64, 32);
			this.Label4.TabIndex = 18;
			this.Label4.Text = "Number of Data Bytes";
			// 
			// txtDataByte4
			// 
			this.txtDataByte4.Location = new System.Drawing.Point(176, 64);
			this.txtDataByte4.Name = "txtDataByte4";
			this.txtDataByte4.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte4.TabIndex = 9;
			this.txtDataByte4.Text = "00";
			// 
			// txtDataByte5
			// 
			this.txtDataByte5.Location = new System.Drawing.Point(208, 64);
			this.txtDataByte5.Name = "txtDataByte5";
			this.txtDataByte5.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte5.TabIndex = 10;
			this.txtDataByte5.Text = "00";
			// 
			// txtDataByte6
			// 
			this.txtDataByte6.Location = new System.Drawing.Point(240, 64);
			this.txtDataByte6.Name = "txtDataByte6";
			this.txtDataByte6.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte6.TabIndex = 11;
			this.txtDataByte6.Text = "00";
			// 
			// txtDataByte7
			// 
			this.txtDataByte7.Location = new System.Drawing.Point(272, 64);
			this.txtDataByte7.Name = "txtDataByte7";
			this.txtDataByte7.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte7.TabIndex = 12;
			this.txtDataByte7.Text = "00";
			// 
			// txtArbID
			// 
			this.txtArbID.Location = new System.Drawing.Point(8, 32);
			this.txtArbID.Name = "txtArbID";
			this.txtArbID.Size = new System.Drawing.Size(40, 20);
			this.txtArbID.TabIndex = 5;
			this.txtArbID.Text = "101";
			// 
			// txtDataByte8
			// 
			this.txtDataByte8.Location = new System.Drawing.Point(304, 64);
			this.txtDataByte8.Name = "txtDataByte8";
			this.txtDataByte8.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte8.TabIndex = 13;
			this.txtDataByte8.Text = "00";
			// 
			// txtDataByte1
			// 
			this.txtDataByte1.Location = new System.Drawing.Point(80, 64);
			this.txtDataByte1.Name = "txtDataByte1";
			this.txtDataByte1.Size = new System.Drawing.Size(32, 20);
			this.txtDataByte1.TabIndex = 6;
			this.txtDataByte1.Text = "00";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(8, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(40, 16);
			this.Label2.TabIndex = 14;
			this.Label2.Text = "Arb ID";
			// 
			// GroupBox1
			// 
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cmdVersion);
			this.GroupBox1.Controls.Add(this.lblneoInfo);
			this.GroupBox1.Controls.Add(this.CmdOpenFirstDevice);
			this.GroupBox1.Controls.Add(this.cmdCloseDevice);
			this.GroupBox1.Location = new System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(536, 88);
			this.GroupBox1.TabIndex = 45;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Connecting";
			// 
			// Label5
			// 
			this.Label5.Location = new System.Drawing.Point(400, 24);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(128, 16);
			this.Label5.TabIndex = 44;
			this.Label5.Text = "ICSNeo40.dll version";
			// 
			// cmdVersion
			// 
			this.cmdVersion.Location = new System.Drawing.Point(400, 48);
			this.cmdVersion.Name = "cmdVersion";
			this.cmdVersion.Size = new System.Drawing.Size(120, 24);
			this.cmdVersion.TabIndex = 43;
			this.cmdVersion.Text = "Version";
			this.cmdVersion.Click += new System.EventHandler(this.cmdVersion_Click);
			// 
			// lblneoInfo
			// 
			this.lblneoInfo.Location = new System.Drawing.Point(152, 24);
			this.lblneoInfo.Name = "lblneoInfo";
			this.lblneoInfo.Size = new System.Drawing.Size(120, 16);
			this.lblneoInfo.TabIndex = 2;
			this.lblneoInfo.Text = "Port Not Opened";
			// 
			// CmdOpenFirstDevice
			// 
			this.CmdOpenFirstDevice.Location = new System.Drawing.Point(16, 24);
			this.CmdOpenFirstDevice.Name = "CmdOpenFirstDevice";
			this.CmdOpenFirstDevice.Size = new System.Drawing.Size(120, 23);
			this.CmdOpenFirstDevice.TabIndex = 0;
			this.CmdOpenFirstDevice.Text = "Open First Device";
			this.CmdOpenFirstDevice.Click += new System.EventHandler(this.CmdOpenFirstDevice_Click);
			// 
			// cmdCloseDevice
			// 
			this.cmdCloseDevice.Location = new System.Drawing.Point(16, 56);
			this.cmdCloseDevice.Name = "cmdCloseDevice";
			this.cmdCloseDevice.Size = new System.Drawing.Size(120, 23);
			this.cmdCloseDevice.TabIndex = 1;
			this.cmdCloseDevice.Text = "CloseOpenDevice";
			this.cmdCloseDevice.Click += new System.EventHandler(this.cmdCloseDevice_Click);
			// 
			// GroupBox4
			// 
			this.GroupBox4.Controls.Add(this.lblWaitForRxMessageWithTimeOutResult);
			this.GroupBox4.Controls.Add(this.cmdWaitForMessageWithTimeOut);
			this.GroupBox4.Controls.Add(this.chkAutoRead);
			this.GroupBox4.Controls.Add(this.lblReadErrors);
			this.GroupBox4.Controls.Add(this.lblReadCount);
			this.GroupBox4.Controls.Add(this.lstMessage);
			this.GroupBox4.Controls.Add(this.cmdReceive);
			this.GroupBox4.Controls.Add(this.lstErrorHolder);
			this.GroupBox4.Controls.Add(this.cmdGetErrors);
			this.GroupBox4.Location = new System.Drawing.Point(0, 208);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new System.Drawing.Size(536, 264);
			this.GroupBox4.TabIndex = 47;
			this.GroupBox4.TabStop = false;
			this.GroupBox4.Text = "Receive Message";
			// 
			// lblWaitForRxMessageWithTimeOutResult
			// 
			this.lblWaitForRxMessageWithTimeOutResult.Location = new System.Drawing.Point(440, 16);
			this.lblWaitForRxMessageWithTimeOutResult.Name = "lblWaitForRxMessageWithTimeOutResult";
			this.lblWaitForRxMessageWithTimeOutResult.Size = new System.Drawing.Size(88, 40);
			this.lblWaitForRxMessageWithTimeOutResult.TabIndex = 27;
			this.lblWaitForRxMessageWithTimeOutResult.Text = "Status";
			// 
			// cmdWaitForMessageWithTimeOut
			// 
			this.cmdWaitForMessageWithTimeOut.Location = new System.Drawing.Point(336, 16);
			this.cmdWaitForMessageWithTimeOut.Name = "cmdWaitForMessageWithTimeOut";
			this.cmdWaitForMessageWithTimeOut.Size = new System.Drawing.Size(104, 40);
			this.cmdWaitForMessageWithTimeOut.TabIndex = 26;
			this.cmdWaitForMessageWithTimeOut.Text = "Wait for Message with Time Out";
			this.cmdWaitForMessageWithTimeOut.Click += new System.EventHandler(this.cmdWaitForMessageWithTimeOut_Click);
			// 
			// chkAutoRead
			// 
			this.chkAutoRead.Location = new System.Drawing.Point(120, 32);
			this.chkAutoRead.Name = "chkAutoRead";
			this.chkAutoRead.Size = new System.Drawing.Size(80, 16);
			this.chkAutoRead.TabIndex = 25;
			this.chkAutoRead.Text = "AutoRead";
			this.chkAutoRead.CheckedChanged += new System.EventHandler(this.chkAutoRead_CheckedChanged);
			// 
			// lblReadErrors
			// 
			this.lblReadErrors.Location = new System.Drawing.Point(200, 16);
			this.lblReadErrors.Name = "lblReadErrors";
			this.lblReadErrors.Size = new System.Drawing.Size(136, 16);
			this.lblReadErrors.TabIndex = 24;
			this.lblReadErrors.Text = "Number Errors : ";
			// 
			// lblReadCount
			// 
			this.lblReadCount.Location = new System.Drawing.Point(200, 40);
			this.lblReadCount.Name = "lblReadCount";
			this.lblReadCount.Size = new System.Drawing.Size(136, 16);
			this.lblReadCount.TabIndex = 23;
			this.lblReadCount.Text = "Number Read : ";
			// 
			// lstMessage
			// 
			this.lstMessage.Location = new System.Drawing.Point(8, 64);
			this.lstMessage.Name = "lstMessage";
			this.lstMessage.Size = new System.Drawing.Size(520, 95);
			this.lstMessage.TabIndex = 19;
			// 
			// cmdReceive
			// 
			this.cmdReceive.Location = new System.Drawing.Point(8, 16);
			this.cmdReceive.Name = "cmdReceive";
			this.cmdReceive.Size = new System.Drawing.Size(104, 40);
			this.cmdReceive.TabIndex = 20;
			this.cmdReceive.Text = "Get Messages";
			this.cmdReceive.Click += new System.EventHandler(this.cmdReceive_Click);
			// 
			// lstErrorHolder
			// 
			this.lstErrorHolder.HorizontalScrollbar = true;
			this.lstErrorHolder.Location = new System.Drawing.Point(8, 184);
			this.lstErrorHolder.Name = "lstErrorHolder";
			this.lstErrorHolder.ScrollAlwaysVisible = true;
			this.lstErrorHolder.Size = new System.Drawing.Size(520, 69);
			this.lstErrorHolder.TabIndex = 21;
			// 
			// cmdGetErrors
			// 
			this.cmdGetErrors.Location = new System.Drawing.Point(8, 160);
			this.cmdGetErrors.Name = "cmdGetErrors";
			this.cmdGetErrors.Size = new System.Drawing.Size(520, 24);
			this.cmdGetErrors.TabIndex = 22;
			this.cmdGetErrors.Text = "Get Errors";
			this.cmdGetErrors.Click += new System.EventHandler(this.cmdGetErrors_Click);
			// 
			// Label21
			// 
			this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Label21.Location = new System.Drawing.Point(8, 48);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(100, 16);
			this.Label21.TabIndex = 12;
			this.Label21.Text = "HS CAN 1";
			// 
			// cmd3GGetSettings
			// 
			this.cmd3GGetSettings.Location = new System.Drawing.Point(8, 8);
			this.cmd3GGetSettings.Name = "cmd3GGetSettings";
			this.cmd3GGetSettings.Size = new System.Drawing.Size(192, 32);
			this.cmd3GGetSettings.TabIndex = 11;
			this.cmd3GGetSettings.Text = "Get 3G Settings";
			// 
			// Timer1
			// 
			this.Timer1.Interval = 1000;
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// tccBaudSetType
			// 
			this.tccBaudSetType.Controls.Add(this.TabPage1);
			this.tccBaudSetType.Controls.Add(this.TabPage2);
			this.tccBaudSetType.Location = new System.Drawing.Point(8, 16);
			this.tccBaudSetType.Name = "tccBaudSetType";
			this.tccBaudSetType.SelectedIndex = 0;
			this.tccBaudSetType.Size = new System.Drawing.Size(272, 456);
			this.tccBaudSetType.TabIndex = 48;
			// 
			// TabPage1
			// 
			this.TabPage1.Controls.Add(this.Label6);
			this.TabPage1.Controls.Add(this.lstNetworkBaudRate);
			this.TabPage1.Controls.Add(this.Label1);
			this.TabPage1.Controls.Add(this.lstBaudRateToUse);
			this.TabPage1.Controls.Add(this.cmdSetBitRate);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new System.Drawing.Size(264, 430);
			this.TabPage1.TabIndex = 0;
			this.TabPage1.Text = "Quick Set";
			// 
			// Label6
			// 
			this.Label6.Location = new System.Drawing.Point(112, 8);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(72, 16);
			this.Label6.TabIndex = 47;
			this.Label6.Text = "Bit Rate";
			// 
			// lstNetworkBaudRate
			// 
			this.lstNetworkBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstNetworkBaudRate.Location = new System.Drawing.Point(8, 24);
			this.lstNetworkBaudRate.Name = "lstNetworkBaudRate";
			this.lstNetworkBaudRate.Size = new System.Drawing.Size(96, 21);
			this.lstNetworkBaudRate.TabIndex = 43;
			// 
			// Label1
			// 
			this.Label1.Location = new System.Drawing.Point(8, 8);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(80, 16);
			this.Label1.TabIndex = 44;
			this.Label1.Text = "CAN Channel";
			// 
			// lstBaudRateToUse
			// 
			this.lstBaudRateToUse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lstBaudRateToUse.Location = new System.Drawing.Point(112, 24);
			this.lstBaudRateToUse.Name = "lstBaudRateToUse";
			this.lstBaudRateToUse.Size = new System.Drawing.Size(96, 21);
			this.lstBaudRateToUse.TabIndex = 45;
			// 
			// cmdSetBitRate
			// 
			this.cmdSetBitRate.Location = new System.Drawing.Point(8, 48);
			this.cmdSetBitRate.Name = "cmdSetBitRate";
			this.cmdSetBitRate.Size = new System.Drawing.Size(200, 24);
			this.cmdSetBitRate.TabIndex = 46;
			this.cmdSetBitRate.Text = "Set Bit Rate";
			this.cmdSetBitRate.Click += new System.EventHandler(this.cmdSetBitRate_Click);
			// 
			// TabPage2
			// 
			this.TabPage2.Controls.Add(this.tccHardwareSelect);
			this.TabPage2.Location = new System.Drawing.Point(4, 22);
			this.TabPage2.Name = "TabPage2";
			this.TabPage2.Size = new System.Drawing.Size(264, 430);
			this.TabPage2.TabIndex = 1;
			this.TabPage2.Text = "Advanced";
			this.TabPage2.Visible = false;
			// 
			// tccHardwareSelect
			// 
			this.tccHardwareSelect.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.tccHardwareSelect.Controls.Add(this.TabPage3);
			this.tccHardwareSelect.Controls.Add(this.TabPage4);
			this.tccHardwareSelect.Location = new System.Drawing.Point(0, 0);
			this.tccHardwareSelect.Multiline = true;
			this.tccHardwareSelect.Name = "tccHardwareSelect";
			this.tccHardwareSelect.SelectedIndex = 0;
			this.tccHardwareSelect.Size = new System.Drawing.Size(264, 432);
			this.tccHardwareSelect.TabIndex = 1;
			// 
			// TabPage3
			// 
			this.TabPage3.Controls.Add(this.Group2);
			this.TabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TabPage3.Location = new System.Drawing.Point(23, 4);
			this.TabPage3.Name = "TabPage3";
			this.TabPage3.Size = new System.Drawing.Size(237, 424);
			this.TabPage3.TabIndex = 0;
			this.TabPage3.Text = "Blue, Vcan2, Pro";
			// 
			// Group2
			// 
			this.Group2.Controls.Add(this.cmdSet250K);
			this.Group2.Controls.Add(this.cmdSet500K);
			this.Group2.Controls.Add(this.Label15);
			this.Group2.Controls.Add(this.cmdSendHSCanInfo);
			this.Group2.Controls.Add(this.txtCNF3);
			this.Group2.Controls.Add(this.txtCNF2);
			this.Group2.Controls.Add(this.txtCNF1);
			this.Group2.Controls.Add(this.Label10);
			this.Group2.Controls.Add(this.Label9);
			this.Group2.Controls.Add(this.Label8);
			this.Group2.Controls.Add(this.cmdGetConfig);
			this.Group2.Controls.Add(this.lstConfigInformation);
			this.Group2.Location = new System.Drawing.Point(0, 0);
			this.Group2.Name = "Group2";
			this.Group2.Size = new System.Drawing.Size(200, 352);
			this.Group2.TabIndex = 34;
			this.Group2.TabStop = false;
			this.Group2.Text = "Neo Config Information";
			// 
			// cmdSet250K
			// 
			this.cmdSet250K.Location = new System.Drawing.Point(120, 200);
			this.cmdSet250K.Name = "cmdSet250K";
			this.cmdSet250K.Size = new System.Drawing.Size(72, 40);
			this.cmdSet250K.TabIndex = 11;
			this.cmdSet250K.Text = "Set HS CAN 250K";
			this.cmdSet250K.Click += new System.EventHandler(this.cmdSet250K_Click);
			// 
			// cmdSet500K
			// 
			this.cmdSet500K.Location = new System.Drawing.Point(120, 160);
			this.cmdSet500K.Name = "cmdSet500K";
			this.cmdSet500K.Size = new System.Drawing.Size(72, 40);
			this.cmdSet500K.TabIndex = 10;
			this.cmdSet500K.Text = "Set HS CAN 500K";
			this.cmdSet500K.Click += new System.EventHandler(this.cmdSet500K_Click);
			// 
			// Label15
			// 
			this.Label15.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(192)), ((System.Byte)(128)));
			this.Label15.Location = new System.Drawing.Point(8, 288);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(184, 56);
			this.Label15.TabIndex = 9;
			this.Label15.Text = " TIP: use neoVI explorer to get the proper CNFs. ValueCAN CNFs are different than" +
				" neoVI due to different CAN Chip speeds.";
			// 
			// cmdSendHSCanInfo
			// 
			this.cmdSendHSCanInfo.Location = new System.Drawing.Point(8, 248);
			this.cmdSendHSCanInfo.Name = "cmdSendHSCanInfo";
			this.cmdSendHSCanInfo.Size = new System.Drawing.Size(192, 40);
			this.cmdSendHSCanInfo.TabIndex = 8;
			this.cmdSendHSCanInfo.Text = "Send HS CAN Information";
			this.cmdSendHSCanInfo.Click += new System.EventHandler(this.cmdSendHSCanInfo_Click);
			// 
			// txtCNF3
			// 
			this.txtCNF3.Location = new System.Drawing.Point(48, 216);
			this.txtCNF3.Name = "txtCNF3";
			this.txtCNF3.Size = new System.Drawing.Size(56, 22);
			this.txtCNF3.TabIndex = 7;
			this.txtCNF3.Text = "5";
			// 
			// txtCNF2
			// 
			this.txtCNF2.Location = new System.Drawing.Point(48, 192);
			this.txtCNF2.Name = "txtCNF2";
			this.txtCNF2.Size = new System.Drawing.Size(56, 22);
			this.txtCNF2.TabIndex = 6;
			this.txtCNF2.Text = "B8";
			// 
			// txtCNF1
			// 
			this.txtCNF1.Location = new System.Drawing.Point(48, 168);
			this.txtCNF1.Name = "txtCNF1";
			this.txtCNF1.Size = new System.Drawing.Size(56, 22);
			this.txtCNF1.TabIndex = 5;
			this.txtCNF1.TabStop = false;
			this.txtCNF1.Text = "1";
			// 
			// Label10
			// 
			this.Label10.Location = new System.Drawing.Point(8, 216);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(40, 16);
			this.Label10.TabIndex = 4;
			this.Label10.Text = "CNF3";
			// 
			// Label9
			// 
			this.Label9.Location = new System.Drawing.Point(8, 192);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(40, 16);
			this.Label9.TabIndex = 3;
			this.Label9.Text = "CNF2";
			// 
			// Label8
			// 
			this.Label8.Location = new System.Drawing.Point(8, 168);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(40, 16);
			this.Label8.TabIndex = 2;
			this.Label8.Text = "CNF1";
			// 
			// cmdGetConfig
			// 
			this.cmdGetConfig.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.cmdGetConfig.Location = new System.Drawing.Point(8, 16);
			this.cmdGetConfig.Name = "cmdGetConfig";
			this.cmdGetConfig.Size = new System.Drawing.Size(184, 24);
			this.cmdGetConfig.TabIndex = 1;
			this.cmdGetConfig.Text = "Get Configuration";
			this.cmdGetConfig.Click += new System.EventHandler(this.cmdGetConfig_Click);
			// 
			// lstConfigInformation
			// 
			this.lstConfigInformation.ItemHeight = 16;
			this.lstConfigInformation.Location = new System.Drawing.Point(8, 40);
			this.lstConfigInformation.Name = "lstConfigInformation";
			this.lstConfigInformation.Size = new System.Drawing.Size(184, 116);
			this.lstConfigInformation.TabIndex = 0;
			// 
			// TabPage4
			// 
			this.TabPage4.Controls.Add(this.txt3GBRP);
			this.TabPage4.Controls.Add(this.Label23);
			this.TabPage4.Controls.Add(this.cmd3GSetSettings);
			this.TabPage4.Controls.Add(this.Label17);
			this.TabPage4.Controls.Add(this.Label18);
			this.TabPage4.Controls.Add(this.Label19);
			this.TabPage4.Controls.Add(this.Label20);
			this.TabPage4.Controls.Add(this.txt3GSJumpW);
			this.TabPage4.Controls.Add(this.txt3GPropDelay);
			this.TabPage4.Controls.Add(this.txt3GPSeg2);
			this.TabPage4.Controls.Add(this.txt3GPSeg1);
			this.TabPage4.Controls.Add(this.label7);
			this.TabPage4.Controls.Add(this.cmd3GGetSetting);
			this.TabPage4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.TabPage4.Location = new System.Drawing.Point(23, 4);
			this.TabPage4.Name = "TabPage4";
			this.TabPage4.Size = new System.Drawing.Size(237, 424);
			this.TabPage4.TabIndex = 1;
			this.TabPage4.Text = "FIRE, Red, Vcan3";
			this.TabPage4.Visible = false;
			// 
			// txt3GBRP
			// 
			this.txt3GBRP.Location = new System.Drawing.Point(8, 280);
			this.txt3GBRP.Name = "txt3GBRP";
			this.txt3GBRP.Size = new System.Drawing.Size(104, 22);
			this.txt3GBRP.TabIndex = 25;
			this.txt3GBRP.Text = "N/A";
			// 
			// Label23
			// 
			this.Label23.Location = new System.Drawing.Point(8, 264);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(100, 16);
			this.Label23.TabIndex = 24;
			this.Label23.Text = "BRP";
			// 
			// cmd3GSetSettings
			// 
			this.cmd3GSetSettings.Location = new System.Drawing.Point(8, 312);
			this.cmd3GSetSettings.Name = "cmd3GSetSettings";
			this.cmd3GSetSettings.Size = new System.Drawing.Size(192, 32);
			this.cmd3GSetSettings.TabIndex = 21;
			this.cmd3GSetSettings.Text = "Set G3 Settings";
			this.cmd3GSetSettings.Click += new System.EventHandler(this.cmd3GSetSettings_Click);
			// 
			// Label17
			// 
			this.Label17.Location = new System.Drawing.Point(8, 216);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(152, 16);
			this.Label17.TabIndex = 20;
			this.Label17.Text = "Sync Jump Width";
			// 
			// Label18
			// 
			this.Label18.Location = new System.Drawing.Point(8, 168);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(152, 16);
			this.Label18.TabIndex = 19;
			this.Label18.Text = "Propagation delay";
			// 
			// Label19
			// 
			this.Label19.Location = new System.Drawing.Point(8, 120);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(152, 16);
			this.Label19.TabIndex = 18;
			this.Label19.Text = "Phase Segment 2";
			// 
			// Label20
			// 
			this.Label20.Location = new System.Drawing.Point(8, 72);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(136, 16);
			this.Label20.TabIndex = 17;
			this.Label20.Text = "Phase Segment 1";
			// 
			// txt3GSJumpW
			// 
			this.txt3GSJumpW.Location = new System.Drawing.Point(8, 232);
			this.txt3GSJumpW.Name = "txt3GSJumpW";
			this.txt3GSJumpW.TabIndex = 16;
			this.txt3GSJumpW.Text = "N\\A";
			// 
			// txt3GPropDelay
			// 
			this.txt3GPropDelay.Location = new System.Drawing.Point(8, 184);
			this.txt3GPropDelay.Name = "txt3GPropDelay";
			this.txt3GPropDelay.TabIndex = 15;
			this.txt3GPropDelay.Text = "N\\A";
			// 
			// txt3GPSeg2
			// 
			this.txt3GPSeg2.Location = new System.Drawing.Point(8, 136);
			this.txt3GPSeg2.Name = "txt3GPSeg2";
			this.txt3GPSeg2.TabIndex = 14;
			this.txt3GPSeg2.Text = "N\\A";
			// 
			// txt3GPSeg1
			// 
			this.txt3GPSeg1.Location = new System.Drawing.Point(8, 88);
			this.txt3GPSeg1.Name = "txt3GPSeg1";
			this.txt3GPSeg1.TabIndex = 13;
			this.txt3GPSeg1.Text = "N\\A";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 48);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 16);
			this.label7.TabIndex = 12;
			this.label7.Text = "HS CAN 1";
			// 
			// cmd3GGetSetting
			// 
			this.cmd3GGetSetting.Location = new System.Drawing.Point(8, 8);
			this.cmd3GGetSetting.Name = "cmd3GGetSetting";
			this.cmd3GGetSetting.Size = new System.Drawing.Size(192, 32);
			this.cmd3GGetSetting.TabIndex = 11;
			this.cmd3GGetSetting.Text = "Get 3G Settings";
			this.cmd3GGetSetting.Click += new System.EventHandler(this.cmd3GGetSetting_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.tccBaudSetType);
			this.groupBox3.Location = new System.Drawing.Point(536, 0);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(288, 472);
			this.groupBox3.TabIndex = 49;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Baud Rate";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(824, 477);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.GroupBox4);
			this.Controls.Add(this.GroupBox2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox4.ResumeLayout(false);
			this.tccBaudSetType.ResumeLayout(false);
			this.TabPage1.ResumeLayout(false);
			this.TabPage2.ResumeLayout(false);
			this.tccHardwareSelect.ResumeLayout(false);
			this.TabPage3.ResumeLayout(false);
			this.Group2.ResumeLayout(false);
			this.TabPage4.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// 
		int m_hObject;		 //handle for device
		bool m_bPortOpen;	 //tells the port status of the device
		icsSpyMessage[] stMessages = new icsSpyMessage[20000];   //TempSpace for messages
		byte[] NetworkIDConvert = new byte[15]; // Storage to convert listbox index to Network ID's 
		int iOpenDeviceType; //Storage for the device type that is open

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private int ConvertFromHex(string num) 
		{
			//To hold our converted unsigned integer32 value
			uint uiHex = 0;
			try 
			{
				// Convert hex string to unsigned integer
				uiHex = System.Convert.ToUInt32(num, 16);
			}
			catch (System.OverflowException) 
			{
				//
			}
			return Convert.ToInt32(  uiHex);
		}

		private void CmdOpenFirstDevice_Click(object sender, System.EventArgs e)
		{
			int iResult;
			NeoDevice ndNeoToOpen = new NeoDevice();	//Struct holding detected hardware information
			byte[] bNetwork =  new byte[64];    //List of hardware IDs
			int iNumberOfDevices;   //Number of hardware devices to look for 
			int iCount;		 //counter

			//check if the port is already open
			if (m_bPortOpen == true) return;

			//File NetworkID array
			for(iCount = 0;iCount<64;iCount++)
			{
				bNetwork[iCount] = Convert.ToByte (iCount);
			}

			//Set the number of devices to find
			iNumberOfDevices = 1;

			//Search for connected hardware
			iResult = icsNeoDll.icsneoFindNeoDevices(65535,ref ndNeoToOpen,ref iNumberOfDevices);

			if (iResult == 0)
			{
				MessageBox.Show("Problem finding devices");
				return;
			}

			if (iNumberOfDevices < 1)
			{
				MessageBox.Show("No devices found");
				return;
			}

			//Open the first found device
			iResult = icsNeoDll.icsneoOpenNeoDevice(ref ndNeoToOpen,ref m_hObject,ref bNetwork[0], 1, 0);
			if (iResult==1)
			{
				MessageBox.Show("Port Opened OK!");
			}
			else
			{
				MessageBox.Show("Problem Opening Port");
				return;
			}


	//Set the device type for later use
	iOpenDeviceType = ndNeoToOpen.DeviceType;

	//display the connect hardware type
	switch(ndNeoToOpen.DeviceType)
	{
		case 1:
			lblneoInfo.Text = "neoVI Blue SN " + Convert.ToString(ndNeoToOpen.SerialNumber);
			tccHardwareSelect.SelectedIndex = 0;
			break;
		case 4:
			lblneoInfo.Text = "Value CAN 2 SN " + Convert.ToString(ndNeoToOpen.SerialNumber);
			tccHardwareSelect.SelectedIndex = 0;
			break;
		case 8:
			lblneoInfo.Text = "neoVI FIRE SN " + Convert.ToString(ndNeoToOpen.SerialNumber);
			tccHardwareSelect.SelectedIndex = 1;
			break;
		case 16:
			lblneoInfo.Text = "ValueCAN 3 SN " + Convert.ToString(ndNeoToOpen.SerialNumber);
			tccHardwareSelect.SelectedIndex = 1;
			break;
		default:
			lblneoInfo.Text = "Unknown neoVI SN " + Convert.ToString(ndNeoToOpen.SerialNumber);
			tccHardwareSelect.SelectedIndex = 0;
			break;
	}

	//Set device open flag
	m_bPortOpen = true;
}

private void cmdCloseDevice_Click(object sender, System.EventArgs e)
{
	int  iResult;
    int iNumberOfErrors=0;

	//close the port
    iResult = icsNeoDll.icsneoClosePort(m_hObject,ref iNumberOfErrors);
    if (iResult==1)
	{
		MessageBox.Show("Port Closed OK!");
	}
    else
	{
		MessageBox.Show("Problem ClosingPort");
	}

    lblneoInfo.Text = "Port Not Opened";

	//Clear device type and open flag
    iOpenDeviceType = 0;
	m_bPortOpen = false;
}

		private void cmdVersion_Click(object sender, System.EventArgs e)
		{
			//get version information and send to hardware.
			cmdVersion.Text = Convert.ToString(icsNeoDll.icsneoGetDLLVersion());
		}


		private void Form1_Load(object sender, System.EventArgs e)
		{
		
			iOpenDeviceType = 0;
	
			//Fill dropdowns
			tccBaudSetType.SelectedIndex = 0;
			tccHardwareSelect.SelectedIndex = 0;
			NetworkIDConvert[0] = Convert.ToByte(eNETWORK_ID.NETID_DEVICE);
			lstNetwork.Items.Add("DEVICE");
			NetworkIDConvert[1] = Convert.ToByte(eNETWORK_ID.NETID_HSCAN);
			lstNetwork.Items.Add("HSCAN");
			NetworkIDConvert[2] = Convert.ToByte(eNETWORK_ID.NETID_MSCAN);
			lstNetwork.Items.Add("MSCAN");
			NetworkIDConvert[3] = Convert.ToByte(eNETWORK_ID.NETID_SWCAN);
			lstNetwork.Items.Add("SWCAN");
			NetworkIDConvert[4] = Convert.ToByte(eNETWORK_ID.NETID_LSFTCAN);
			lstNetwork.Items.Add("LSFTCAN");
			NetworkIDConvert[5] = Convert.ToByte(eNETWORK_ID.NETID_FORDSCP);
			lstNetwork.Items.Add("FORDSCP");
			NetworkIDConvert[6] = Convert.ToByte(eNETWORK_ID.NETID_J1708);
			lstNetwork.Items.Add("J1708");
			NetworkIDConvert[7] = Convert.ToByte(eNETWORK_ID.NETID_JVPW);
			lstNetwork.Items.Add("JVPW");
			NetworkIDConvert[8] = Convert.ToByte(eNETWORK_ID.NETID_ISO);
			lstNetwork.Items.Add("ISO");
			NetworkIDConvert[9] = Convert.ToByte(eNETWORK_ID.NETID_HSCAN2);
			lstNetwork.Items.Add("FIRE_HSCAN2");
			NetworkIDConvert[10] = Convert.ToByte(eNETWORK_ID.NETID_MSCAN);
			lstNetwork.Items.Add("FIRE_MSCAN1");
			NetworkIDConvert[11] = Convert.ToByte(eNETWORK_ID.NETID_HSCAN3);
			lstNetwork.Items.Add("FIRE_HSCAN3");
			NetworkIDConvert[12] = Convert.ToByte(eNETWORK_ID.NETID_LIN2);
			lstNetwork.Items.Add("FIRE_LIN2");
			NetworkIDConvert[13] = Convert.ToByte(eNETWORK_ID.NETID_LIN3);
			lstNetwork.Items.Add("FIRE_LIN3");
			NetworkIDConvert[14] = Convert.ToByte(eNETWORK_ID.NETID_LIN4);
			lstNetwork.Items.Add("FIRE_LIN4");
			lstNetwork.SelectedIndex = 1;
			lstNumberOfBytes.SelectedIndex = 8;
	
			lstNetwork.SelectedIndex = 1;
			lstNumberOfBytes.SelectedIndex = 8;

	

        lstBaudRateToUse.Items.Add("20000");
        lstBaudRateToUse.Items.Add("33333");
        lstBaudRateToUse.Items.Add("50000");
        lstBaudRateToUse.Items.Add("62500");
        lstBaudRateToUse.Items.Add("83333");
        lstBaudRateToUse.Items.Add("100000");
        lstBaudRateToUse.Items.Add("125000");
        lstBaudRateToUse.Items.Add("250000");
        lstBaudRateToUse.Items.Add("500000");
        lstBaudRateToUse.Items.Add("800000");
        lstBaudRateToUse.Items.Add("1000000");
        lstBaudRateToUse.SelectedIndex = 0;

        lstNetworkBaudRate.Items.Add("HSCAN");
        lstNetworkBaudRate.Items.Add("MSCAN");
        lstNetworkBaudRate.Items.Add("SWCAN");
        lstNetworkBaudRate.Items.Add("LSFTCAN");
        lstNetworkBaudRate.Items.Add("HSCAN2");
        lstNetworkBaudRate.Items.Add("HSCAN3");
        lstNetworkBaudRate.SelectedIndex = 0;

			//Add the version number to the title of the application.  
			try
			{
				this.Text = "ICS API Example API Version " + Convert.ToString(icsNeoDll.icsneoGetDLLVersion());
			}
			catch
			{
				this.Text = "ICS API Example, DLL Missing or Not Accessable";
			}
        
		}

		private void cmdTransmit_Click(object sender, System.EventArgs e)
		{
			long lResult;
			icsSpyMessage stMessagesTx = new icsSpyMessage();
			icsSpyMessageJ1850 stJMsg = new icsSpyMessageJ1850();
			long lNetworkID;
			long lNumberBytes;

			// Has the uset open neoVI yet?;
			if (m_bPortOpen==false) 
			{
				MessageBox.Show("neoVI not opened");
				return; // do not read messages if we haven't opened neoVI yet
			}
	
			// Read the Network we will transmit on (indicated by lstNetwork ListBox)
			lNetworkID = lstNetwork.SelectedIndex ;
	
			// Is this a CAN network or a J1850/ISO one?
			if(lNetworkID <= 4 || lNetworkID >=40) // its a CAN network
			{
				// load the message structure
				stMessagesTx.NetworkID = Convert.ToByte(lNetworkID);
				if (chkExtendedID.Checked == true)
				{
					//Make id Extended
					stMessagesTx.StatusBitField = Convert.ToInt16(eDATA_STATUS_BITFIELD_1.SPY_STATUS_XTD_FRAME); 
				}
				else
				{
					//Use Normal ID
					stMessagesTx.StatusBitField = 0;
				}
				stMessagesTx.ArbIDOrHeader = ConvertFromHex(txtArbID.Text);            // The ArbID
				stMessagesTx.NumberBytesData = Convert.ToByte(lstNumberOfBytes.SelectedIndex);         // The number of Data Bytes
				if (stMessagesTx.NumberBytesData > 8) stMessagesTx.NumberBytesData = 8; // You can only have 8 databytes with CAN
				// Load all of the data bytes in the structure
	
				stMessagesTx.Data1 = Convert.ToByte(ConvertFromHex(txtDataByte1.Text));
				stMessagesTx.Data2 = Convert.ToByte(ConvertFromHex(txtDataByte2.Text));
				stMessagesTx.Data3 = Convert.ToByte(ConvertFromHex(txtDataByte3.Text));
				stMessagesTx.Data4 = Convert.ToByte(ConvertFromHex(txtDataByte4.Text));
				stMessagesTx.Data5 = Convert.ToByte(ConvertFromHex(txtDataByte5.Text));
				stMessagesTx.Data6 = Convert.ToByte(ConvertFromHex(txtDataByte6.Text));
				stMessagesTx.Data7 = Convert.ToByte(ConvertFromHex(txtDataByte7.Text));
				stMessagesTx.Data8 = Convert.ToByte(ConvertFromHex(txtDataByte8.Text));
			}
			else // its not a CAN network
			{
				// load the message structure (the J1850 struture type)
				lNumberBytes = lstNumberOfBytes.SelectedIndex;      // how many bytes
				if (lNumberBytes > 3) // how many header (max 3 header bytes) and data bytes
				{
					stJMsg.NumberBytesHeader = 3;
					stJMsg.NumberBytesData = Convert.ToByte(lNumberBytes - 3);
				}
				else
				{
					stJMsg.NumberBytesHeader = Convert.ToByte(lNumberBytes);
					stJMsg.NumberBytesData = 0;
				}
				stMessagesTx.NetworkID = Convert.ToByte(lNetworkID);
				// for all the header bytes
				stJMsg.Header1 = Convert.ToByte(ConvertFromHex(txtDataByte1.Text));
				stJMsg.Header2 = Convert.ToByte(ConvertFromHex(txtDataByte2.Text));
				stJMsg.Header3 = Convert.ToByte(ConvertFromHex(txtDataByte3.Text));
	
				// for all the data bytes
				stJMsg.Data1 = Convert.ToByte(ConvertFromHex(txtDataByte4.Text));
				stJMsg.Data2 = Convert.ToByte(ConvertFromHex(txtDataByte5.Text));
				stJMsg.Data3 = Convert.ToByte(ConvertFromHex(txtDataByte6.Text));
				stJMsg.Data4 = Convert.ToByte(ConvertFromHex(txtDataByte7.Text));
				stJMsg.Data5 = Convert.ToByte(ConvertFromHex(txtDataByte8.Text));
				stJMsg.Data6 = Convert.ToByte(ConvertFromHex(txtDataByte9.Text));
				stJMsg.Data7 = Convert.ToByte(ConvertFromHex(txtDataByte10.Text));
				stJMsg.Data8 = Convert.ToByte(ConvertFromHex(txtDataByte11.Text));
	
				// copy the J1850 message structure into the structure that will be sent				
				icsNeoDll.ConvertJ1850toCAN(ref stMessagesTx, ref stJMsg);
				
	
			}
	
			// Transmit the assembled message
			lResult=icsNeoDll.icsneoTxMessages(m_hObject,ref stMessagesTx,Convert.ToInt32(lNetworkID),1);
			// Test the returned result
			if (lResult!=1) 
			{
				MessageBox.Show("Problem Transmitting Message");
			}
		}

		private void cmdWaitForMessageWithTimeOut_Click(object sender, System.EventArgs e)
		{
		int iResult;
		UInt32 iTimeOut = 5000;


		lblWaitForRxMessageWithTimeOutResult.Text = "Status";
		Application.DoEvents();

		//This function will block until, A: A Message is received by the hardware, or B: the timeout is reached
		iResult = icsNeoDll.icsneoWaitForRxMessagesWithTimeOut(m_hObject, iTimeOut);
			if (iResult == 1) 
			{
				//Message received before timeout
				lblWaitForRxMessageWithTimeOutResult.Text = "Message received";
				cmdReceive_Click(sender, e);
			}
			else
			{
				//Timeout reached and no messages received
				lblWaitForRxMessageWithTimeOutResult.Text = "Message Not received";
			}

		}

		private void cmdReceive_Click(object sender, System.EventArgs e)
		{
			long lResult;
			int lNumberOfMessages=0;
			int lNumberOfErrors=0;
			long lCount;
			string sListString;
			icsSpyMessageJ1850 stJMsg=new icsSpyMessageJ1850();
			long lByteCount;
			double dTime = 0;
	
			if (m_bPortOpen==false)
			{
				MessageBox.Show("neoVI not opened");
				return;  // do not read messages if we haven't opened neoVI yet
			}

			// read the messages from the driver
			lResult = icsNeoDll.icsneoGetMessages(m_hObject,ref stMessages[0],ref lNumberOfMessages,ref lNumberOfErrors);
			// was the read successful?
			if (lResult== 1)
			{
				// clear the previous list of messages
				lstMessage.Items.Clear();
				lblReadCount.Text = "Number Read : " + Convert.ToString(lNumberOfMessages);
				lblReadErrors.Text = "Number Errors : " + Convert.ToString(lNumberOfErrors);
				// for each message we read
				for(lCount = 1;lCount<= lNumberOfMessages;lCount++)
				{
					// Calculate the messages timestamp
					lResult = icsNeoDll.icsneoGetTimeStampForMsg(m_hObject,ref stMessages[lCount-1],ref dTime);
					
					sListString = "Time : " + Convert.ToString(dTime);  //Build String

					// Was it a tx or rx message
					if ((stMessages[lCount-1].StatusBitField & Convert.ToInt32( eDATA_STATUS_BITFIELD_1.SPY_STATUS_TX_MSG)) > 0)
					{
						sListString = sListString + " Tx ";
					}
					else
					{
						sListString = sListString + " Rx ";
					}
	
					//Get the byte count
					lByteCount = stMessages[lCount - 1].NumberBytesData;
	
					// Was it a CAN or other protocol
					if (Convert.ToBoolean (stMessages[lCount-1].Protocol == Convert.ToInt32(  ePROTOCOL.SPY_PROTOCOL_CAN)))
					{
						// list the arb id
						sListString = sListString + "Network " + icsNeoDll.GetStringForNetworkID(Convert.ToInt16(  stMessages[lCount - 1].NetworkID)) + " ArbID : " + icsNeoDll.ConvertToHex(Convert.ToString(stMessages[lCount - 1].ArbIDOrHeader)) + "  Data ";
						if (lByteCount >= 1) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stMessages[lCount - 1].Data1)) + " ";
						if (lByteCount >= 2) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stMessages[lCount - 1].Data2)) + " ";
						if (lByteCount >= 3) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stMessages[lCount - 1].Data3)) + " ";
						if (lByteCount >= 4) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stMessages[lCount - 1].Data4)) + " ";
						if (lByteCount >= 5) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stMessages[lCount - 1].Data5)) + " ";
						if (lByteCount >= 6) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stMessages[lCount - 1].Data6)) + " ";
						if (lByteCount >= 7) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stMessages[lCount - 1].Data7)) + " ";
						if (lByteCount >= 8) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stMessages[lCount - 1].Data8)) + " ";
					}
					else
					{
						// list the headers bytes
						icsNeoDll.ConvertCANtoJ1850Message(ref stMessages[lCount - 1],ref stJMsg);
						sListString = sListString + "Network " + icsNeoDll.GetStringForNetworkID(stJMsg.NetworkID) + " Data : ";
	
						//add the data bytes
						if (stJMsg.NumberBytesHeader >= 1) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Header1)) + " ";
						if (stJMsg.NumberBytesHeader >= 2) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Header2)) + " ";
						if (stJMsg.NumberBytesHeader >= 3) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Header3)) + " ";
						sListString = sListString + "  ";
						if (lByteCount >= 1) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Data1)) + " ";
						if (lByteCount >= 2) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Data2)) + " ";
						if (lByteCount >= 3) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Data3)) + " ";
						if (lByteCount >= 4) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Data4)) + " ";
						if (lByteCount >= 5) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Data5)) + " ";
						if (lByteCount >= 6) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Data6)) + " ";
						if (lByteCount >= 7) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Data7)) + " ";
						if (lByteCount >= 8) sListString = sListString + icsNeoDll.ConvertToHex(Convert.ToString(stJMsg.Data8)) + " ";
					}

					//Add the message to the list
					lstMessage.Items.Add(sListString);
	
				}
			}
			else
			{
				MessageBox.Show("Problem Reading Messages");
			}
		}

		private void cmdGetErrors_Click(object sender, System.EventArgs e)
		{
			int iResult = 0;  //Storage for Result of Call
			int[] iErrors = new int[600];  //Array for Error Numbers
			int iNumberOfErrors  = 0;  // Storage for number of errors
			int iCount= 0;   //Counter
			int iSeverity =0;  //tells the Severity of Error
			int iMaxLengthShort = 0;  //Tells Max length of Error String
			int iMaxLengthLong = 0;	//Tells Max Length of Error String
			int lRestart = 0;  //tells if a restart is needed
			StringBuilder sErrorShort = new StringBuilder(256);  //String for Error
			StringBuilder sErrorLong = new StringBuilder(256);  //String for Error

			iMaxLengthShort = 1; //Set initial conditions
			iMaxLengthLong = 1; //Set initial conditions
			// Read Out the errors
			iResult = icsNeoDll.icsneoGetErrorMessages(m_hObject,ref iErrors[0],ref iNumberOfErrors);

			// Test the returned result
			if(iResult == 0)
			{
				MessageBox.Show ("Problem Reading Errors");			
			}
			else
			{
				if(iNumberOfErrors != 0)
				{
					for(iCount=0;iCount< iNumberOfErrors;iCount++)
					{
						//Get Text Description of the Error
						iResult = icsNeoDll.icsneoGetErrorInfo(iErrors[iCount], sErrorShort, sErrorLong ,ref  iMaxLengthShort , ref iMaxLengthLong, ref iSeverity,ref lRestart);
						lstErrorHolder.Items.Add (sErrorShort + " - Description " + sErrorLong + " - Errornum: " + iErrors[iCount]);
					}
				}
			}
			
		}

		private void Timer1_Tick(object sender, System.EventArgs e)
		{
			if(m_bPortOpen == true)
			{
				cmdReceive_Click(cmdReceive,null);
			}
		}

		private void cmdSetBitRate_Click(object sender, System.EventArgs e)
		{
		int iBitRateToUse;
        int iNetworkID;
        int iResult;

		if (m_bPortOpen==false)
		{
			MessageBox.Show("neoVI not opened");
			return;  // do not read messages if we haven't opened neoVI yet
		}

		//Get the network name index to set the baud rate of 
			switch(lstNetworkBaudRate.SelectedIndex)
			{
				case 0:
					iNetworkID = Convert.ToInt32(eNETWORK_ID.NETID_HSCAN);
					break;
				case 1:
					iNetworkID = Convert.ToInt32(eNETWORK_ID.NETID_MSCAN);
					break;
				case 2:
					iNetworkID = Convert.ToInt32(eNETWORK_ID.NETID_SWCAN);
					break;
				case 3:
					iNetworkID = Convert.ToInt32(eNETWORK_ID.NETID_LSFTCAN);
					break;
				case 4:
					iNetworkID = Convert.ToInt32(eNETWORK_ID.NETID_HSCAN2);
					break;
				case 5:
					iNetworkID = Convert.ToInt32(eNETWORK_ID.NETID_HSCAN3);
					break;
				default:
					MessageBox.Show("Incorrect Network selected");
					return;
			}

        iBitRateToUse = Convert.ToInt32(lstBaudRateToUse.Text);

		//Set the bit rate
        iResult = icsNeoDll.icsneoSetBitRate(m_hObject, iBitRateToUse, iNetworkID);
        if (iResult == 0)
		{
			MessageBox.Show("Problem setting bit rate");
		}
		else
		{
			MessageBox.Show("Bit rate set");
		}
	}

		private void cmdGetConfig_Click(object sender, System.EventArgs e)
		{
			byte[] bConfigBytes = new byte[1024];  //Storage for Data Bytes from Device
			int iNumBytes=0;    //Storage for Number of Bytes
			int lResult;    //Storage for Result of Called Function
			int Counter;

        if (m_bPortOpen == false)
		{
            MessageBox.Show("Open port for device first");
			return;
		}

        //Clear listbox
        lstConfigInformation.Items.Clear();

        //Call Get Configuration 
        lResult = icsNeoDll.icsneoGetConfiguration( m_hObject,ref bConfigBytes[0], ref iNumBytes);

        //Fill ListBox with Data From function Call
        for (Counter = 0; Counter< 1024; Counter++)
		{
            lstConfigInformation.Items.Add("Byte#-" + Counter + " Data-" + bConfigBytes[Counter]);
		}
		}

		private void cmdSet500K_Click(object sender, System.EventArgs e)
		{
			txtCNF1.Text = "1";
			txtCNF2.Text = "B8";
			txtCNF3.Text = "5";
		}

		private void cmdSet250K_Click(object sender, System.EventArgs e)
		{
			txtCNF1.Text = "3";
			txtCNF2.Text = "B8";
			txtCNF3.Text = "5";
		}

		private void cmdSendHSCanInfo_Click(object sender, System.EventArgs e)
		{
			byte[] bConfigBytes = new byte[1024];  //Storage for Data Bytes from Device
			int iNumBytes=0;    //Storage for Number of Bytes
			int lResult;    //Storage for Result of Called Function
			int Counter;
			int iNumberOfErrors=0; //Storage for Number of Errors Received

			if (m_bPortOpen == false)
			{
				MessageBox.Show("Open port for device first");
				return;
			}

			//Clear listbox
			lstConfigInformation.Items.Clear();

			//Call Get Configuration 
			lResult = icsNeoDll.icsneoGetConfiguration( m_hObject,ref bConfigBytes[0], ref iNumBytes);

			//Fill ListBox with Data From function Call
			for (Counter = 0; Counter< 1024; Counter++)
			{
				lstConfigInformation.Items.Add("Byte Number-" + Counter + " Byte Data-" + bConfigBytes[Counter]);
			}

			//Set HS CAN Baud Rate Information
			bConfigBytes[Convert.ToInt32(icsConfigSetup.NEO_CFG_MPIC_HS_CAN_CNF1)] = Convert.ToByte(txtCNF1.Text,16);
			bConfigBytes[Convert.ToInt32(icsConfigSetup.NEO_CFG_MPIC_HS_CAN_CNF2)] = Convert.ToByte(txtCNF2.Text,16);
			bConfigBytes[Convert.ToInt32(icsConfigSetup.NEO_CFG_MPIC_HS_CAN_CNF3)] = Convert.ToByte(txtCNF3.Text,16);
	
			//Disable Network communication and call Sned configuration
			icsNeoDll.icsneoEnableNetworkCom(m_hObject, 0);
			lResult = icsNeoDll.icsneoSendConfiguration(m_hObject,ref bConfigBytes[0], iNumBytes);
			icsNeoDll.icsneoEnableNetworkCom(m_hObject, 1);

			// make sure the read was successful
			if (lResult==0) 
			{
				MessageBox.Show("Problem sending configuration");
				lResult = icsNeoDll.icsneoClosePort( m_hObject,ref iNumberOfErrors);
			}
			else
			{
				MessageBox.Show("Configuration Successfull");
			}
		}

		private void cmd3GGetSetting_Click(object sender, System.EventArgs e)
		{
			SVCAN3Settings VcanReadSettings= new SVCAN3Settings();
			SFireSettings FireReadSettings= new SFireSettings();
			CAN_SETTINGS HSCanSettings=new CAN_SETTINGS();
			int iNumberOfBytes=0;
			int iResult;

			if(m_bPortOpen == false)  //Check to see if the port is opened first
			{
				MessageBox.Show("Device is Not Opened!");       
				return;
			}

			//Get the settigns of the connected hardware
			switch (iOpenDeviceType)
			{
				case 8:		  //FIRE
					//Get the settings
					iNumberOfBytes = System.Runtime.InteropServices.Marshal.SizeOf(FireReadSettings);
					iResult = icsNeoDll.icsneoGetFireSettings(m_hObject,ref FireReadSettings, iNumberOfBytes);
					if (iResult == 0)
					{
						MessageBox.Show("Problem reading FIRE configuration");				 
						return;
					}
					//Copy the HS CAN settings from the structure to sub struct
					HSCanSettings = FireReadSettings.can1;
					break;

				case 16:			 //Vcan3
					//Get the setting
					iNumberOfBytes = System.Runtime.InteropServices.Marshal.SizeOf(VcanReadSettings);
					iResult = icsNeoDll.icsneoGetVCAN3Settings(m_hObject,ref VcanReadSettings, iNumberOfBytes);
					if (iResult == 0)
					{
						MessageBox.Show("Problem reading VCAN3 configuration");			 
						return;
					}
					//Copy the HS CAN settings from the structure to sub struct
					HSCanSettings = VcanReadSettings.Can1;
					break;
				default:
						//Connected hardware does not support this command
						MessageBox.Show("Problem reading configuration, unsupported device");
						return;
		}

			//fill text boxes with data from sub struct
			txt3GPSeg1.Text = Convert.ToString(HSCanSettings.TqSeg1);
			txt3GPSeg2.Text = Convert.ToString(HSCanSettings.TqSeg2);
			txt3GPropDelay.Text = Convert.ToString(HSCanSettings.TqProp);
			txt3GSJumpW.Text = Convert.ToString(HSCanSettings.TqSync);
			txt3GBRP.Text = Convert.ToString(HSCanSettings.BRP);
		}

		private void cmd3GSetSettings_Click(object sender, System.EventArgs e)
		{
			SVCAN3Settings VcanReadSettings=new SVCAN3Settings();
			SFireSettings FireReadSettings = new SFireSettings();
			CAN_SETTINGS HSCanSettings=new CAN_SETTINGS();
			int iNumberOfBytes=0;
			int iResult;

			if(m_bPortOpen == false)  //Check to see if the port is opened first
			{
				MessageBox.Show("Device is Not Opened!");       
				return;
			}

			switch( iOpenDeviceType)
			{
				case 8:			 //FIRE
					//Get the settings
					iNumberOfBytes = System.Runtime.InteropServices.Marshal.SizeOf(FireReadSettings);
					iResult = icsNeoDll.icsneoGetFireSettings(m_hObject,ref  FireReadSettings, iNumberOfBytes);
					if (iResult == 0)
					{
						MessageBox.Show("Problem reading FIRE configuration");
						return;
					}
					//Copy the HS CAN settings from the structure to sub struct
					HSCanSettings = FireReadSettings.can1;
					break;
					
				case 16:			 //Vcan3
					//Get the setting
					iNumberOfBytes = System.Runtime.InteropServices.Marshal.SizeOf(VcanReadSettings);
					iResult = icsNeoDll.icsneoGetVCAN3Settings(m_hObject,ref VcanReadSettings, iNumberOfBytes);
					if (iResult == 0)
					{
						MessageBox.Show("Problem reading VCAN3 configuration");
						return;
					}
					
					//Copy the HS CAN settings from the structure to sub struct
					HSCanSettings = VcanReadSettings.Can1;
					break;

				default:
					//Connected hardware does not support this command
					MessageBox.Show("Problem reading configuration, unsupported device");
					return;
			}

		//fill text boxes with data from sub struct
        HSCanSettings.TqSeg1 = Convert.ToByte(txt3GPSeg1.Text);
        HSCanSettings.TqSeg2 = Convert.ToByte(txt3GPSeg2.Text);
        HSCanSettings.TqProp = Convert.ToByte(txt3GPropDelay.Text);
        HSCanSettings.TqSync = Convert.ToByte(txt3GSJumpW.Text);
        HSCanSettings.BRP = Convert.ToByte(txt3GBRP.Text);
        HSCanSettings.SetBaudrate = 1;

		//Check device to make sure correct structure goes to correct device
        switch(iOpenDeviceType)
		{
			case 8:		  //FIRE
				//copy sub struct to main struct
				FireReadSettings.can1 = HSCanSettings;
				iResult = icsNeoDll.icsneoSetFireSettings(m_hObject,ref FireReadSettings, iNumberOfBytes, 1);
				if (iResult == 0)
				{
					MessageBox.Show("Problem Sending FIRE configuration");
					return;
				}
				break;
			case 16:			 //Vcan3
				//copy sub struct to main struct
				VcanReadSettings.Can1 = HSCanSettings;
				iResult = icsNeoDll.icsneoSetVCAN3Settings(m_hObject,ref VcanReadSettings, iNumberOfBytes, 1);
				if (iResult == 0)
				{
					MessageBox.Show("Problem Sending Vcan3 configuration");
					return;
				}
				break;
			default:
					MessageBox.Show("Problem sending configuration, unsupported device");
			return;
		}
						MessageBox.Show("Settings Changed");
		}

		private void chkAutoRead_CheckedChanged(object sender, System.EventArgs e)
		{
			if (chkAutoRead.Checked  == true) 
			{
				Timer1.Enabled =true;
			}
			else 
			{
				Timer1.Enabled = false;
			}
																	
		}
	

	}
}