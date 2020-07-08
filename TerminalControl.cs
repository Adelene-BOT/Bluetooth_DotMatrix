using Nancy.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Security.Policy;

namespace Bluetooth_DotMetrix
{

    public partial class frmTerminalData : Form
    {
        private SerialPort ComPort = new SerialPort();
        private DateTime currentDateTime = DateTime.Now;
        ContextMenuStrip rightClickMenu = new ContextMenuStrip();
        private int countDeleted = 0, countToday = 0, countTomorrow = 0, countOverdue = 0;
        private Boolean isOnce = true;
        private Boolean isUpdateDone = false;
        public Boolean isEdit = false;
        private String dateSeen = "";
        private String timeSeen = "";
        private Dictionary<string, string> ZoneCodePair = new Dictionary<string, string>();
        

        private string[] Johor = { "JHR01", "JHR02", "JHR03", "JHR04" };
        private string[] Kedah = { "KDH01", "KDH02", "KDH03", "KDH04", "KDH05", "KDH06", "KDH07" };
        private string[] Kelantan = { "KTN01", "KTN03" };
        private string[] Melaka = { "MLK01" };
        private string[] NegeriSembilan = { "NGS01", "NGS02" };
        private string[] Pahang = { "PHG01", "PHG02", "PHG03", "PHG04", "PHG05", "PHG06" };
        private string[] Perak = { "PRK01", "PRK02", "PRK03", "PRK04", "PRK05", "PRK06", "PRK07" };
        private string[] Perlis = { "PLS01" };
        private string[] PulauPinang = { "PNG01" };
        private string[] Sabah = { "SBH01", "SBH02", "SBH03", "SBH04", "SBH05", "SBH06", "SBH07", "SBH08", "SBH09" };
        private string[] Serawak = { "SWK01", "SWK02", "SWK03", "SWK04", "SWK05", "SWK06", "SWK07", "SWK08", "SWK09" };
        private string[] Selangor = { "SGR01", "SGR02", "SGR03" };
        private string[] Terengganu = { "TRG01", "TRG02", "TRG03", "TRG04" };
        private string[] Putrajaya = { "WLY01" };
        private string[] KualaLumpur = { "WLY01" };
        private string[] Labuan = { "WLY02" };

        public int EventEditIndex { get; set; }
        public DateTime EventTime { get; set; }
        public DateTime EventDate { get; set; }
        public string EventText { get; set; }
        public string EventRepeat { get; set; }

        public class responseData
        {
            public List<string> states { get; set; }
            public string zone { get; set; }
            public string start { get; set; }
            public string end { get; set; }
            public List<string> lokasi { get; set; }
            public List<string> locations { get; set; }
            public List<string> prayer_times { get; set; }

        }

        
        

        public string datesSolat { get; set; }
        public int dateStamp { get; set; }
        public string dateStampString { get; set;}
        public string imsak { get; set; }
        public string subuh { get; set; }
        public string syuruk { get; set; }
        public string zohor { get; set; }
        public string asar { get; set; }
        public string maghrib { get; set; }
        public string isyak { get; set; }

        public frmTerminalData()
        {
            InitializeComponent();
            
        }

        private void TerminalControl_Load(object sender, EventArgs e)
        {
            if (!connectToBluetoothModule()) //<----if fail to connect paired bluetooth device
            {
                disconnect();
            }
            timer1.Start();

            cbSendDate.Checked = Settings1.Default.isSendDate;
            cbSendTime.Checked = Settings1.Default.isSendTime;
            cbSendNews.Checked = Settings1.Default.isSendNews;
            lblZone.Text = Settings1.Default.zone;
            cmbState.Text = Settings1.Default.state;
            cmbLokasi.Text = Settings1.Default.lokasiZone;
            lblSyncDate.Text = readDateFromSetting();

            NullCheck();

            EventInitialize();
            restoreEvent();
            restoreNews();
            getWaktuSolat(Settings1.Default.zone);
            autoRegisterWaktuSolat();
        }

        private void NullCheck()
        {
            Boolean isNull = false;
            if (string.IsNullOrEmpty(Settings1.Default.zone)) { Settings1.Default.zone = "KTN01"; isNull = true; }
            if (string.IsNullOrEmpty(Settings1.Default.state)){ Settings1.Default.state = "Kelantan"; isNull = true; }
            if (string.IsNullOrEmpty(Settings1.Default.lokasiZone)) {Settings1.Default.lokasiZone = "Kota Bharu"; isNull = true;}

            if (isNull)
            {
                Settings1.Default.Save();
                cmbState.Text = Settings1.Default.state;
                cmbLokasi.Text = Settings1.Default.lokasiZone;
                lblZone.Text = Settings1.Default.zone;
            }
        }
        
        private void EventInitialize()
        {
            lvEvent.View = View.Details;
            lvEvent.GridLines = true;
            lvEvent.FullRowSelect = true;
            
            //Add column header
            lvEvent.Columns.Add("Time", 100, HorizontalAlignment.Left);
            lvEvent.Columns.Add("Date", 100, HorizontalAlignment.Left);
            lvEvent.Columns.Add("Event Text", 500, HorizontalAlignment.Left);
            lvEvent.Columns.Add("CreateDate", 150, HorizontalAlignment.Left);
            lvEvent.Columns.Add("CreateBy", 100, HorizontalAlignment.Left);
            lvEvent.Columns.Add("Status", 100, HorizontalAlignment.Left);

        }
        private string readDateFromSetting()
        {
            string hari = Settings1.Default.waktuSolatHari.ToString();
            string bulan = Settings1.Default.waktuSolatBulan.ToString();
            if (Settings1.Default.waktuSolatBulan > 10) bulan = "0" + Settings1.Default.waktuSolatBulan;
            if (Settings1.Default.waktuSolatHari > 10) bulan = "0" + Settings1.Default.waktuSolatBulan;
            return string.Format("{2}-{1}-{0}", Settings1.Default.waktusolatTahun, bulan, hari);
        }
        private void regiterCom()
        {
            string[] ports = SerialPort.GetPortNames();
            cmbComList.Items.Clear();
            foreach (string port in ports) cmbComList.Items.Add(port);
        }
        private void setDateTime(DateTime myDateTime)
        {
            txtTime.Text = myDateTime.ToString("hh:mm:ss tt");
            txtDate.Text = myDateTime.ToString("dddd dd MMMM yyyy");
        }
        private Boolean connectToBluetoothModule()
        {
            //discover available serial port
            Boolean isCOMFound = false;
            string[] ports = SerialPort.GetPortNames();
            string selectedCom = Settings1.Default.CurrentCOM;
            foreach(string port in ports)
            {
                if(port == selectedCom)
                {
                    isCOMFound = true;
                    break;
                }
            }

            if (isCOMFound)
            {
                cmbComList.Text = selectedCom;
                if (isConnectTo(selectedCom)) return true;
            }
            else
            {
                MessageBox.Show("Bluetooth device not found. you can procced with manual connection", "Device Interface", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            Boolean isPortOpen = ComPort.IsOpen;
            return isPortOpen;

        }

        private Boolean isConnectTo(string com)
        {
            Boolean error = false;
            
            //if yes than Set The Port's settings
            ComPort = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);

            try  //always try to use this try and catch method to open your port. 
                    //if there is an error your program will not display a message instead of freezing.
            {
                //Open Port
                ComPort.Open();
                //ComPort.DataReceived += SerialPortDataReceived;  //Check for received data. When there is data in the receive buffer,
                whenConnectOrDisconnect(true);
            }                                                   //it will raise this event, we need to subscribe to it to know when there is data


            catch (UnauthorizedAccessException) { error = true; }
            catch (System.IO.IOException) { error = true; }
            catch (ArgumentException) { error = true; }

            if (error)
            {
                txtBaudRate.Text = "N/A";
                txtParity.Text = "N/A";
                txtData.Text = "N/A";
                txtStopBits.Text = "N/A";
                MessageBox.Show(this, string.Format("Could not open the {0}. Most likely it is already in use, has been removed, or is unavailable.",com), "Device unavailable", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            if (!error)
            {
                txtBaudRate.Text = ComPort.BaudRate.ToString();
                txtParity.Text = ComPort.Parity.ToString();
                txtData.Text = ComPort.DataBits.ToString();
                txtStopBits.Text = ComPort.StopBits.ToString();
            }

            return true;
        }

        private void disconnect()
        {
            ComPort.Close();
            whenConnectOrDisconnect(false);
        }

        private void sendData(string textData)
        {
            try
            { 
                byte[] NL = { 10 };

                rtxtReceiver.Clear();

                //give the status 
                setStatusbar("Sending");

                //set timeout to ensure device still available
                ComPort.WriteTimeout = 10000;

                // Send the user's text straight out the port 
                ComPort.Write(textData);

                //Add line ending
                ComPort.Write(NL, 0, NL.Length);

                // Show in the terminal window 
                rtxtReceiver.ForeColor = Color.Green;    //write sent text data in green colour              
                                                         //clear screen after sending date

                
            }
            catch (Exception e)
            {
                disconnect();
                MessageBox.Show("Device was diconnected", e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void setStatusbar(string status)
        {
            tlStatus.Text = string.Format("Status :{0}", status);
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            rtxtReceiver.Clear();
        }

        private void txtSend_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                sendData(txtSend.Text);
                txtSend.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
                readResponse();
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            sendData(txtSend.Text);
            txtSend.Clear();
            readResponse();
        }

        private void sendTimeDateNews(DateTime myDateTime)
        {

            if (myDateTime.ToString("ss") == "00" && isOnce)//send every minutes
            {
                if (cbSendTime.Checked && ComPort.IsOpen) sendData(currentDateTime.ToString("h:mmt"));
                if (cbSendDate.Checked && ComPort.IsOpen) sendData(currentDateTime.ToString("dddd, d MMMM yyyy"));
                if (cbSendNews.Checked && cbSendNews.Enabled && ComPort.IsOpen) foreach (string News in lbNews.Items) sendData(News);
                isOnce = false;
                readResponse();

                if(lblSync.Text == "Not Updated")
                {
                    if(CheckForInternetConnection())
                    {
                        getWaktuSolat(lblZone.Text);
                    }
                }

            }
            else isOnce = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentDateTime = DateTime.Now;
            setDateTime(currentDateTime);
            if (ComPort.IsOpen)
            {
                autoUpdate();
                setStatusbar("Connected");
                if (!EventCheck(currentDateTime))
                    sendTimeDateNews(currentDateTime);


            }
            else
            {
                setStatusbar("Disconnected");
                timer1.Stop();

            }

            if (string.IsNullOrEmpty(dateSeen))
            {
                tlsSeen.Text = "Never seen";
            }
            else
            { 
                tlsSeen.Text = string.Format("Last seen {0} {1}", dateSeen, timeSeen);
            }

            if (currentDateTime.ToString("dd-MM-yyy") == dateSeen)
            {
                tlsSeen.Text = string.Format("Last seen {0} {1}", "Today", timeSeen);
            }

        }
        private void TerminalControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings1.Default.CurrentCOM = cmbComList.Text;
            Settings1.Default.isSendDate = cbSendDate.Checked;
            Settings1.Default.isSendTime = cbSendTime.Checked;
            Settings1.Default.isSendNews = cbSendNews.Checked;
            Settings1.Default.zone = lblZone.Text;
            Settings1.Default.state = cmbState.Text;
            Settings1.Default.lokasiZone = cmbLokasi.Text;
            Settings1.Default.Save();

            if (ComPort.IsOpen) disconnect();

            saveEvent();
        }

        private void txtSend_KeyUp(object sender, KeyEventArgs e)
        {
            e.Handled = false;
            e.SuppressKeyPress = false;
        }


        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            if (tlStatus.Text.Contains("Disconnected")) tlStatus.BackColor = Color.Red;
            if (tlStatus.Text.Contains("Connected")) tlStatus.BackColor = Color.Green;
            if (tlStatus.Text.Contains("Sending") || tlStatus.Text.Contains("Receiving")) tlStatus.BackColor = Color.Yellow;
        }

        private void rtxtReceiver_TextChanged(object sender, EventArgs e)
        {
            //give status
            setStatusbar("Receiving");
        }
        private void whenConnectOrDisconnect(Boolean isConnect)
        {
            if(isConnect)
            {
                btConnect.Text = "Disconnect";
                cmbComList.Enabled = false;
                sendData(string.Format("Connected to {0}", Environment.MachineName));
                gbTransmiter.Enabled = true;
            }
            else
            {
                btConnect.Text = "Connect";
                gbTransmiter.Enabled = false;
                cmbComList.Enabled = true;
                regiterCom();
                timer1.Stop();
            }
        }
        private void btConnect_Click(object sender, EventArgs e)
        {
            if(ComPort.IsOpen)
            {
                disconnect();
            }
            else
            {
                Boolean isConnected = isConnectTo(cmbComList.Text);
                timer1.Start();
            }
        }

        public void saveEvent()
        {
            string filename = "EventData.txt";

            using (StreamWriter data = new StreamWriter(filename))
            {
                foreach (ListViewItem item in lvEvent.Items)
                {
                    for (int i = 0; i < item.IndentCount; i++) if (item.SubItems[i].Text == null) item.SubItems[i].Text = "Null";
                    data.WriteLine(string.Format("{0};{1};{2};{3};{4};{5};", item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text));
                }
            }
        }
        public void restoreEvent()
        {
            string filename = "EventData.txt";
            if (!File.Exists(filename)) return;
            lvEvent.Items.Clear();
            foreach (string line in File.ReadAllLines(filename))
            {
                string[] datafromText = line.Split(';');
                ListViewItem item = new ListViewItem(datafromText);
                lvEvent.Items.Add(item);
            }
        }
        public void restoreNews()
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string filename = "NewsData.txt";
            if (!File.Exists(filename)) return;
            lbNews.Items.Clear();
            foreach (string line in File.ReadAllLines(filename))
            {
                string[] datafromText = line.Split(';');
                DateTime today = DateTime.Now;
                DateTime NewsDate;
                Boolean isSuccess = DateTime.TryParseExact(datafromText[0], "dd-MM-yyyy", provider, DateTimeStyles.None, out NewsDate);
                if (isSuccess && today.Day == NewsDate.Day && today.Month == NewsDate.Month && today.Year == NewsDate.Year)
                {
                    lbNews.Items.Add(datafromText[1]);
                }      
            }

            if (lbNews.Items.Count > 0) { cbSendNews.Enabled = true; }
            else { cbSendNews.Enabled = false; }
        }


        private void lvEvent_MouseDown(object sender, MouseEventArgs e)
        {
            rightClickMenu.Items.Clear();
            rightClickMenu.Items.Add("Add", null, eventAdd);
            if (lvEvent.SelectedItems.Count > 0)rightClickMenu.Items.Add("Edit", null, eventEdit);
            if (lvEvent.SelectedItems.Count > 0) rightClickMenu.Items.Add("Delete",null, eventRemove);

            switch (e.Button)
            {
                case MouseButtons.Right:
                {
                    rightClickMenu.Show(this, new Point(e.X, e.Y+120));//places the menu at the pointer position
                }
                break;
            }
        }



        private void eventAdd(object sender, EventArgs e)
        {
            frmEventRegister formEvent = new frmEventRegister();
            formEvent.ShowDialog();
            string EventRepeat = formEvent.EventRepeat;
            
            switch (EventRepeat)
            {
                case "Once": { setEventOnce(formEvent,formEvent.EventDate); break; }
                case "Every Days": { setEventEveryDays(formEvent); break; }
                case "Every Working Days": { setEventEveryWorkingDays(formEvent); break; }
                case null: break;
                default: {setEventOnDay(formEvent, EventRepeat); break;}
            }
        }
        private void setEventOnDay(frmEventRegister formEvent, string setDay)
        {
            //Add items in the listview
            string[] arr = new string[6];
            ListViewItem itm;
            DateTime createDateTime = DateTime.Now;

            //Add item
            arr[0] = formEvent.EventTime.ToString("hh:mm:ss tt");
            arr[1] = setDay; //<<<<---
            arr[2] = formEvent.EventText;
            arr[3] = createDateTime.ToString("dd-MM-yy HH:mm:ss");
            arr[4] = Environment.MachineName.ToString();
            arr[5] = "New";
            itm = new ListViewItem(arr);
            lvEvent.Items.Add(itm);

            
        }
        private void setEventOnce(frmEventRegister formEvent, DateTime EventDate)
        {
            //Add items in the listview
            string[] arr = new string[6];
            ListViewItem itm;
            DateTime createDateTime = DateTime.Now;

            //Add item
            arr[0] = formEvent.EventTime.ToString("hh:mm:ss tt");
            arr[1] = EventDate.ToString("dd-MM-yyyy");
            arr[2] = formEvent.EventText;
            arr[3] = createDateTime.ToString("dd-MM-yyyy HH:mm:ss");
            arr[4] = Environment.MachineName.ToString();
            arr[5] = "New";
            itm = new ListViewItem(arr);
            lvEvent.Items.Add(itm);

        }
        private void setEventEveryWorkingDays(frmEventRegister formEvent)
        {
            //Add items in the listview
            string[] arr = new string[6];
            DayOfWeek[] days = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday };
            ListViewItem itm;
            DateTime createDateTime = DateTime.Now;

            foreach (DayOfWeek day in days)
            {
                //Add item
                arr[0] = formEvent.EventTime.ToString("hh:mm:ss tt");
                arr[1] = day.ToString();
                arr[2] = formEvent.EventText;
                arr[3] = createDateTime.ToString("dd-MM-yyyy HH:mm:ss");
                arr[4] = Environment.MachineName.ToString();
                arr[5] = "New";
                itm = new ListViewItem(arr);
                lvEvent.Items.Add(itm);
            }
        }
        private void setEventEveryDays(frmEventRegister formEvent)
        {
            //Add items in the listview
            string[] arr = new string[6];
            DayOfWeek[] days = { DayOfWeek.Monday, DayOfWeek.Tuesday,DayOfWeek.Wednesday,DayOfWeek.Thursday,DayOfWeek.Friday,DayOfWeek.Saturday,DayOfWeek.Sunday};
            ListViewItem itm;
            DateTime createDateTime = DateTime.Now;

            foreach (DayOfWeek day in days)
            {
                //Add item
                arr[0] = formEvent.EventTime.ToString("hh:mm:ss tt");
                arr[1] = day.ToString();
                arr[2] = formEvent.EventText;
                arr[3] = createDateTime.ToString("dd-MM-yyyy HH:mm:ss");
                arr[4] = Environment.MachineName.ToString();
                arr[5] = "New";
                itm = new ListViewItem(arr);
                lvEvent.Items.Add(itm);
            }
        }

        private void eventRemove(object sender, EventArgs e)
        {
            for(int index=0; index<lvEvent.Items.Count; index++)
            { 
                if(lvEvent.Items[index].Selected)
                lvEvent.Items.RemoveAt(index);
            }

        }
        private void eventEdit(object sender, EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            frmEventRegister regiterEvent = new frmEventRegister();
            DateTime eventDate;
            isEdit = true;
            int index = 0;
            for (index = 0; index < lvEvent.Items.Count; index++)
            {
                if (lvEvent.Items[index].Selected)
                {
                    regiterEvent.EventEditIndex = index;
                    ListViewItem item = lvEvent.Items[index];
                    
                    regiterEvent.EventTime = Convert.ToDateTime(item.SubItems[0].Text);

                    Boolean isSuccess = DateTime.TryParseExact(item.SubItems[1].Text, "dd-MM-yyyy", provider, DateTimeStyles.None, out eventDate);

                    regiterEvent.EventRepeat = item.SubItems[1].Text;

                    if (isSuccess)
                    {
                        regiterEvent.EventDate = eventDate;
                        regiterEvent.EventRepeat = "Once";
                    }

                    regiterEvent.EventText = item.SubItems[2].Text;
                                      
                    
                    break;
                }
            }
            regiterEvent.Show();

            eventEditCapture(EventTime, EventDate, EventRepeat, EventText);

        }
        public void eventEditCapture(DateTime EditTime,DateTime EditDate, string EditRepeat, string EditText)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string[] arr = new string[6];
            ListViewItem itm;
            DateTime createDateTime = DateTime.Now;
    
            //Add item
            arr[0] = EditTime.ToString("hh:mm:ss tt");
            arr[1] = EditRepeat;
            if(EditRepeat.Contains("Once")) arr[1] = EditDate.ToString("dd-MM-yyyy");
            arr[2] = EditText;
            arr[3] = createDateTime.ToString("dd-MM-yyyy HH:mm:ss");
            arr[4] = Environment.MachineName.ToString();
            arr[5] = "Edited";
            itm = new ListViewItem(arr);

            lvEvent.Items.Add(itm);

            isEdit = false;
        }

        private Boolean EventCheck(DateTime myDateTime)
        {
            string currentTime = myDateTime.ToString("hh:mm:ss tt");
            string currentDate = myDateTime.ToString("dd-MM-yyyy");
            string currentWeekday = myDateTime.ToString("dddd");
            Boolean isFound = false;
            int repeat = 5; //repeat for 5minit

            foreach(ListViewItem  match in lvEvent.Items)
            {
                DateTime myCaledarTime = DateTime.Parse(match.SubItems[0].Text);
                TimeSpan myTimeSpend = myDateTime.Subtract(myCaledarTime);
                int totalMinutes = Convert.ToInt32(myTimeSpend.TotalMinutes);

                EventManagement(myDateTime,  match.Index);

                if (Convert.ToInt32(myDateTime.Second) == 1 && totalMinutes > 0  && totalMinutes <= repeat && (match.SubItems[1].Text.Contains(currentDate) || match.SubItems[1].Text.Contains(currentWeekday)))
                {
                    sendData(string.Format(" {0} {1} minutes ago", match.SubItems[2].Text,totalMinutes));
                    isFound = true;
                }

                if (match.SubItems[0].Text.Contains(currentTime) && match.SubItems[1].Text.Contains(currentDate))
                {
                    sendData(string.Format(" {0} ", match.SubItems[2].Text));
                    isFound = true;
                }

                if(match.SubItems[0].Text.Contains(currentTime) && match.SubItems[1].Text.Contains(currentWeekday))
                {
                    sendData(string.Format(" {0} ", match.SubItems[2].Text));
                    isFound = true;
                }
            }
            return isFound;
        }
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
        private void getState()
        {
        
            MyWebRequest myRequest = new MyWebRequest("http://api.azanpro.com/zone/states.json", "GET");
            string myJsonData = myRequest.GetResponse();

            var myDetails = new JavaScriptSerializer().Deserialize<responseData>(myJsonData);

            foreach(string negeri in myDetails.states) cmbState.Items.Add(negeri);

        }

        private void getLokasi(string zone)
        {

            MyWebRequest myRequest = new MyWebRequest(string.Format("http://api.azanpro.com/times/today.json?zone={0}&format=12-hour", zone), "GET");
            string myJsonData = myRequest.GetResponse();

            var myDetails = new JavaScriptSerializer().Deserialize<responseData>(myJsonData);

            foreach (string lokasi in myDetails.locations) ZoneCodePair.Add(lokasi, zone);

        }

        private Boolean getWaktuSolat(string zone)
        {
            if (CheckForInternetConnection())
            {
                getState();
                MyWebRequest myRequest = new MyWebRequest(string.Format("http://api.azanpro.com/times/today.json?zone={0}&format=12-hour", zone), "GET");
                string myJsonData = myRequest.GetResponse();
                var myDetails = new JavaScriptSerializer().Deserialize<responseData>(myJsonData);
                JObject rss = JObject.Parse(myJsonData);
              
                datesSolat = (string)rss["prayer_times"]["date"];
                dateStamp = (int)rss["prayer_times"]["datestamp"];
                imsak = (string)rss["prayer_times"]["imsak"];
                subuh = (string)rss["prayer_times"]["subuh"];
                syuruk = (string)rss["prayer_times"]["syuruk"];
                zohor = (string)rss["prayer_times"]["zohor"];
                asar = (string)rss["prayer_times"]["asar"];
                maghrib = (string)rss["prayer_times"]["maghrib"];
                isyak = (string)rss["prayer_times"]["isyak"];

                dateStampString = convertDateStamp(dateStamp);

                lblDateStart.Text = myDetails.start;
                lblDateEnd.Text = myDetails.end;
                lblImsak.Text = Convert.ToDateTime(imsak).ToString("hh:mm:ss tt");
                lblSubuh.Text = Convert.ToDateTime(subuh).ToString("hh:mm:ss tt");
                lblSyuruk.Text = Convert.ToDateTime(syuruk).ToString("hh:mm:ss tt");
                lblZohor.Text = Convert.ToDateTime(zohor).ToString("hh:mm:ss tt");
                lblAsar.Text = Convert.ToDateTime(asar).ToString("hh:mm:ss tt");
                lblMaghrib.Text = Convert.ToDateTime(maghrib).ToString("hh:mm:ss tt");
                lblIsyak.Text = Convert.ToDateTime(isyak).ToString("hh:mm:ss tt");

                gbDateZone.Enabled = true;
                gbWaktuSolat.Enabled = true;
                lblSync.Text = "Updated";
                return true;
            }
            else
            {
                gbDateZone.Enabled = false;
                gbWaktuSolat.Enabled = false;
                lblSync.Text = "Not Updated";
                return false;
            }


        }

        private string convertDateStamp(int timestampFormat)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestampFormat).ToString("dd") + "-" +
                   new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestampFormat).ToString("MM") + "-" +
                   new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(timestampFormat).ToString("yyyy");
        }

   

   

        private string readResponse()
        {
            String message = "";
            ComPort.ReadTimeout = 5000;
            rtxtReceiver.Text = "";
            try
            {
                message = ComPort.ReadLine();

               

                if (message.Contains("OK"))
                {
                    dateSeen = currentDateTime.ToString("dd-MM-yyyy");
                    timeSeen = currentDateTime.ToString("hh:mmtt");
                }

                ComPort.DiscardInBuffer();
            }
            catch ( Exception e)
            {
                message = "No answer";
            }
            rtxtReceiver.Text = message;
            return message;
        }

    

        private void EventManagement(DateTime myDateTime, int index)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            int days, hours, minutes, seconds;
            string remaindPreriod = "";

            DateTime eventTime = DateTime.Parse(lvEvent.Items[index].SubItems[0].Text);
            DateTime eventDate;
            DateTime eventDateTime = myDateTime;
            Boolean isSuccess = DateTime.TryParseExact(lvEvent.Items[index].SubItems[1].Text,"dd-MM-yyyy", provider, DateTimeStyles.None, out eventDate);
            if (isSuccess)
            {
                string[] dateFromData = lvEvent.Items[index].SubItems[1].Text.Split('-');
                eventDateTime = new DateTime(Convert.ToInt32(dateFromData[2]), Convert.ToInt32(dateFromData[1]), Convert.ToInt32(dateFromData[0]), eventTime.Hour, eventTime.Minute, eventTime.Second);
            }
            else
            {
                Boolean isSuccessCovert = DateTime.TryParseExact(lvEvent.Items[index].SubItems[1].Text, "dddd", provider, DateTimeStyles.None, out eventDate);
                int onDay = -1;
                if (isSuccessCovert) onDay = (int)eventDate.DayOfWeek;
                else
                {
                    string[] dayName = {
                                         DayOfWeek.Sunday.ToString(), DayOfWeek.Monday.ToString(), DayOfWeek.Tuesday.ToString(),
                                         DayOfWeek.Wednesday.ToString(),DayOfWeek.Thursday.ToString(),
                                         DayOfWeek.Friday.ToString(),DayOfWeek.Saturday.ToString()
                                       };
                    for (int i = 0; i < dayName.Count(); i++) if (lvEvent.Items[index].SubItems[1].Text == dayName[i]) { onDay = i; break;}
                }
                
                int todayWeekDay = (int)myDateTime.DayOfWeek;
                int totalDiffDay = onDay - todayWeekDay;
                if (totalDiffDay == -1) remaindPreriod = "Yesterday";
                if (totalDiffDay == 0) remaindPreriod = "Today";
                if (totalDiffDay == 1) remaindPreriod = "Tomorrow";
                if (totalDiffDay < -1) remaindPreriod = "Next week";
                if (totalDiffDay > 1) remaindPreriod = (onDay - todayWeekDay).ToString() + "days";
                if (onDay == -1) remaindPreriod = "Unvalid date";
            }

            TimeSpan spandDateTime = eventDateTime.Subtract(myDateTime);
            days = Convert.ToInt32(spandDateTime.Days);
            hours = Convert.ToInt32(spandDateTime.Hours);
            minutes = Convert.ToInt32(spandDateTime.Minutes);
            seconds = Convert.ToInt32(spandDateTime.Seconds);
            
            if (hours > 0 && hours < 24) remaindPreriod = string.Format("{0} hours", hours);
            else if (minutes > 0 && minutes < 60) remaindPreriod = string.Format("{0} min", minutes);
            else if (seconds > 0 && seconds < 60) remaindPreriod = string.Format("{0} sec", seconds);

            if(days == 1) remaindPreriod = string.Format("Tomorrow");
            else if (days > 1) remaindPreriod = string.Format("{0} days", days);
            else if (days <= 0 && hours <= 0 && minutes <= 0 && seconds <= 0 && isSuccess) remaindPreriod = "Overdue";

            try { lvEvent.Items[index].SubItems[5].Text = remaindPreriod; }
            catch (Exception) { };

            //countStatus data
            if(remaindPreriod.Contains("Today")) countToday++;
            if (remaindPreriod.Contains("Tomorrow")) countTomorrow++;
            if (remaindPreriod.Contains("Overdue")) countOverdue++;

            lblTotal.Text = string.Format("Total:{0}", index);
            lblToday.Text = string.Format("Today:{0}", countToday);
            lblTomorrow.Text = string.Format("Tomorrow:{0}", countTomorrow);
            lblOverdue.Text = string.Format("Overdue:{0}", countOverdue);
            lblDeleted.Text = string.Format("Deleted:{0}", countDeleted);

            if (index == lvEvent.Items.Count - 1)
            {
                countToday = 0;
                countTomorrow = 0;
                countOverdue = 0;
            }
        }
        private void autoUpdate()
        {
            //delate old data;
            DateTime myDateTime = DateTime.Now;
            string myDateTimeString = myDateTime.ToString("hh:mm:ss tt");

            if (myDateTimeString == "12:00:00 AM" && !isUpdateDone)
            {
                autoUpdateEvent();
                autoRegisterWaktuSolat();
                isUpdateDone = true;
            }

            if(myDateTimeString == "12:00:00 PM" && !isUpdateDone)
            {
                autoRegisterWaktuSolat();
                isUpdateDone = true;
            }
           

            if (myDateTimeString == "12:00:01 AM" || myDateTimeString == "12:00:01 PM")
            {
                isUpdateDone = false;
            }
        }

        private void autoUpdateEvent()
        {
            foreach (ListViewItem item in lvEvent.Items)
            {
                tlStatus.Text = "Delete Overdue Event";
                if (item.SubItems[5].Text.Contains("Overdue"))
                {
                    lvEvent.Items[item.Index].Remove();
                    countDeleted++;
                }
            }
            saveEvent();
            restoreNews();
            restoreEvent();
        }

        private void cmbLokasi_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void lblZone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbLokasi_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lblZone.Text = ZoneCodePair[cmbLokasi.Text];
            getWaktuSolat(lblZone.Text);
        }

        private void cmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZoneCodePair.Clear();
            cmbLokasi.Items.Clear();
            switch (cmbState.Text)
            {
                case "Johor":
                    foreach (string zone in Johor)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Perak":
                    foreach (string zone in Perak)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Pahang":
                    foreach (string zone in Pahang)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Selangor":
                    foreach (string zone in Selangor)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Pulau Pinang":
                    foreach (string zone in PulauPinang)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Sabah":
                    foreach (string zone in Sabah)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Putrajaya":
                    foreach (string zone in Putrajaya)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Serawak":
                    foreach (string zone in Serawak)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Labuan":
                    foreach (string zone in Labuan)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Kuala Lumpur":
                    foreach (string zone in KualaLumpur)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Terengganu":
                    foreach (string zone in Terengganu)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Kelantan":
                    foreach (string zone in Kelantan)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Perlis":
                    foreach (string zone in Perlis)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Negeri Sembilan":
                    foreach (string zone in NegeriSembilan)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Kedah":
                    foreach (string zone in Kedah)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
                case "Melaka":
                    foreach (string zone in Melaka)
                    {
                        lblZone.Text = zone;
                        getLokasi(zone);
                        foreach (string lokasi in ZoneCodePair.Keys) cmbLokasi.Items.Add(lokasi);
                    }
                    break;
            }

            cmbLokasi.Text = cmbLokasi.Items[0].ToString();

        }

        private void frmTerminalData_Deactivate(object sender, EventArgs e)
        {
            if(ComPort.IsOpen) sendData(string.Format("Disconnected from {0}", Environment.MachineName));
            saveEvent();
        }

        private void autoRegisterWaktuSolat()
        {
            DateTime myDateTime = new  DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            DateTime lastSyncDate = new DateTime(Settings1.Default.waktusolatTahun, Settings1.Default.waktuSolatBulan, Settings1.Default.waktuSolatHari);


            if (DateTime.Compare(myDateTime, lastSyncDate) != 0)
            {
                if (getWaktuSolat(lblZone.Text))
                {
                    registerWaktuSolat("Telah masuk waktu Imsak bagi kawasan " + cmbLokasi.Text , datesSolat, Convert.ToDateTime(imsak).ToString("hh:mm:ss tt"));
                    registerWaktuSolat("Telah masuk waktu Syuruk bagi kawasan " + cmbLokasi.Text, datesSolat, Convert.ToDateTime(syuruk).ToString("hh:mm:ss tt"));
                    registerWaktuSolat("Telah masuk waktu Subuh bagi kawasan " + cmbLokasi.Text, datesSolat, Convert.ToDateTime(subuh).ToString("hh:mm:ss tt"));
                    registerWaktuSolat("Telah masuk waktu Zohor bagi kawasan " + cmbLokasi.Text, datesSolat, Convert.ToDateTime(zohor).ToString("hh:mm:ss tt"));
                    registerWaktuSolat("Telah masuk waktu Asar bagi kawasan " + cmbLokasi.Text, datesSolat, Convert.ToDateTime(asar).ToString("hh:mm:ss tt"));
                    registerWaktuSolat("Telah masuk waktu Maghrib bagi kawasan " + cmbLokasi.Text, datesSolat, Convert.ToDateTime(maghrib).ToString("hh:mm:ss tt"));
                    registerWaktuSolat("Telah masuk waktu Isyak bagi kawasan " + cmbLokasi.Text, datesSolat, Convert.ToDateTime(isyak).ToString("hh:mm:ss tt"));

                    Settings1.Default.waktuSolatHari = DateTime.Now.Day;
                    Settings1.Default.waktuSolatBulan = DateTime.Now.Month;
                    Settings1.Default.waktusolatTahun = DateTime.Now.Year;
                    Settings1.Default.Save();
                    lblSyncDate.Text = string.Format("{2}-{1}-{0}", Settings1.Default.waktusolatTahun, Settings1.Default.waktuSolatBulan, Settings1.Default.waktuSolatHari);


                }
            }
        }

        private void registerWaktuSolat(string message, string date, string time)
        {
            //Add items in the listview
            string[] arr = new string[6];
            ListViewItem itm;
            DateTime createDateTime = DateTime.Now;

            //Add item
            arr[0] = time;  //<<<EventTime>>>
            arr[1] = date; //<<<EventDate>>>
            arr[2] = message; //<<<EventText>>>
            arr[3] = createDateTime.ToString("dd-MM-yyyy HH:mm:ss");//<<<CreteDateTime>>>
            arr[4] = "Auto regiter waktu solat";//<<<CreatorName>>>
            arr[5] = "New";
            itm = new ListViewItem(arr);
            lvEvent.Items.Add(itm);
        }

        private void lvNews_BindingContextChanged(object sender, EventArgs e)
        {
            if (lbNews.Items.Count > 0) { cbSendNews.Enabled = true; }
            else { cbSendNews.Checked = false; cbSendNews.Enabled = false; }
        }

 
    }
}
