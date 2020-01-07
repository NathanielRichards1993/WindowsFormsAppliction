using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WindowsFormsAppliction
{
    public class Server
    {
        //properties
        private int m_Number = -1; // default incorrect value
        private System.Windows.Forms.RichTextBox m_RToTextBox = null;
        private System.Windows.Forms.Label m_ServerLabel = null;
        private Alarm m_Alarm = null;

        //constructor
        public Server(System.Windows.Forms.RichTextBox _TextBox,
            System.Windows.Forms.Label _serverlabel,
            System.Windows.Forms.Label _alarmlabel)
        {
            m_RToTextBox = _TextBox;
            m_ServerLabel = _serverlabel;
            m_Alarm = new Alarm(_TextBox, _alarmlabel);
        }

        //getters & setters
        public int ID
        {
            get => m_Number;
            set
            {
                if (value > 0)
                {
                    m_Number = value;
                    m_ServerLabel.Text =  value.ToString();
                }
                else
                {
                    m_ServerLabel.Text = "empty";
                }
            }
        }

        public void SetNewServerAndAlarmData()
        {
            //context check
            if (Regex.Match(m_RToTextBox.Text, @"The alarm id from video server number \d{1,} is \d{1,}.").Success ||
                Regex.Match(m_RToTextBox.Text, @"Alarm id \d{1,} has been received from video server number \d{1,}.").Success)
            {
                int GetSingleNumberFromMatch(Match _match)
                {
                    return int.Parse(Regex.Match(_match.ToString(), @"\d{1,}").ToString());
                }
                const string regexForServerId = @"server number \d{1,}";
                Match serverId = Regex.Match(m_RToTextBox.Text, regexForServerId);


                const string regexForAlarmId = @"\b(is \d{1,}|id \d{1,})";
                Match alarmId = Regex.Match(m_RToTextBox.Text, regexForAlarmId);

                ID = GetSingleNumberFromMatch(serverId);
                GetAlarm().ID = GetSingleNumberFromMatch(alarmId);
                
            }
            else
            {
                ID = -1;
                GetAlarm().ID = -1;
                m_RToTextBox.Text = @"Insert Text Here";
            }
        }

        public Alarm GetAlarm()
        {
            return m_Alarm;
        }
    }
}
