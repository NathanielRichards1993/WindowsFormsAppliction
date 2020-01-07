using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppliction
{
    public class Alarm
    {
        //properties
        private int m_ID = -1;
        private Server m_RServer = null;
        private System.Windows.Forms.RichTextBox m_RToTextBox;
        private System.Windows.Forms.Label m_Alarmlabel;
        //constructor
        public Alarm(System.Windows.Forms.RichTextBox _TextBox,
            System.Windows.Forms.Label _alarmlabel)
        {
            m_RToTextBox = _TextBox;
            m_Alarmlabel = _alarmlabel;
        }

        //getters & setters
        public int ID
        {
            get => m_ID;
            set
            {
                if (value > 0)
                {
                    m_ID = value;
                    m_Alarmlabel.Text = value.ToString();
                }
                else
                {
                    m_Alarmlabel.Text = "empty";
                }
            }
        }
    }
}
