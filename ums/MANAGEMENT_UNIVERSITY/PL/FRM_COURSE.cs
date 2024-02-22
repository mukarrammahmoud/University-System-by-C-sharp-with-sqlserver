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
    public partial class FRM_COURSE : Form

    {

        private static FRM_COURSE frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_COURSE getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_COURSE();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        BL.CLS_COURSE CRS = new BL.CLS_COURSE();
        BL.CLS_COURSE_DEP crs_d = new BL.CLS_COURSE_DEP();
        
        public FRM_COURSE()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
           
            Data_G_V.DataSource = crs_d.get_all_containt_course();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_course.Text == "" || TXT_ID_COURCE.Text == "" || TXT_HOURS.Text == "" || TXT_NAME_COURSE.Text == "")
            {
                MessageBox.Show("هناك بيانات ناقصة", "خطأ في الادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                CRS.ADD_COURCE(Convert.ToInt32(TXT_ID_COURCE.Text), TXT_NAME_COURSE.Text, Convert.ToInt32(TXT_HOURS.Text), cmb_course.Text);

                MessageBox.Show("تمت الإضافة", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT_ID_COURCE.Clear();
                TXT_NAME_COURSE.Clear();
                TXT_HOURS.Clear();
                cmb_course.Text = "";
                Data_G_V.DataSource = crs_d.get_all_containt_course();
            }
        }

        private void TXT_ID_COURCE_Validated(object sender, EventArgs e)
        {
            if (TXT_ID_COURCE.Text == "")
            {

            }
            else
            {
                DataTable DATAT = new DataTable();

                DATAT = CRS.verifycourceid(Convert.ToInt32(TXT_ID_COURCE.Text));
                if (DATAT.Rows.Count > 0)
                {
                    MessageBox.Show("هذا الرقم موجود مسبقا", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_ID_COURCE.Focus();
                    TXT_ID_COURCE.SelectionStart = 0;
                    TXT_ID_COURCE.SelectionLength = TXT_ID_COURCE.TextLength;

                }
            }
        }

        private void TXT_NAME_COURSE_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = CRS.verifycourcename(TXT_NAME_COURSE.Text);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show(" هذا الاسم موجود مسبقا ", "تنبيه ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                    TXT_NAME_COURSE.Focus();
                    TXT_NAME_COURSE.SelectionStart = 0;
                    TXT_NAME_COURSE.SelectionLength = TXT_NAME_COURSE.TextLength;

            }
        }

       
        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف المادة المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
               crs_d.delete_course(Convert.ToInt32(this.Data_G_V.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
              this.Data_G_V.DataSource = crs_d.get_all_containt_course();

            }
            else
            {
                MessageBox.Show("تمت إلغاءعملية الحذف ", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

           
        }

        private void FRM_COURSE_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FRM_M_COURSE frm = new FRM_M_COURSE();
           frm.TXT_ID_CRS .Text = this.Data_G_V.CurrentRow.Cells[0].Value.ToString();
           frm.TXT_CRS_NAME.Text = this.Data_G_V.CurrentRow.Cells[1].Value.ToString();
          frm.TXT_C_HOURS .Text = this.Data_G_V.CurrentRow.Cells[2].Value.ToString();
          frm.CMB_COURE_TYPE.Text = this.Data_G_V.CurrentRow.Cells[3].Value.ToString();
            
          
           frm.ShowDialog();
        }

    }

}
