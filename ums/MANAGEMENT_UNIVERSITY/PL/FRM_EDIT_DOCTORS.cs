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
   
    public partial class FRM_EDIT_DOCTORS : Form
    {
        BL.CLS_COURSE_DEP SRD = new BL.CLS_COURSE_DEP();
        BL.CLS_DOCTORS DCT = new BL.CLS_DOCTORS();
        public FRM_EDIT_DOCTORS()
        {
            InitializeComponent();
            CMB_ID_DEP2.DataSource = SRD.GET_ALL_DEPT_ID();
            CMB_ID_DEP2.DisplayMember = "DEP_ID";
        }

        private void CMB_ID_DEP2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CMP_NAME_DEP2.DataSource = SRD.GET_DEP_NAME(Convert.ToInt32(CMB_ID_DEP2.Text));
                CMP_NAME_DEP2.DisplayMember = "DEP_NAME";
            }
            catch
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXT_ADD2.Text == "" || TXT_ID_DOC2.Text == "" || TXT_NAME_DOC2.Text == "" || TXT_SAL2.Text == "" || TXT_SPC2.Text == "" || CMB_GNDER2.Text == "" || CMB_ID_DEP2.Text == "" || CMB_M2.Text == "" || CMP_NAME_DEP2.Text == "" || dateTimePicker12.Text == "")
                {
                    MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DCT.UPDATE_DOCTORS(Convert.ToInt32(TXT_ID_DOC2.Text), TXT_NAME_DOC2.Text, Convert.ToInt32(CMB_ID_DEP2.Text), CMP_NAME_DEP2.Text, dateTimePicker12.Text, CMB_GNDER2.Text, TXT_SAL2.Text, TXT_SPC2.Text, CMB_M2.Text, TXT_ADD2.Text);
                    MessageBox.Show("تمت التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   FRM_DOCTORS.getmainform. dataGridView1.DataSource = DCT.GET_ALL_DOCTORS();
                    TXT_ADD2.Text = "";
                    TXT_ID_DOC2.Text = "";
                    TXT_NAME_DOC2.Text = "";
                    TXT_SAL2.Text = "";
                    TXT_SPC2.Text = "";
                    CMB_GNDER2.Text = "";
                    CMB_ID_DEP2.Text = "";
                    CMB_M2.Text = "";
                    CMP_NAME_DEP2.Text = "";
                    dateTimePicker12.Text = "";

                }
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
