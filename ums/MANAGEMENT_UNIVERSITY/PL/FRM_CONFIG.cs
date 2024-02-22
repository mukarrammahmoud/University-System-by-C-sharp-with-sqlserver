using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGEMENT_UNIVERSITY.PL
{
    public partial class FRM_CONFIG : Form
    {
        public FRM_CONFIG()
        {
            InitializeComponent();
            TXT_SRVR_NM.Text = Properties.Settings.Default.SERVER;
            TXT_DB_NM.Text = Properties.Settings.Default.DATABASE;
            if (Properties.Settings.Default.MODE == "SQL")
            {
                RD_SQL.Checked = true;
                TXT_USER_NM.Text = Properties.Settings.Default.USERID;
                TXT_PSW.Text = Properties.Settings.Default.PSW;
            }
            else
            {
                RD_WINDOWS.Checked = true;
                TXT_USER_NM.Clear();
                TXT_PSW.Clear();
                TXT_USER_NM.ReadOnly = true;
                TXT_PSW.ReadOnly = true;

            }
        }

        private void BTN_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_SAVE_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SERVER = TXT_SRVR_NM.Text;
            Properties.Settings.Default.DATABASE  = TXT_DB_NM.Text;
            Properties.Settings.Default.MODE = RD_SQL.Checked == true ? "SQL" : "Windows";
            Properties.Settings.Default.USERID  = TXT_USER_NM.Text;
            Properties.Settings.Default.PSW = TXT_PSW.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RD_SQL_CheckedChanged(object sender, EventArgs e)
        {
            TXT_USER_NM.ReadOnly = false;
            TXT_PSW.ReadOnly = false;
        }

        private void RD_WINDOWS_CheckedChanged(object sender, EventArgs e)
        {
            TXT_USER_NM.ReadOnly = true;
            TXT_PSW.ReadOnly = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
