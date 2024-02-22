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

    public partial class FRM_DOCTORS : Form
    {

        private static FRM_DOCTORS frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_DOCTORS getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_DOCTORS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.CLS_DOCTORS DCT = new BL.CLS_DOCTORS();
        BL.CLS_COURSE_DEP SRD = new BL.CLS_COURSE_DEP();
        BL.CLS_COURSE_DEP UP = new BL.CLS_COURSE_DEP();
        
        public FRM_DOCTORS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            CMB_ID_DEP.DataSource = SRD.GET_ALL_DEPT_ID();
            CMB_ID_DEP.DisplayMember = "DEP_ID";
            dataGridView1.DataSource = DCT.GET_ALL_DOCTORS();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_ADD.Text == "" || TXT_ID_DOC.Text == "" || TXT_NAME_DOC.Text == "" || TXT_SAL.Text == "" || TXT_SPC.Text == "" || CMB_GNDER.Text == "" || CMB_ID_DEP.Text == "" || CMB_M.Text == "" || CMP_NAME_DEP.Text == "" || dateTimePicker1.Text == "")
                {
                    MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DCT.ADD_DOCTORS(Convert.ToInt32(TXT_ID_DOC.Text), TXT_NAME_DOC.Text, Convert.ToInt32(CMB_ID_DEP.Text), CMP_NAME_DEP.Text, dateTimePicker1.Text, CMB_GNDER.Text, TXT_SAL.Text, TXT_SPC.Text, CMB_M.Text, TXT_ADD.Text);
                    MessageBox.Show("تمت الإضافة", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = DCT.GET_ALL_DOCTORS();
                    TXT_ADD.Text = "";
                    TXT_ID_DOC.Text = "";
                    TXT_NAME_DOC.Text = "";
                    TXT_SAL.Text = "";
                    TXT_SPC.Text = "";
                    CMB_GNDER.Text = "";
                    CMB_ID_DEP.Text = "";
                    CMB_M.Text = "";
                    CMP_NAME_DEP.Text = "";
                    dateTimePicker1.Text = "";

                }
            }
            catch
            {
                return;
            }
        }

        private void CMB_ID_DEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CMP_NAME_DEP.DataSource = SRD.GET_DEP_NAME(Convert.ToInt32(CMB_ID_DEP.Text));
                CMP_NAME_DEP.DisplayMember = "DEP_NAME";
            }
            catch
            {
                return;
            }
        }

        private void TXT_ID_DOC_Validated(object sender, EventArgs e)
        {
            try
            {
                DataTable DATAT = new DataTable();

                DATAT = DCT.CHECK_DOC_ID(Convert.ToInt32(TXT_ID_DOC.Text));
                if (DATAT.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم موجود مسبقا", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_ID_DOC.Focus();
                    TXT_ID_DOC.SelectionStart = 0;
                    TXT_ID_DOC.SelectionLength = TXT_ID_DOC.TextLength;

                }
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("هل تريدالحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    DCT.DELETE_DOCTOR(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = DCT.GET_ALL_DOCTORS();
                }

            }
            catch
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_EDIT_DOCTORS frm = new FRM_EDIT_DOCTORS();
            frm.TXT_ID_DOC2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.TXT_NAME_DOC2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.CMB_ID_DEP2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.CMP_NAME_DEP2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.dateTimePicker12.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.CMB_GNDER2.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.TXT_SAL2.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.TXT_SPC2.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.CMB_M2.Text = this.dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm.TXT_ADD2.Text = this.dataGridView1.CurrentRow.Cells[9].Value.ToString();
            frm.TXT_ID_DOC2.Enabled = false;
            frm.ShowDialog();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = DCT.SEARCH_ALL_DOC(textBox1.Text);
            }
            catch
            {
                return;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.FRM_REPORT frm = new RPT.FRM_REPORT();
                RPT.RPT_ALL_DOC ADOC = new RPT.RPT_ALL_DOC();
                frm.crystalReportViewer1.ReportSource = ADOC;
                frm.ShowDialog();
               
            }
               catch
            {
                return;
            }
        }
    }
}
