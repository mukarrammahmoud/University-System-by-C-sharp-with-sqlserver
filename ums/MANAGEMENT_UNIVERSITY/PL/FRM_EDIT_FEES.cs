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
    public partial class FRM_EDIT_FEES : Form
    {
        BL.CLS_FEES FS = new BL.CLS_FEES();

        public FRM_EDIT_FEES()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FS.UPDATE_FEES(Convert.ToInt32(TXT_STD_ID2.Text), TXT_STD_NAME2.Text, TXT_DEP_NAME2.Text, Convert.ToInt32(TXT_FEES_DEP.Text), Convert.ToInt32(TXT_AMOUNT2.Text), DT_DATE2.Text, TXT_TERM2.Text, CMB_LEVEL2.Text);
                MessageBox.Show("تمت التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_FEES.getmainform. dataGridView1.DataSource = FS.GET_ALL_FESS(Convert.ToInt32(TXT_STD_ID2.Text));
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
