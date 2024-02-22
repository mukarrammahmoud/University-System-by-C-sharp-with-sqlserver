using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.PL
{
    public partial class FRM_PRESENT_STD : Form
    {
        BL.CLS_PRESENT PRS = new BL.CLS_PRESENT();
        BL.CLS_COURSE_DEP CRSD = new BL.CLS_COURSE_DEP();

        public FRM_PRESENT_STD()
        {
            InitializeComponent();
            try
            {
                CMB_DEP_NM.DataSource = PRS.GET_ALL_DEP_NAME();
                CMB_DEP_NM.DisplayMember = "DEP_NAME";
                CMB_CRS_ID.DataSource = PRS.GET_COURSE_ID_FROM_DEP(CMB_DEP_NM.Text);
                CMB_CRS_ID.DisplayMember = "COURSE_ID";
                CMB_CRS_NM.DataSource = CRSD.GET_NAME_COURCE(Convert.ToInt32( CMB_CRS_ID.Text));
                CMB_CRS_NM.DisplayMember = "COURSE_NAME";
            }
            catch
            {
                return;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FRM_PRESENT_STD_Load(object sender, EventArgs e)
        {

        }

        private void CMB_DEP_NM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CMB_CRS_ID.DataSource = PRS.GET_COURSE_ID_FROM_DEP(CMB_DEP_NM.Text);
                CMB_CRS_ID.DisplayMember = "COURSE_ID";
                CMB_CRS_NM.DataSource = CRSD.GET_NAME_COURCE(Convert.ToInt32(CMB_CRS_ID.Text));
                CMB_CRS_NM.DisplayMember = "COURSE_NAME";

            }
            catch
            {
                return;
            }
        }

        private void CMB_CRS_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                CMB_CRS_NM.DataSource = CRSD.GET_NAME_COURCE(Convert.ToInt32(CMB_CRS_ID.Text));
                CMB_CRS_NM.DisplayMember = "COURSE_NAME";

            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//"@COURSE_NAME", CMB_CRS_NM.Text , "@DEP_NAME", CMB_DEP_NM.Text
            RPT.FRM_REPORT FRM = new RPT.FRM_REPORT();
            RPT.RPT_PRESENT_ABS_STD REPORT= new RPT.RPT_PRESENT_ABS_STD();
            REPORT.SetDataSource(PRS.PRESENT_ABSENT_STD(CMB_CRS_NM.Text,CMB_DEP_NM.Text));
            FRM.crystalReportViewer1.ReportSource = REPORT;
            FRM.ShowDialog();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
