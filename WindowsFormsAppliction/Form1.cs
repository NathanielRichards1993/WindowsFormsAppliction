using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppliction
{
    public partial class WinFromApplication : Form
    {
        public WinFromApplication()
        {
            InitializeComponent();
            m_server = new Server(InsertTextBox, serverValue, AlarmValue);
        } 

        private void InserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                m_server.SetNewServerAndAlarmData();
            }
        }

        private void InserTextBox_Leave(object sender, EventArgs e)
        {
            m_server.SetNewServerAndAlarmData();
        }
    }
}
