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
    public partial class FRM_DOC_CRS : Form
    {
        private static FRM_DOC_CRS frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_DOC_CRS getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_DOC_CRS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.CLS_COURSE_DEP SRD = new BL.CLS_COURSE_DEP();
        BL.CLS_DOCTORS DD = new BL.CLS_DOCTORS();
        BL.CLS_GRADES CRS = new BL.CLS_GRADES();
        public FRM_DOC_CRS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            CMB_DEP_ID.DataSource = SRD.GET_ALL_DEPT_ID();
            CMB_DEP_ID.DisplayMember = "DEP_ID";
            dataGridView1.DataSource = DD.GET_ALL_CRS_DEP();
            CMB_TIME.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CMB_DEP_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                CMB_DEP_NAME.DataSource = SRD.GET_DEP_NAME(Convert.ToInt32(CMB_DEP_ID.Text));
                CMB_DEP_NAME.DisplayMember = "DEP_NAME";
                CMB_ID_DOC.DataSource = DD.GET_DOC_ID_COND(Convert.ToInt32(CMB_DEP_ID.Text));
                CMB_ID_DOC.DisplayMember = "DOC_ID";
                CMB_NAME_DOC.DataSource = DD.GET_DOC_NAME(Convert.ToInt32(CMB_ID_DOC.Text));
                CMB_NAME_DOC.DisplayMember = "DOC_NAME";
                CMB_CRS_ID.DataSource = CRS.SELECT_CRSID_FRPM_DEP(Convert.ToInt32(CMB_DEP_ID.Text));
                CMB_CRS_ID.DisplayMember = "COURSE_ID";
                CMB_CRS_NAME.DataSource = SRD.GET_NAME_COURCE(Convert.ToInt32(CMB_CRS_ID.Text));
                CMB_CRS_NAME.DisplayMember = "COURSE_NAME";
            }
            catch
            {
                return;
            }
        }

        private void CMB_ID_DOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CMB_NAME_DOC.DataSource = DD.GET_DOC_NAME(Convert.ToInt32(CMB_ID_DOC.Text));
                CMB_NAME_DOC.DisplayMember = "DOC_NAME";
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
                CMB_CRS_NAME.DataSource = SRD.GET_NAME_COURCE(Convert.ToInt32(CMB_CRS_ID.Text));
                CMB_CRS_NAME.DisplayMember = "COURSE_NAME";
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
                if (CMB_NAME_DOC.Text == "" || CMB_TIME.Text == "" || CMB_ID_DOC.Text == "" || CMB_DEP_NAME.Text == "" || CMB_DEP_ID.Text == "" || CMB_DAY.Text == "" || CMB_CRS_NAME.Text == "" || CMB_CRS_ID.Text == "")
                {
                    MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DD.ADD_CRS_TO_DOC(Convert.ToInt32(CMB_ID_DOC.Text), CMB_NAME_DOC.Text, Convert.ToInt32(CMB_DEP_ID.Text), CMB_DEP_NAME.Text, Convert.ToInt32(CMB_CRS_ID.Text), CMB_CRS_NAME.Text, CMB_DAY.Text, CMB_TIME.Text);
                    MessageBox.Show("تمت الإضافة", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = DD.GET_ALL_CRS_DEP();
                    CMB_TIME.Text = "";
                    CMB_NAME_DOC.Text = "";
                    CMB_ID_DOC.Text = "";
                    CMB_DEP_NAME.Text = "";
                    CMB_DEP_ID.Text = "";
                    CMB_DAY.Text = "";
                    CMB_CRS_NAME.Text = "";
                    CMB_CRS_ID.Text = "";


                }
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف العنصر المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)

            {
                DD.DELET_FROM_CRS_DOC(this.dataGridView1.CurrentRow.Cells[0].Value.ToString(), this.dataGridView1.CurrentRow.Cells[1].Value.ToString(), this.dataGridView1.CurrentRow.Cells[2].Value.ToString(), this.dataGridView1.CurrentRow.Cells[3].Value.ToString(), this.dataGridView1.CurrentRow.Cells[4].Value.ToString());
                dataGridView1.DataSource = DD.GET_ALL_CRS_DEP();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FRM_M_DOC_CRS FRM = new FRM_M_DOC_CRS();
           FRM.CMB_ID_DOC2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            FRM.CMB_NAME_DOC2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            FRM.CMB_DEP_ID2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            FRM.CMB_DEP_NAME2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            FRM.CMB_CRS_ID2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            FRM.CMB_CRS_NAME2.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            FRM.CMB_DAY2.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            FRM.CMB_TIME2.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            FRM.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                RPT.FRM_REPORT frm = new RPT.FRM_REPORT();
                RPT.RPT_CRS_DOC CRSD = new RPT.RPT_CRS_DOC();
                frm.crystalReportViewer1.ReportSource = CRSD;
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                RPT.FRM_REPORT frm = new RPT.FRM_REPORT();
                RPT.RPT_CRS_SINGLE_DOC single_crs = new RPT.RPT_CRS_SINGLE_DOC();
                single_crs.SetParameterValue("@DOC_NAME", dataGridView1.CurrentRow.Cells[1].Value.ToString());
                frm.crystalReportViewer1.ReportSource = single_crs;
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void CMB_DAY_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CMB_DEP_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
