using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.PL
{
    public partial class FRM_DEPS : Form
    {
        private static FRM_DEPS frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_DEPS getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_DEPS();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        BL.CLS_COURSE_DEP SRD = new BL.CLS_COURSE_DEP();

        BL.CLS_COURSE c_d = new BL.CLS_COURSE();
        public FRM_DEPS()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
           
           cmb_course_id.DataSource = SRD.get_all_idcoourse();
            cmb_course_id.DisplayMember = "COURSE_ID";
            cmb_dep_id.DataSource = SRD.GET_ALL_DEPT_ID();
            cmb_dep_id.DisplayMember = "DEP_ID";
            dataGridView1.DataSource = c_d.GET_ALL_CRS_DEPS();


        }

        private void TXT_ID_COURCE1_Validated(object sender, EventArgs e)
        {
            
           
        
        }

        private void cmb_course_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                cmb_course_name.DataSource = SRD.GET_NAME_COURCE(Convert.ToInt32( cmb_course_id.Text));
                cmb_course_name.DisplayMember = "COURSE_NAME";
                CMP_T_COURSE.DataSource = SRD.GET_TYPE_COURSE(Convert.ToInt32(cmb_course_id.Text ));
                CMP_T_COURSE.DisplayMember = "type_course";

            }catch
            {
                return;
            }
            }

        private void cmb_dep_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_dep_name.DataSource = SRD.GET_DEP_NAME(Convert.ToInt32(cmb_dep_id.Text));
                cmb_dep_name.DisplayMember = "DEP_NAME";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb_term.Text == "" || cmb_level.Text == ""||cmb_dep_name.Text=="")
            {
                MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SRD.ADD_CRS_TO_DEPT(Convert.ToInt32(cmb_course_id.Text), Convert.ToInt32(cmb_dep_id.Text), cmb_term.Text, cmb_level.Text, CMP_T_COURSE.Text, cmb_course_name.Text, cmb_dep_name.Text);

                MessageBox.Show("تمت الإضافة", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CMP_T_COURSE.Text = "";
                cmb_term.Text = "";
                cmb_level.Text = "";
                cmb_dep_name.Text = "";
                cmb_course_name.Text = "";
                cmb_dep_id.Text = "";
                cmb_course_id.Text = "";
                dataGridView1.DataSource = c_d.GET_ALL_CRS_DEPS();

            }
        }

        private void cmb_course_id_Validated(object sender, EventArgs e)
        {
          
        }

        private void cmb_dep_id_Validated(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = SRD.CHECK_ADD_COURSE(Convert.ToInt32(cmb_course_id.Text),Convert.ToInt32(cmb_dep_id.Text));
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("هذه المادة تمت إضافتها لهذا القسم مسبقا", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmb_dep_id.Focus();
                cmb_dep_id.SelectionStart = 0;
                cmb_dep_id.SelectionLength = cmb_dep_id.Width;
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("هل تريدالحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    c_d.DELETE_CRS_FROM_DEPS(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString()));
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = c_d.GET_ALL_CRS_DEPS();
                }

            }
            catch
            {
                return;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                FRM_EDIT_CRS_DEP FRM = new FRM_EDIT_CRS_DEP();
                FRM.TXT_CRS_ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                FRM.TXT_CRS_NM.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
                FRM.cmb_dep_id2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FRM.cmb_dep_name2.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                FRM.cmb_term2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                FRM.cmb_level2.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                FRM.TXT_CRS_TYPE.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
                cmb_course_id.DropDownStyle = ComboBoxStyle.DropDownList;
                FRM.ShowDialog();

            }
            catch
            {
                return;
            }
        }
    }
}
