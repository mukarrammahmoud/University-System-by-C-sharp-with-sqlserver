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
    public partial class FRM_EDIT_CRS_DEP : Form
    {
        BL.CLS_COURSE CRS = new BL.CLS_COURSE();
        BL.CLS_COURSE_DEP CRS_D = new BL.CLS_COURSE_DEP();
        public FRM_EDIT_CRS_DEP()
        {
            InitializeComponent();
            cmb_dep_id2.DataSource = CRS_D.GET_ALL_DEPT_ID();
            cmb_dep_id2.DisplayMember = "DEP_ID";

        }

        private void cmb_course_id2_MouseMove(object sender, MouseEventArgs e)
        {
            //333SAEcmb_course_id2.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmb_dep_id2_Validated(object sender, EventArgs e)
        { DataTable dt = new DataTable();
            dt = CRS_D.CHECK_ADD_COURSE(Convert.ToInt32(TXT_CRS_ID.Text), Convert.ToInt32(cmb_dep_id2.Text));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("هذه المادة تمت إضافتها لهذا القسم مسبقا", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_dep_id2.Focus();
                cmb_dep_id2.SelectionStart = 0;
                cmb_dep_id2.SelectionLength = cmb_dep_id2.Width;
            }
        }

        private void cmb_dep_id2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_dep_name2.DataSource = CRS_D.GET_DEP_NAME(Convert.ToInt32(cmb_dep_id2.Text));
                cmb_dep_name2.DisplayMember = "DEP_NAME";
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
                if (TXT_CRS_TYPE.Text == "" || cmb_dep_name2.Text == "" || cmb_term2.Text == "" || cmb_level2.Text == "" || cmb_dep_id2.Text == "" || TXT_CRS_ID.Text == "" || TXT_CRS_NM.Text == "" )
                {
                    MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    CRS_D.UPDATE_CRS_DEP(Convert.ToInt32(TXT_CRS_ID.Text),TXT_CRS_NM.Text,Convert.ToInt32( cmb_dep_id2.Text), cmb_dep_name2.Text,cmb_term2.Text,cmb_level2.Text,TXT_CRS_TYPE.Text);
                    MessageBox.Show("تمت التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_DEPS.getmainform.dataGridView1.DataSource = CRS.GET_ALL_CRS_DEPS();
                    TXT_CRS_TYPE.Text = "";
                    TXT_CRS_NM.Text = "";
                    cmb_dep_id2.Text = "";
                    cmb_level2.Text = "";
                    cmb_term2.Text = "";
                    TXT_CRS_ID.Text = "";
                    cmb_dep_name2.Text = "";
                  

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
