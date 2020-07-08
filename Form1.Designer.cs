namespace Bluetooth_DotMetrix
{
    partial class frmEventRegister
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
            this.pickerDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.pickerTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtxtEventText = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbRepeat = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickerDate
            // 
            this.pickerDate.Checked = false;
            this.pickerDate.CustomFormat = "dd/MM/yyyy";
            this.pickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerDate.Location = new System.Drawing.Point(128, 19);
            this.pickerDate.Name = "pickerDate";
            this.pickerDate.Size = new System.Drawing.Size(134, 20);
            this.pickerDate.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(270, 27);
            this.button1.TabIndex = 13;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btDone);
            // 
            // pickerTime
            // 
            this.pickerTime.CustomFormat = "hh:mm:ss tt";
            this.pickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickerTime.Location = new System.Drawing.Point(6, 19);
            this.pickerTime.Name = "pickerTime";
            this.pickerTime.Size = new System.Drawing.Size(114, 20);
            this.pickerTime.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pickerTime);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 53);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtxtEventText);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 59);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // rtxtEventText
            // 
            this.rtxtEventText.Location = new System.Drawing.Point(4, 19);
            this.rtxtEventText.Name = "rtxtEventText";
            this.rtxtEventText.Size = new System.Drawing.Size(259, 36);
            this.rtxtEventText.TabIndex = 8;
            this.rtxtEventText.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbRepeat);
            this.groupBox3.Controls.Add(this.pickerDate);
            this.groupBox3.Location = new System.Drawing.Point(12, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(268, 54);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Repeat";
            // 
            // cmbRepeat
            // 
            this.cmbRepeat.FormattingEnabled = true;
            this.cmbRepeat.Location = new System.Drawing.Point(6, 18);
            this.cmbRepeat.Name = "cmbRepeat";
            this.cmbRepeat.Size = new System.Drawing.Size(114, 21);
            this.cmbRepeat.TabIndex = 7;
            this.cmbRepeat.Text = "Once";
            // 
            // frmEventRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 229);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEventRegister";
            this.Text = "Add New Event";
            this.Load += new System.EventHandler(this.frmEventRegister_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker pickerDate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker pickerTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtxtEventText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbRepeat;
    }
}