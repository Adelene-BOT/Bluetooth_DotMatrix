namespace Bluetooth_DotMetrix
{
    partial class frmTerminalData
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabControl tabMenu;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerminalData));
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbReceiver = new System.Windows.Forms.GroupBox();
            this.rtxtReceiver = new System.Windows.Forms.RichTextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.gbTransmiter = new System.Windows.Forms.GroupBox();
            this.btSend = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDeleted = new System.Windows.Forms.Label();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.lblTomorrow = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lvEvent = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNews = new System.Windows.Forms.ListBox();
            this.cbSendNews = new System.Windows.Forms.CheckBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cbSendDate = new System.Windows.Forms.CheckBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.cbSendTime = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtStopBits = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtParity = new System.Windows.Forms.TextBox();
            this.txtBaudRate = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbStatus = new System.Windows.Forms.GroupBox();
            this.cmbComList = new System.Windows.Forms.ComboBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.gbSetup = new System.Windows.Forms.GroupBox();
            this.lblSyncDate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblSync = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.gbDateZone = new System.Windows.Forms.GroupBox();
            this.lblZone = new System.Windows.Forms.Label();
            this.cmbLokasi = new System.Windows.Forms.ComboBox();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbWaktuSolat = new System.Windows.Forms.GroupBox();
            this.lblIsyak = new System.Windows.Forms.Label();
            this.lblMaghrib = new System.Windows.Forms.Label();
            this.lblAsar = new System.Windows.Forms.Label();
            this.lblZohor = new System.Windows.Forms.Label();
            this.lblSyuruk = new System.Windows.Forms.Label();
            this.lblSubuh = new System.Windows.Forms.Label();
            this.lblImsak = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tlsSeen = new System.Windows.Forms.ToolStripStatusLabel();
            tabMenu = new System.Windows.Forms.TabControl();
            tabMenu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbReceiver.SuspendLayout();
            this.gbTransmiter.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbStatus.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.gbSetup.SuspendLayout();
            this.gbDateZone.SuspendLayout();
            this.gbWaktuSolat.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(this.tabPage1);
            tabMenu.Controls.Add(this.tabPage2);
            tabMenu.Controls.Add(this.tabPage3);
            tabMenu.Controls.Add(this.tabPage4);
            tabMenu.Location = new System.Drawing.Point(-3, 1);
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new System.Drawing.Size(413, 345);
            tabMenu.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbReceiver);
            this.tabPage1.Controls.Add(this.gbTransmiter);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Massage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbReceiver
            // 
            this.gbReceiver.Controls.Add(this.rtxtReceiver);
            this.gbReceiver.Controls.Add(this.btClear);
            this.gbReceiver.ForeColor = System.Drawing.Color.Blue;
            this.gbReceiver.Location = new System.Drawing.Point(6, 91);
            this.gbReceiver.Name = "gbReceiver";
            this.gbReceiver.Size = new System.Drawing.Size(393, 85);
            this.gbReceiver.TabIndex = 3;
            this.gbReceiver.TabStop = false;
            this.gbReceiver.Text = "Receiver (RX)";
            // 
            // rtxtReceiver
            // 
            this.rtxtReceiver.BackColor = System.Drawing.SystemColors.Window;
            this.rtxtReceiver.ForeColor = System.Drawing.SystemColors.Window;
            this.rtxtReceiver.Location = new System.Drawing.Point(0, 19);
            this.rtxtReceiver.Name = "rtxtReceiver";
            this.rtxtReceiver.ReadOnly = true;
            this.rtxtReceiver.Size = new System.Drawing.Size(382, 30);
            this.rtxtReceiver.TabIndex = 17;
            this.rtxtReceiver.Text = "";
            this.rtxtReceiver.TextChanged += new System.EventHandler(this.rtxtReceiver_TextChanged);
            // 
            // btClear
            // 
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btClear.Location = new System.Drawing.Point(5, 55);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(382, 25);
            this.btClear.TabIndex = 2;
            this.btClear.Text = "CLEAR";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // gbTransmiter
            // 
            this.gbTransmiter.Controls.Add(this.btSend);
            this.gbTransmiter.Controls.Add(this.txtSend);
            this.gbTransmiter.Enabled = false;
            this.gbTransmiter.ForeColor = System.Drawing.Color.Blue;
            this.gbTransmiter.Location = new System.Drawing.Point(6, 6);
            this.gbTransmiter.Name = "gbTransmiter";
            this.gbTransmiter.Size = new System.Drawing.Size(393, 79);
            this.gbTransmiter.TabIndex = 4;
            this.gbTransmiter.TabStop = false;
            this.gbTransmiter.Text = "Transmiter (TX)";
            // 
            // btSend
            // 
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSend.Location = new System.Drawing.Point(6, 45);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(382, 25);
            this.btSend.TabIndex = 3;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(6, 19);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(382, 20);
            this.txtSend.TabIndex = 1;
            this.txtSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyDown);
            this.txtSend.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSend_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Time/Date";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.lblDeleted);
            this.groupBox2.Controls.Add(this.lblOverdue);
            this.groupBox2.Controls.Add(this.lblTomorrow);
            this.groupBox2.Controls.Add(this.lblToday);
            this.groupBox2.Controls.Add(this.lvEvent);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(13, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 197);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Event";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(6, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(33, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "All : 0";
            // 
            // lblDeleted
            // 
            this.lblDeleted.AutoSize = true;
            this.lblDeleted.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeleted.Location = new System.Drawing.Point(310, 16);
            this.lblDeleted.Name = "lblDeleted";
            this.lblDeleted.Size = new System.Drawing.Size(65, 13);
            this.lblDeleted.TabIndex = 12;
            this.lblDeleted.Text = "Delected : 0";
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblOverdue.Location = new System.Drawing.Point(231, 16);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(63, 13);
            this.lblOverdue.TabIndex = 11;
            this.lblOverdue.Text = "Overdue : 0";
            // 
            // lblTomorrow
            // 
            this.lblTomorrow.AutoSize = true;
            this.lblTomorrow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTomorrow.Location = new System.Drawing.Point(144, 16);
            this.lblTomorrow.Name = "lblTomorrow";
            this.lblTomorrow.Size = new System.Drawing.Size(69, 13);
            this.lblTomorrow.TabIndex = 10;
            this.lblTomorrow.Text = "Tomorrow : 0";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToday.Location = new System.Drawing.Point(74, 16);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(52, 13);
            this.lblToday.TabIndex = 9;
            this.lblToday.Text = "Today : 0";
            // 
            // lvEvent
            // 
            this.lvEvent.HideSelection = false;
            this.lvEvent.Location = new System.Drawing.Point(6, 48);
            this.lvEvent.Name = "lvEvent";
            this.lvEvent.Size = new System.Drawing.Size(368, 143);
            this.lvEvent.TabIndex = 8;
            this.lvEvent.UseCompatibleStateImageBehavior = false;
            this.lvEvent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvEvent_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNews);
            this.groupBox1.Controls.Add(this.cbSendNews);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.cbSendDate);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.cbSendTime);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 99);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Time/Date";
            // 
            // lbNews
            // 
            this.lbNews.FormattingEnabled = true;
            this.lbNews.Location = new System.Drawing.Point(89, 75);
            this.lbNews.Name = "lbNews";
            this.lbNews.Size = new System.Drawing.Size(285, 17);
            this.lbNews.TabIndex = 11;
            // 
            // cbSendNews
            // 
            this.cbSendNews.AutoSize = true;
            this.cbSendNews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSendNews.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbSendNews.Location = new System.Drawing.Point(6, 76);
            this.cbSendNews.Name = "cbSendNews";
            this.cbSendNews.Size = new System.Drawing.Size(81, 17);
            this.cbSendNews.TabIndex = 10;
            this.cbSendNews.Text = "Send News";
            this.cbSendNews.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(89, 49);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(285, 20);
            this.txtDate.TabIndex = 7;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSendDate
            // 
            this.cbSendDate.AutoSize = true;
            this.cbSendDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSendDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbSendDate.Location = new System.Drawing.Point(6, 49);
            this.cbSendDate.Name = "cbSendDate";
            this.cbSendDate.Size = new System.Drawing.Size(77, 17);
            this.cbSendDate.TabIndex = 6;
            this.cbSendDate.Text = "Send Date";
            this.cbSendDate.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(89, 23);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(285, 20);
            this.txtTime.TabIndex = 6;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbSendTime
            // 
            this.cbSendTime.AutoSize = true;
            this.cbSendTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSendTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbSendTime.Location = new System.Drawing.Point(6, 26);
            this.cbSendTime.Name = "cbSendTime";
            this.cbSendTime.Size = new System.Drawing.Size(77, 17);
            this.cbSendTime.TabIndex = 5;
            this.cbSendTime.Text = "Send Time";
            this.cbSendTime.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtStopBits);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.gbStatus);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(405, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Setup";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtStopBits
            // 
            this.txtStopBits.Location = new System.Drawing.Point(114, 202);
            this.txtStopBits.Name = "txtStopBits";
            this.txtStopBits.ReadOnly = true;
            this.txtStopBits.Size = new System.Drawing.Size(277, 20);
            this.txtStopBits.TabIndex = 7;
            this.txtStopBits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.txtParity);
            this.groupBox3.Controls.Add(this.txtBaudRate);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(6, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(391, 143);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connection Configuration";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(108, 83);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(277, 20);
            this.txtData.TabIndex = 6;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtParity
            // 
            this.txtParity.Location = new System.Drawing.Point(108, 57);
            this.txtParity.Name = "txtParity";
            this.txtParity.ReadOnly = true;
            this.txtParity.Size = new System.Drawing.Size(277, 20);
            this.txtParity.TabIndex = 5;
            this.txtParity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(108, 31);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.ReadOnly = true;
            this.txtBaudRate.Size = new System.Drawing.Size(277, 20);
            this.txtBaudRate.TabIndex = 4;
            this.txtBaudRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(14, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Stop Bits:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(14, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Data  :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(14, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Parity :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(14, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Baud Rate :";
            // 
            // gbStatus
            // 
            this.gbStatus.Controls.Add(this.cmbComList);
            this.gbStatus.Controls.Add(this.btConnect);
            this.gbStatus.ForeColor = System.Drawing.Color.Blue;
            this.gbStatus.Location = new System.Drawing.Point(6, 13);
            this.gbStatus.Name = "gbStatus";
            this.gbStatus.Size = new System.Drawing.Size(392, 72);
            this.gbStatus.TabIndex = 8;
            this.gbStatus.TabStop = false;
            this.gbStatus.Text = "Connection";
            // 
            // cmbComList
            // 
            this.cmbComList.FormattingEnabled = true;
            this.cmbComList.Location = new System.Drawing.Point(108, 29);
            this.cmbComList.Name = "cmbComList";
            this.cmbComList.Size = new System.Drawing.Size(278, 21);
            this.cmbComList.TabIndex = 8;
            // 
            // btConnect
            // 
            this.btConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConnect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btConnect.Location = new System.Drawing.Point(10, 29);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(90, 21);
            this.btConnect.TabIndex = 7;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.gbSetup);
            this.tabPage4.Controls.Add(this.gbDateZone);
            this.tabPage4.Controls.Add(this.gbWaktuSolat);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(405, 319);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "InfoSolat";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // gbSetup
            // 
            this.gbSetup.Controls.Add(this.lblSyncDate);
            this.gbSetup.Controls.Add(this.label17);
            this.gbSetup.Controls.Add(this.label16);
            this.gbSetup.Controls.Add(this.lblSync);
            this.gbSetup.Controls.Add(this.label1);
            this.gbSetup.Controls.Add(this.lblDateStart);
            this.gbSetup.Controls.Add(this.label2);
            this.gbSetup.Controls.Add(this.lblDateEnd);
            this.gbSetup.ForeColor = System.Drawing.Color.Blue;
            this.gbSetup.Location = new System.Drawing.Point(11, 6);
            this.gbSetup.Name = "gbSetup";
            this.gbSetup.Size = new System.Drawing.Size(387, 64);
            this.gbSetup.TabIndex = 5;
            this.gbSetup.TabStop = false;
            this.gbSetup.Text = "Sync Data";
            // 
            // lblSyncDate
            // 
            this.lblSyncDate.AutoSize = true;
            this.lblSyncDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSyncDate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSyncDate.Location = new System.Drawing.Point(89, 40);
            this.lblSyncDate.Name = "lblSyncDate";
            this.lblSyncDate.Size = new System.Drawing.Size(51, 13);
            this.lblSyncDate.TabIndex = 11;
            this.lblSyncDate.Text = "Not Sycn";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label17.Location = new System.Drawing.Point(9, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "Sync Date :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label16.Location = new System.Drawing.Point(9, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 9;
            this.label16.Text = "Status  :";
            // 
            // lblSync
            // 
            this.lblSync.AutoSize = true;
            this.lblSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSync.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSync.Location = new System.Drawing.Point(89, 16);
            this.lblSync.Name = "lblSync";
            this.lblSync.Size = new System.Drawing.Size(51, 13);
            this.lblSync.TabIndex = 1;
            this.lblSync.Text = "Not Sycn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(204, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date Start :";
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateStart.Location = new System.Drawing.Point(283, 16);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(31, 13);
            this.lblDateStart.TabIndex = 6;
            this.lblDateStart.Text = "(Null)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(204, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date End :";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblDateEnd.Location = new System.Drawing.Point(283, 40);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(31, 13);
            this.lblDateEnd.TabIndex = 8;
            this.lblDateEnd.Text = "(Null)";
            // 
            // gbDateZone
            // 
            this.gbDateZone.Controls.Add(this.lblZone);
            this.gbDateZone.Controls.Add(this.cmbLokasi);
            this.gbDateZone.Controls.Add(this.cmbState);
            this.gbDateZone.Controls.Add(this.label11);
            this.gbDateZone.Controls.Add(this.label3);
            this.gbDateZone.ForeColor = System.Drawing.Color.Blue;
            this.gbDateZone.Location = new System.Drawing.Point(11, 76);
            this.gbDateZone.Name = "gbDateZone";
            this.gbDateZone.Size = new System.Drawing.Size(388, 126);
            this.gbDateZone.TabIndex = 4;
            this.gbDateZone.TabStop = false;
            this.gbDateZone.Text = "Date/Zone";
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblZone.Location = new System.Drawing.Point(59, 52);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(32, 13);
            this.lblZone.TabIndex = 15;
            this.lblZone.Text = "Zone";
            this.lblZone.TextChanged += new System.EventHandler(this.lblZone_TextChanged);
            // 
            // cmbLokasi
            // 
            this.cmbLokasi.FormattingEnabled = true;
            this.cmbLokasi.Location = new System.Drawing.Point(117, 46);
            this.cmbLokasi.Name = "cmbLokasi";
            this.cmbLokasi.Size = new System.Drawing.Size(265, 21);
            this.cmbLokasi.TabIndex = 14;
            this.cmbLokasi.SelectedIndexChanged += new System.EventHandler(this.cmbLokasi_SelectedIndexChanged);
            this.cmbLokasi.SelectedValueChanged += new System.EventHandler(this.cmbLokasi_SelectedValueChanged);
            // 
            // cmbState
            // 
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Location = new System.Drawing.Point(59, 22);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(323, 21);
            this.cmbState.TabIndex = 12;
            this.cmbState.SelectedIndexChanged += new System.EventHandler(this.cmbState_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "State :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zone :";
            // 
            // gbWaktuSolat
            // 
            this.gbWaktuSolat.Controls.Add(this.lblIsyak);
            this.gbWaktuSolat.Controls.Add(this.lblMaghrib);
            this.gbWaktuSolat.Controls.Add(this.lblAsar);
            this.gbWaktuSolat.Controls.Add(this.lblZohor);
            this.gbWaktuSolat.Controls.Add(this.lblSyuruk);
            this.gbWaktuSolat.Controls.Add(this.lblSubuh);
            this.gbWaktuSolat.Controls.Add(this.lblImsak);
            this.gbWaktuSolat.Controls.Add(this.label10);
            this.gbWaktuSolat.Controls.Add(this.label9);
            this.gbWaktuSolat.Controls.Add(this.label8);
            this.gbWaktuSolat.Controls.Add(this.label7);
            this.gbWaktuSolat.Controls.Add(this.label6);
            this.gbWaktuSolat.Controls.Add(this.label5);
            this.gbWaktuSolat.Controls.Add(this.label4);
            this.gbWaktuSolat.ForeColor = System.Drawing.Color.Blue;
            this.gbWaktuSolat.Location = new System.Drawing.Point(11, 208);
            this.gbWaktuSolat.Name = "gbWaktuSolat";
            this.gbWaktuSolat.Size = new System.Drawing.Size(388, 105);
            this.gbWaktuSolat.TabIndex = 3;
            this.gbWaktuSolat.TabStop = false;
            this.gbWaktuSolat.Text = "Waktu Solat";
            // 
            // lblIsyak
            // 
            this.lblIsyak.AutoSize = true;
            this.lblIsyak.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblIsyak.Location = new System.Drawing.Point(317, 26);
            this.lblIsyak.Name = "lblIsyak";
            this.lblIsyak.Size = new System.Drawing.Size(68, 13);
            this.lblIsyak.TabIndex = 17;
            this.lblIsyak.Text = "00:00:00 PM";
            // 
            // lblMaghrib
            // 
            this.lblMaghrib.AutoSize = true;
            this.lblMaghrib.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblMaghrib.Location = new System.Drawing.Point(195, 72);
            this.lblMaghrib.Name = "lblMaghrib";
            this.lblMaghrib.Size = new System.Drawing.Size(68, 13);
            this.lblMaghrib.TabIndex = 16;
            this.lblMaghrib.Text = "00:00:00 PM";
            // 
            // lblAsar
            // 
            this.lblAsar.AutoSize = true;
            this.lblAsar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAsar.Location = new System.Drawing.Point(195, 49);
            this.lblAsar.Name = "lblAsar";
            this.lblAsar.Size = new System.Drawing.Size(68, 13);
            this.lblAsar.TabIndex = 15;
            this.lblAsar.Text = "00:00:00 PM";
            // 
            // lblZohor
            // 
            this.lblZohor.AutoSize = true;
            this.lblZohor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblZohor.Location = new System.Drawing.Point(195, 26);
            this.lblZohor.Name = "lblZohor";
            this.lblZohor.Size = new System.Drawing.Size(68, 13);
            this.lblZohor.TabIndex = 14;
            this.lblZohor.Text = "00:00:00 PM";
            // 
            // lblSyuruk
            // 
            this.lblSyuruk.AutoSize = true;
            this.lblSyuruk.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSyuruk.Location = new System.Drawing.Point(64, 72);
            this.lblSyuruk.Name = "lblSyuruk";
            this.lblSyuruk.Size = new System.Drawing.Size(68, 13);
            this.lblSyuruk.TabIndex = 13;
            this.lblSyuruk.Text = "00:00:00 AM";
            // 
            // lblSubuh
            // 
            this.lblSubuh.AutoSize = true;
            this.lblSubuh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblSubuh.Location = new System.Drawing.Point(64, 49);
            this.lblSubuh.Name = "lblSubuh";
            this.lblSubuh.Size = new System.Drawing.Size(68, 13);
            this.lblSubuh.TabIndex = 12;
            this.lblSubuh.Text = "00:00:00 AM";
            // 
            // lblImsak
            // 
            this.lblImsak.AutoSize = true;
            this.lblImsak.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblImsak.Location = new System.Drawing.Point(64, 26);
            this.lblImsak.Name = "lblImsak";
            this.lblImsak.Size = new System.Drawing.Size(68, 13);
            this.lblImsak.TabIndex = 11;
            this.lblImsak.Text = "00:00:00 AM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(269, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Isyak :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(138, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Maghrib :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(138, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Asar :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(138, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Zohor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(9, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Syuruk :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(9, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Subuh :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Imsak :";
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlStatus,
            this.tlsSeen});
            this.statusStrip1.Location = new System.Drawing.Point(0, 349);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(409, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlStatus
            // 
            this.tlStatus.Name = "tlStatus";
            this.tlStatus.Size = new System.Drawing.Size(79, 17);
            this.tlStatus.Text = "Disconnected";
            // 
            // tlsSeen
            // 
            this.tlsSeen.Name = "tlsSeen";
            this.tlsSeen.Size = new System.Drawing.Size(17, 17);
            this.tlsSeen.Text = "\"\"";
            // 
            // frmTerminalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 371);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(tabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTerminalData";
            this.ShowIcon = false;
            this.Text = "Terminal Data";
            this.Deactivate += new System.EventHandler(this.frmTerminalData_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TerminalControl_FormClosed);
            this.Load += new System.EventHandler(this.TerminalControl_Load);
            tabMenu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbReceiver.ResumeLayout(false);
            this.gbTransmiter.ResumeLayout(false);
            this.gbTransmiter.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbStatus.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.gbSetup.ResumeLayout(false);
            this.gbSetup.PerformLayout();
            this.gbDateZone.ResumeLayout(false);
            this.gbDateZone.PerformLayout();
            this.gbWaktuSolat.ResumeLayout(false);
            this.gbWaktuSolat.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.GroupBox gbReceiver;
        private System.Windows.Forms.GroupBox gbTransmiter;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.RichTextBox rtxtReceiver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.CheckBox cbSendTime;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox gbStatus;
        private System.Windows.Forms.ComboBox cmbComList;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.CheckBox cbSendDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvEvent;
        private System.Windows.Forms.CheckBox cbSendNews;
        private System.Windows.Forms.ListBox lbNews;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblDeleted;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.Label lblTomorrow;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox gbDateZone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbWaktuSolat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDateEnd;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblIsyak;
        private System.Windows.Forms.Label lblMaghrib;
        private System.Windows.Forms.Label lblAsar;
        private System.Windows.Forms.Label lblZohor;
        private System.Windows.Forms.Label lblSyuruk;
        private System.Windows.Forms.Label lblSubuh;
        private System.Windows.Forms.Label lblImsak;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbSetup;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStopBits;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtParity;
        private System.Windows.Forms.TextBox txtBaudRate;
        private System.Windows.Forms.Label lblSync;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblSyncDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ToolStripStatusLabel tlsSeen;
        private System.Windows.Forms.ComboBox cmbLokasi;
        private System.Windows.Forms.Label lblZone;
    }
}

