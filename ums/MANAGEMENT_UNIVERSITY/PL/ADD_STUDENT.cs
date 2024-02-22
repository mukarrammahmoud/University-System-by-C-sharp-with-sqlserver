using System;
using System.Collections.Generic;
using System.ComponentModel;

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
    public partial class FRM_ADD_STUDENT : Form
    {
        FRM_M_STUDENTScs FRM = new FRM_M_STUDENTScs();
        BL.CLS_STUDENTS STD = new BL.CLS_STUDENTS();
        public string STATE="ADD";
        public FRM_ADD_STUDENT()
        {
            try
            {


                InitializeComponent();
                CMB_COLLAGE.DataSource = STD.GETT_ALL_COLLAGE();
                CMB_COLLAGE.DisplayMember = "CLG_NAME";
                CMB_COLLAGE.ValueMember = "CLG_ID";
                CMB_DEPT.DataSource = STD.GETT_ALL_DEPARTMENT(Convert.ToInt32(CMB_COLLAGE.SelectedIndex+1));
                CMB_DEPT.DisplayMember = "DEP_NAME";
                pictureBox1.Image = Image.FromFile("D://UMS//UMS.png");
            }
            catch
            {
                return;
            }


        }

        private void CMB_COLLAGE_SelectedIndexChanged(object sender, EventArgs e)
        {try
            {



                CMB_DEPT.DataSource = STD.GETT_ALL_DEPARTMENT(Convert.ToInt32(CMB_COLLAGE.SelectedIndex+1));
                CMB_DEPT.DisplayMember = "DEP_NAME";
                // CMB_DEPT.ValueMember = "DEP_ID";
            }
            catch
            {
                return;
            }
        }

        private void FRM_ADD_STUDENT_Load(object sender, EventArgs e)
        {

        }

        private void CMB_COLLAGE_SelectedValueChanged(object sender, EventArgs e)
        {
            //CMB_DEPT.ValueMember = "";
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "ملفات الصور |*.JPG;*.PNG;*.GIF;*.BMP;";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (STATE == "ADD")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                STD.ADD_STUDENT(Convert.ToInt32(TXT_S_ID.Text), TXT_S_NAME.Text, CMB_GENDER.Text, TXT_PHONE_S.Text, TXT_ADDRESS.Text, BIRTH_D_S.Text, CMB_COLLAGE.Text, CMB_DEPT.Text, byteimage);
                MessageBox.Show("تمت الإضافة", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TXT_ADDRESS.Text = string.Empty;
                TXT_PHONE_S.Text = string.Empty;
                TXT_S_ID.Text = string.Empty;
                TXT_S_NAME.Text = string.Empty;
                CMB_COLLAGE.Text = string.Empty;
                CMB_DEPT.Text = string.Empty;
                CMB_GENDER.Text = string.Empty;
                BIRTH_D_S.Text = string.Empty;
            }
        else if(STATE=="UPDATE")
            {
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] byteimage = ms.ToArray();
                STD.UPDATE_STUDENTS(Convert.ToInt32(TXT_S_ID.Text), TXT_S_NAME.Text, CMB_GENDER.Text, TXT_PHONE_S.Text, TXT_ADDRESS.Text, BIRTH_D_S.Text, CMB_COLLAGE.Text, CMB_DEPT.Text, byteimage);
                MessageBox.Show("تم التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            FRM_M_STUDENTScs.getmainform.DGV1.DataSource = STD.GET_ALL_STUDENTS();
        
        }

        private void TXT_S_ID_Validated(object sender, EventArgs e)
        {
            try
            {
                if (STATE == "ADD")
                {
                    DataTable dt = new DataTable();
                    dt = STD.verifystudentid(Convert.ToInt32(TXT_S_ID.Text));
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("هذا الرقم موجود مسبقا", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        TXT_S_ID.Focus();
                        TXT_S_ID.SelectionStart = 0;
                        TXT_S_ID.SelectionLength = TXT_S_ID.TextLength;

                    }
                }
            }
            catch

            {
                return;
            }
            
        }

        private void CMB_DEPT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TXT_S_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
