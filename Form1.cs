using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bluetooth_DotMetrix
{
    public partial class frmEventRegister : Form
    {
        public frmEventRegister()
        {
            InitializeComponent();
        }

        private void frmEventRegister_Load(object sender, EventArgs e)
        {
            loadParamitter(EventRepeat);

            //initial cmbrepeat
            cmbRepeat.Items.Add("Once");
            cmbRepeat.Items.Add("Every Days");
            cmbRepeat.Items.Add("Every Working Days");
            cmbRepeat.Items.Add(DayOfWeek.Monday);
            cmbRepeat.Items.Add(DayOfWeek.Tuesday);
            cmbRepeat.Items.Add(DayOfWeek.Wednesday);
            cmbRepeat.Items.Add(DayOfWeek.Thursday);
            cmbRepeat.Items.Add(DayOfWeek.Friday);
            cmbRepeat.Items.Add(DayOfWeek.Saturday);
            cmbRepeat.Items.Add(DayOfWeek.Sunday);

            //
        }

        public DateTime EventDate { get; set; }
        public DateTime EventTime { get; set; }
        public string EventText { get; set; }
        public string EventRepeat { get; set; }
        public int EventEditIndex { get; set; }

        private void loadParamitter(string dataCature)
        {
            if (dataCature != null)
            {
                cmbRepeat.Text = EventRepeat;
                pickerTime.Value = EventTime;
                pickerDate.Value = EventDate;
                rtxtEventText.Text = EventText;
            }
            else
            {
                pickerDate.Format = DateTimePickerFormat.Custom;
                pickerDate.Value = DateTime.Now;
                pickerDate.CustomFormat = "dd/MM/yyyy";
                pickerTime.Format = DateTimePickerFormat.Time;
                pickerTime.ShowUpDown = true;
                pickerTime.CustomFormat = "hh:mm:ss tt";
            }
        }

        private void btDone(object sender, EventArgs e)
        {
            frmTerminalData formTerminal = new frmTerminalData();
            
            if (rtxtEventText.Text == null)
            {
                MessageBox.Show("Text is empty", "Un-complete Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EventRepeat = cmbRepeat.Text;
            EventTime = pickerTime.Value;
            EventDate = pickerDate.Value;
            EventText = rtxtEventText.Text;

            formTerminal.EventEditIndex = EventEditIndex;
            formTerminal.EventTime = pickerTime.Value;
            formTerminal.EventDate = pickerDate.Value;
            formTerminal.EventText = rtxtEventText.Text;
            formTerminal.EventRepeat = cmbRepeat.Text;

            formTerminal.saveEvent();

            this.Close();
           
        }
    }
}
