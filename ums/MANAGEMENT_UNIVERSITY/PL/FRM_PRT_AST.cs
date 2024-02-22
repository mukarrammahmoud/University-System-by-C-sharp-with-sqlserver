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
    public partial class FRM_PRT_AST : Form
    {
        private static FRM_PRT_AST frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_PRT_AST getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_PRT_AST();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.CLS_PRESENT PR_AB = new BL.CLS_PRESENT();
        public FRM_PRT_AST()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
         
            try
            {

                CMB_DEP_NAME.DataSource = PR_AB.GET_ALL_DEP_NAME();
                CMB_DEP_NAME.DisplayMember = "DEP_NAME";
                CMB_DOC_NAME.DataSource = PR_AB.GET_DOC_NAME_TO_PRSENT(CMB_DEP_NAME.Text, CMB_DAYS.Text);
                CMB_DOC_NAME.DisplayMember = "DOC_NAME";
                dataGridView1.DataSource = PR_AB.GET_ALL_FROM_PR_AB();
            }
            catch
            {
                return;
            }
            //CMB_DOC_NAME.DataSource = PR_AB.GET_NAME_DOC(CMB_DEP_NAME.Text);
            //CMB_DOC_NAME.DisplayMember = "DOC_NAME";


        }

        private void CMB_DEP_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {

              
                CMB_DOC_NAME.DataSource = PR_AB.GET_DOC_NAME_TO_PRSENT(CMB_DEP_NAME.Text, CMB_DAYS.Text);
                CMB_DOC_NAME.DisplayMember = "DOC_NAME";
            }
            catch
            {
                return;
            }
        }

        private void CMB_DOC_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    CMB_PA.DataSource = PR_AB.GET_DAY_OF_DOCTORS(CMB_DOC_NAME.Text);
            //    CMB_PA.DisplayMember = "DAY";
            //}
            //catch
            //{
            //    return;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
          

            try
            {
                DT = PR_AB.CHECK_DATE(CMB_DOC_NAME.Text, Convert.ToString(dateTimePicker1.Text));

                if (CMB_DAYS.Text == "" || CMB_DEP_NAME.Text == "" || CMB_DOC_NAME.Text == "" || dateTimePicker1.Text == "" || CMB_PA.Text == "")
                {
                    MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

           

                else if (DT.Rows.Count > 0)
                     { 
                        MessageBox.Show("هذا التاريخ مكرر  لنفس المحاضر", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        PR_AB.ADD_TO_PR_AB(CMB_DOC_NAME.Text, CMB_DAYS.Text, CMB_PA.Text, dateTimePicker1.Text, CMB_DEP_NAME.Text);
                        MessageBox.Show("تمت الإضافة", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // FRM_DOC_CRS.getmainform.dataGridView1.DataSource = DD.GET_ALL_CRS_DEP();
                    dataGridView1.DataSource = PR_AB.GET_ALL_FROM_PR_AB();
                    CMB_DOC_NAME.Text = "";
                        CMB_DAYS.Text = "";
                        dateTimePicker1.Text = "";
                        CMB_PA.Text = "";

                    }
                
            }
            catch
            {
                return;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_Validated(object sender, EventArgs e)
        {
            //try
            //{


            //    DataTable DATAT = new DataTable();

            //    DATAT = PR_AB.CHECK_DATE(CMB_DOC_NAME.Text, Convert.ToString(dateTimePicker1.Text));
            //    if (DATAT.Rows.Count > 0)
            //    {
            //        MessageBox.Show("هذا الرقم موجود مسبقا", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        dateTimePicker1.Focus();
            //        //dateTimePicker1.SelectNextContro = 0;
            //        //dateTimePicker1.SelectionLength = dateTimePicker1.TextLength;

            //    }
            //}


            //catch
            //{
            //    return;
            //}
            try
            {
                DataTable DT = new DataTable();
                DT = PR_AB.CHECK_DATE(CMB_DOC_NAME.Text, Convert.ToString(dateTimePicker1.Text));
                if (DT.Rows.Count > 0)
                {
                    MessageBox.Show(" هذا التاريخ مكرر  لنفس المحاضر", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateTimePicker1.Focus();
                }
            }
            catch
            {
                return;
            }
        }

        private void CMB_DAYS_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CMB_DOC_NAME.DataSource = PR_AB.GET_DOC_NAME_TO_PRSENT(CMB_DEP_NAME.Text, CMB_DAYS.Text);
                CMB_DOC_NAME.DisplayMember = "DOC_NAME";
            }
            catch
            {
                return;
            }
            //try
            //{
            //    CMB_PA.DataSource = PR_AB.GET_DAY_LAT(CMB_DAYS.Text);
            //    CMB_PA.DisplayMember = "DAY";
            //}
            //catch
            //{
            //    return;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("هل تريدالحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    PR_AB.DELETE_FROM_PR_AB(dataGridView1.CurrentRow.Cells[0].Value.ToString(),dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = PR_AB.GET_ALL_FROM_PR_AB();
                }

            }
            catch
            {
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FRM_EDIT_PR frm = new FRM_EDIT_PR();
            frm.txt_doc_name.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.CMB_DAYS2.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.CMB_PA2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.TXT_DATE.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txt_dep_name.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txt_doc_name.ReadOnly = true;
            frm.txt_dep_name.ReadOnly = true;

            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           try
            {
                RPT.FRM_REPORT frm = new RPT.FRM_REPORT();
                RPT.RPT_PRS_ABS REP = new RPT.RPT_PRS_ABS();
                frm.crystalReportViewer1.ReportSource = REP;
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                RPT.FRM_REPORT FRM = new RPT.FRM_REPORT();
                RPT.RPT_SINGLE_PRS_DOC REP = new RPT.RPT_SINGLE_PRS_DOC();
                REP.SetParameterValue("@DOC_NAME", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                FRM.crystalReportViewer1.ReportSource = REP;
                FRM.ShowDialog();
            }
            catch
            {
                return;
            }
        }
    }
}
