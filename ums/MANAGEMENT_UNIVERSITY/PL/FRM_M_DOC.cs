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
    public partial class FRM_M_DOC_CRS : Form
    {
        BL.CLS_COURSE_DEP SRD = new BL.CLS_COURSE_DEP();
        BL.CLS_DOCTORS DD = new BL.CLS_DOCTORS();
        BL.CLS_GRADES CRS = new BL.CLS_GRADES();
        public FRM_M_DOC_CRS()
        {
            InitializeComponent();
            CMB_DEP_ID2.DataSource = SRD.GET_ALL_DEPT_ID();
            CMB_DEP_ID2.DisplayMember = "DEP_ID";
        }

        private void CMB_DEP_ID2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                CMB_DEP_NAME2.DataSource = SRD.GET_DEP_NAME(Convert.ToInt32(CMB_DEP_ID2.Text));
                CMB_DEP_NAME2.DisplayMember = "DEP_NAME";
                CMB_ID_DOC2.DataSource = DD.GET_DOC_ID_COND(Convert.ToInt32(CMB_DEP_ID2.Text));
                CMB_ID_DOC2.DisplayMember = "DOC_ID";
                CMB_NAME_DOC2.DataSource = DD.GET_DOC_NAME(Convert.ToInt32(CMB_ID_DOC2.Text));
                CMB_NAME_DOC2.DisplayMember = "DOC_NAME";
                CMB_CRS_ID2.DataSource = CRS.SELECT_CRSID_FRPM_DEP(Convert.ToInt32(CMB_DEP_ID2.Text));
                CMB_CRS_ID2.DisplayMember = "COURSE_ID";
                CMB_CRS_NAME2.DataSource = SRD.GET_NAME_COURCE(Convert.ToInt32(CMB_CRS_ID2.Text));
                CMB_CRS_NAME2.DisplayMember = "COURSE_NAME";
            }
            catch
            {
                return;
            }
        }

        private void CMB_CRS_ID2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CMB_CRS_NAME2.DataSource = SRD.GET_NAME_COURCE(Convert.ToInt32(CMB_CRS_ID2.Text));
                CMB_CRS_NAME2.DisplayMember = "COURSE_NAME";
            }
            catch
            {
                return;
            }
        }

        private void CMB_ID_DOC2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CMB_NAME_DOC2.DataSource = DD.GET_DOC_NAME(Convert.ToInt32(CMB_ID_DOC2.Text));
                CMB_NAME_DOC2.DisplayMember = "DOC_NAME";
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CMB_CRS_ID2.Text == "" || CMB_CRS_NAME2.Text == "" || CMB_DAY2.Text == "" || CMB_DEP_ID2.Text == "" || CMB_DEP_NAME2.Text == "" || CMB_ID_DOC2.Text == "" || CMB_NAME_DOC2.Text == "" || CMB_TIME2.Text == "" )
                {
                    MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DD.UPDATE_CRS_DOC(Convert.ToInt32(CMB_ID_DOC2.Text), CMB_NAME_DOC2.Text, Convert.ToInt32(CMB_DEP_ID2.Text), CMB_DEP_NAME2.Text,Convert.ToInt32( CMB_CRS_ID2.Text), CMB_CRS_NAME2.Text, CMB_DAY2.Text, CMB_TIME2.Text );
                    MessageBox.Show("تمت التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_DOC_CRS.getmainform.dataGridView1.DataSource = DD.GET_ALL_CRS_DEP();
                    CMB_TIME2.Text = "";
                    CMB_NAME_DOC2.Text = "";
                    CMB_ID_DOC2.Text = "";
                    CMB_DEP_NAME2.Text = "";
                    CMB_DEP_ID2.Text = "";
                    CMB_DAY2.Text = "";
                    CMB_CRS_NAME2.Text = "";
                    CMB_CRS_ID2.Text = "";
                   

                }
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
