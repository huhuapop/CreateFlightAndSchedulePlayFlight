using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Messaging;
using System.Xml;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace CreateFlightAndSchedulePlayFlight
{
    public partial class ScheduleFlight : Form
    {
        public ScheduleFlight()
        {
            InitializeComponent();
        }

      
#region "定义 "
        string queuename;
        Int32 schedule_send_plan_count;
        Int32 _current_Times;
        FlightPlan[] _FlightPlan;

        public struct FlightPlan 
        {
            public string flightNo;
            public string adi;
            public string airline;
            public string flightnumber;
            public string suffix;
            public string flightrepeatcount;
            public string zonegroup;
            public string announcementtype;
            public string repeatcount;
            public string gate;
            public string languages;
            public string terminalcode;
            public string time;
            public string enable;
        }

        Int32 Times; 
#endregion

        private void ScheduleFlight_Load(object sender, EventArgs e)
        {
            try
            {
                queuename = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_queuename"];
              
                schedule_send_plan_count = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_count"]);
                _FlightPlan = new FlightPlan[schedule_send_plan_count];

                string _currentString = "";
                string[] _pCurrentString;

                ///schedule_send_plan_No
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_No"];

                
                _pCurrentString = _currentString.Split(new char[]{ ';'});

                for (Int32 i = 0; i < schedule_send_plan_count;i++ )
                {

                    _FlightPlan[i].flightNo = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;


                ///schedule_send_plan_adi
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_adi"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].adi = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;


                ///schedule_send_plan_airline
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_airline"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].airline = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;


                ///schedule_send_plan_flightnumber
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_flightnumber"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].flightnumber = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;


                ///schedule_send_plan_suffix
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_suffix"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].suffix = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;


                ///schedule_send_plan_flightrepeatcount
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_flightrepeatcount"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].flightrepeatcount = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;


                ///schedule_send_plan_schedule_date
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_zonegroup"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].zonegroup = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;


                ///schedule_send_plan_announcementtype
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_announcementtype"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].announcementtype = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;

                ///schedule_send_plan_repeatcount
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_repeatcount"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].repeatcount = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;

                ///schedule_send_plan_gate
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_gate"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].gate = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;

                ///schedule_send_plan_languages
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_languages"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].languages = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;

                ///schedule_send_plan_terminalcode
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_terminalcode"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].terminalcode = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;

                ///schedule_send_plan_time
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_time"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].time = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;


                //schedule_send_enable
                _currentString = System.Configuration.ConfigurationManager.AppSettings["schedule_send_plan_enable"];


                _pCurrentString = _currentString.Split(new char[] { ';' });

                for (Int32 i = 0; i < schedule_send_plan_count; i++)
                {

                    _FlightPlan[i].enable = _pCurrentString[i];
                }
                _currentString = "";
                _pCurrentString = null;

                for (Int32 i = 0; i < schedule_send_plan_count;i++ )
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();

                    //adi
                    textboxcell.Value = _FlightPlan[i].adi;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;

                    //airline
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].airline;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;

                    //flightnumber
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].flightnumber;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //suffix
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].suffix;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //flightrepeatcount
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].flightrepeatcount;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //schedule_date
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].zonegroup;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //announcementtype
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].announcementtype;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //repeatcount
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].repeatcount;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //gate
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].gate;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //languages
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].languages;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //terminalcode
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].terminalcode;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //time
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].time;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    //enable
                    textboxcell = new DataGridViewTextBoxCell();
                    textboxcell.Value = _FlightPlan[i].enable;
                    row.Cells.Add(textboxcell);

                    textboxcell = null;


                    dgFlightPlan.Rows.Add(row);
          
                }

            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            finally
            {

            }
        }

        private void btnSendSchedulePlan_Click(object sender, EventArgs e)
        {
            try
            {
                if(tmSendPlan.Enabled==true)
                {
                    tmSendPlan.Stop();
                }
                tmSendPlan.Interval = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["Interval"]);
                Times = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["Times"]);
                _current_Times = 0;
                tmSendPlan.Start();
                btnStop.Enabled = true;

            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            finally
            {

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (tmSendPlan.Enabled == true)
                {
                    tmSendPlan.Stop();
                }
                tmSendPlan.Enabled = false;
         
                btnSendSchedulePlan.Enabled = true;
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            finally
            {

            }
        }

        private void tmSendPlan_Tick(object sender, EventArgs e)
        {
            tmSendPlan.Stop();
           
           
            
             try
             {
                 if (_current_Times == 0)
                 {
                     for (Int32 i = 0; i < schedule_send_plan_count; i++)
                     {
                         SendMsg(i);
                         System.Threading.Thread.Sleep(Convert.ToInt32(_FlightPlan[i].time));
                     }
                 }
             }
             catch (System.Exception ex)
             {
                 ex.ToString();
             }
             finally
             {
                 if(_current_Times<Times)
                 {
                     _current_Times = _current_Times + 1;
                 }
                 else
                 {
                     _current_Times = 0;
                 }
             }
                
          
            tmSendPlan.Start();
        }

        private void SendMsg( Int32 OrderID)
        {
            XmlDocument doc = new XmlDocument();
            //System.Messaging.MessageQueue mq;// = new System.Messaging.MessageQueue();
            XmlDocument xmldom = new XmlDocument();
            try
            {

                //tmSendPlan.Interval = Convert.ToInt32(_FlightPlan[_current_schedule_send_plan_number].time);


                string _PARS = "";
                _PARS = "<aasman version='1.0' name='ULTRA_PARS_REQUEST'><makeannc annccode='' templateid='1298' number='1111' linecode='CA' suffix='' repeatCount='99'><field name='zone_maps' value='66'/><field name='languages' value='MA,EN'/><field name='annc_repeat_count' value='88'/><field name='gate' instance='1' value='77'/><field name='flight_suffix' value='ZZ'/><field name='flight_repeat_count' value='99'/><field name='schedule_date' value='1970-01-01'/></makeannc></aasman>";


                //airline
                _PARS = _PARS.Replace("CA", _FlightPlan[OrderID].airline);

                //flightnumber
                _PARS = _PARS.Replace("1111", _FlightPlan[OrderID].flightnumber);


                //suffix
                _PARS = _PARS.Replace("ZZ", _FlightPlan[OrderID].suffix);


                //flightrepeatcount
                _PARS = _PARS.Replace("99", _FlightPlan[OrderID].flightrepeatcount);

                //zonegroup
                _PARS = _PARS.Replace("66", _FlightPlan[OrderID].zonegroup);


                //announcementtype
                _PARS = _PARS.Replace("1970-01-01", DateTime.Now.ToString("yyyy-MM-dd"));


                //repeatcount
                _PARS = _PARS.Replace("88", _FlightPlan[OrderID].repeatcount);


                //gate
                _PARS = _PARS.Replace("77", _FlightPlan[OrderID].gate);


                //announcementtype
                _PARS = _PARS.Replace("MA,EN", _FlightPlan[OrderID].languages);







                xmldom.LoadXml(_PARS);
                EventLog.WriteEntry("Debug_CreateFlightAndSchedulePlayFlight", _PARS.ToString(), EventLogEntryType.Information);
                //mq = new System.Messaging.MessageQueue(queuename);
                //mq.Send(xmldom, MessageQueueTransactionType.Single);
                MessageQueue queue = new MessageQueue(queuename);
                System.Messaging.Message message = new System.Messaging.Message();
                message.BodyStream = new MemoryStream(Encoding.Unicode.GetBytes(xmldom.OuterXml));
                queue.Send(message);
                queue.Close();

            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            finally
            {

            }
        }

        private void btnTestAllFlight_Click(object sender, EventArgs e)
        {
            try
            {
               
                    for (Int32 i = 0; i < schedule_send_plan_count; i++)
                    {
                        SendMsg(i);
                        System.Threading.Thread.Sleep(Convert.ToInt32(_FlightPlan[i].time));
                    }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            finally
            {
               
            }
        }

        private void btnTestSelect_Click(object sender, EventArgs e)
        {
            try
            {
                int selectIndex = 0;
                int selectCount = 0;
                selectCount = dgFlightPlan.SelectedRows.Count;
                for (Int32 i = 0; i < selectCount;i++ )
                {
                    selectIndex = dgFlightPlan.SelectedRows[selectCount-i-1].Index;
                    SendMsg(selectIndex);
                }
               
              
                
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            finally
            {
            }
        }
    }
}