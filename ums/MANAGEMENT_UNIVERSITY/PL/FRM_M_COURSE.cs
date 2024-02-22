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
    public partial class FRM_M_COURSE : Form
    {
        BL.CLS_COURSE_DEP UP = new BL.CLS_COURSE_DEP();
        BL.CLS_COURSE GRD = new BL.CLS_COURSE();

        public FRM_M_COURSE()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_CRS_NAME.Text == "" || TXT_C_HOURS.Text == "" || TXT_ID_CRS.Text == "" || CMB_COURE_TYPE.Text == "")
                {
                    MessageBox.Show("هناك بيانات ناقصة", "خطأ في الادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    GRD.UPDATE_COURSE(Convert.ToInt32(TXT_ID_CRS.Text), TXT_CRS_NAME.Text, Convert.ToInt32(TXT_C_HOURS.Text), CMB_COURE_TYPE.Text);
                    MessageBox.Show("تم تحديث بيانات المادة :" + TXT_CRS_NAME.Text, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_COURSE.getmainform.Data_G_V.DataSource = UP.get_all_containt_course();

                }
            }
            catch
            {
                return;
            }
        }

        private void FRM_M_COURSE_Load(object sender, EventArgs e)
        {

        }

        private void TXT_CRS_NAME_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = UP.CHECK_NAME_COURCE(TXT_CRS_NAME.Text);
            if (dt.Rows.Count > 0)
            {
                if (MessageBox.Show(" هذا الاسم موجود (  " + TXT_CRS_NAME.Text + " )"+"\n"+"هل تريد استبدالة؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    TXT_CRS_NAME.Focus();
                    TXT_CRS_NAME.SelectionStart = 0;
                    TXT_CRS_NAME.SelectionLength = TXT_CRS_NAME.TextLength;
                }
            }

        }
    }
}
