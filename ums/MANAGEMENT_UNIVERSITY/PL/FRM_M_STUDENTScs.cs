 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.PL
{
    public partial class FRM_M_STUDENTScs : Form
    {
        private static FRM_M_STUDENTScs frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_M_STUDENTScs getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_M_STUDENTScs();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.CLS_STUDENTS STD = new BL.CLS_STUDENTS();
        public FRM_M_STUDENTScs()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.DGV1.DataSource = STD.GET_ALL_STUDENTS();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_STUDENT FRM = new FRM_ADD_STUDENT();
            FRM.ShowDialog();
        }

        private void dataGridView1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = STD.SEARCHSTUDENT(txtsearch.Text);
            DGV1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_STUDENT frm = new FRM_ADD_STUDENT();
            frm.TXT_S_ID.Text = this.DGV1.CurrentRow.Cells[0].Value.ToString();
            frm.TXT_S_NAME.Text = this.DGV1.CurrentRow.Cells[1].Value.ToString();
            frm.TXT_ADDRESS.Text = this.DGV1.CurrentRow.Cells[2].Value.ToString();
            frm.BIRTH_D_S.Text = this.DGV1.CurrentRow.Cells[3].Value.ToString();
            frm.CMB_DEPT.Text = this.DGV1.CurrentRow.Cells[4].Value.ToString();
            frm.CMB_COLLAGE.Text = this.DGV1.CurrentRow.Cells[5].Value.ToString();
            frm.TXT_PHONE_S.Text = this.DGV1.CurrentRow.Cells[6].Value.ToString();
            frm.CMB_GENDER.Text = this.DGV1.CurrentRow.Cells[7].Value.ToString();
            byte[] image = (byte[])STD.GET_IMAGE_STUDENT(Convert.ToInt32(this.DGV1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
            MemoryStream ms = new MemoryStream(image);
            frm.pictureBox1.Image = Image.FromStream(ms);
            frm.Text = "تحديث بيانات الطالب " + this.DGV1.CurrentRow.Cells[1].Value.ToString();
            frm.btn_ok.Text = "تحديث";
            frm.STATE = "UPDATE";
            frm.TXT_S_ID.ReadOnly = true;
            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المنتوج المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                STD.deletestudent(Convert.ToInt32(this.DGV1.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DGV1.DataSource = STD.GET_ALL_STUDENTS();

            }
            else
            {
                MessageBox.Show("تمت إلغاءعملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void DGV1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                byte[] image = (byte[])STD.GET_IMAGE_STUDENT(Convert.ToInt32(this.DGV1.CurrentRow.Cells[0].Value.ToString())).Rows[0][0];
                MemoryStream ms = new MemoryStream(image);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                return;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.RPT_SINGLE_STD MYREPORT = new RPT.RPT_SINGLE_STD();
            MYREPORT.SetParameterValue("@std_id", DGV1.CurrentRow.Cells[0].Value.ToString());
            RPT.FRM_REPORT frm = new RPT.FRM_REPORT();
            frm.crystalReportViewer1.ReportSource = MYREPORT;
            frm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           try
            {

                if(comboBox1.Text== "طباعة الصور")
                {
                    RPT.FRM_REPORT frm = new RPT.FRM_REPORT();
                    RPT.RPT_ALL_STUDENTS myreport = new RPT.RPT_ALL_STUDENTS();
                    frm.crystalReportViewer1.ReportSource = myreport;
                    frm.ShowDialog();

                }
                else if(comboBox1.Text== "بدون صور")
                {
                    RPT.FRM_REPORT frm = new RPT.FRM_REPORT();
                    RPT.RPT_ALL_STD_WITHOUT_IMG RPT_WITHOUT = new RPT.RPT_ALL_STD_WITHOUT_IMG();
                    frm.crystalReportViewer1.ReportSource = RPT_WITHOUT;
                    frm.ShowDialog();
                }
            }
            catch
            {
                return;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
