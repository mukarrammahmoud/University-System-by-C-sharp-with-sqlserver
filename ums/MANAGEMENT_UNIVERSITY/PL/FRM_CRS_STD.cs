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
    public partial class FRM_CRS_STD : Form
    {
        private static FRM_CRS_STD frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_CRS_STD getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_CRS_STD();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        BL.CLS_COURSE_DEP CRS_DEP = new BL.CLS_COURSE_DEP();
        BL.CLS_GRADES GRD = new BL.CLS_GRADES();

        public FRM_CRS_STD()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            CMB_DEP_ID.DataSource = CRS_DEP.GET_ALL_DEPT_ID();
            CMB_DEP_ID.DisplayMember = "DEP_ID";
            CMB_DEP_ID.ValueMember = "DEP_ID";
            DGV_RESULTS.DataSource = GRD.GET_ALL_RESULTS();
            CMB_CRS_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            CMB_CRS_NAME.DropDownStyle = ComboBoxStyle.DropDownList;
            CMB_DEP_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            CMB_NAME_DEP.DropDownStyle = ComboBoxStyle.DropDownList;
            CMB_STD_ID.DropDownStyle = ComboBoxStyle.DropDownList;
            CMB_STD_NAME.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CMB_CRS_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CMB_CRS_ID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void CMB_DEP_ID_SelectedValueChanged(object sender, EventArgs e)
        {
            // Int32 S =Convert.ToInt32( CMB_CRS_ID.SelectedValue);


            ////CMB_CRS_NAME.DataSource = CRS_DEP.GET_NAME_COURCE(CMB_CRS_ID.SelectedIndex + 1);
            ////CMB_CRS_NAME.DisplayMember = "COURSE_NAME";
        }

        private void CMB_CRS_ID_SelectedValueChanged(object sender, EventArgs e)
        {
            ////CMB_CRS_ID.DataSource = GRD.SELECT_CRSID_FRPM_DEP(CMB_DEP_ID.SelectedIndex + 1);
            ////CMB_CRS_ID.DisplayMember = "COURSE_ID";
            //CMB_CRS_NAME.DataSource = CRS_DEP.GET_NAME_COURCE(CMB_CRS_ID.SelectedIndex + 1);
            //CMB_CRS_NAME.DisplayMember = "COURSE_NAME";
        }

        private void CMB_DEP_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            CMB_STD_ID.Text = "";
            CMB_CRS_NAME.Text = "";
            CMB_CRS_ID.Text = "";
            try
            {
                CMB_NAME_DEP.DataSource = CRS_DEP.GET_DEP_NAME(Convert.ToInt32(CMB_DEP_ID.Text));
                CMB_NAME_DEP.DisplayMember = "DEP_NAME";
                //CMB_NAME_DEP.ValueMember = "DEP_ID";
                CMB_CRS_ID.DataSource = GRD.SELECT_CRSID_FRPM_DEP(Convert.ToInt32(CMB_DEP_ID.Text));
                CMB_CRS_ID.DisplayMember = "COURSE_ID";
                //CMB_CRS_ID.ValueMember = "COURSE_ID";
                CMB_STD_ID.DataSource = GRD.GET_STD_ID(CMB_NAME_DEP.Text);
                CMB_STD_ID.DisplayMember = "STE_ID";
                CMB_CRS_NAME.DataSource = CRS_DEP.GET_NAME_COURCE(Convert.ToInt32(CMB_CRS_ID.Text));
                CMB_CRS_NAME.DisplayMember = "COURSE_NAME";
                CMB_STD_NAME.DataSource = GRD.GET_STD_NAME(Convert.ToInt32(CMB_STD_ID.Text));
                CMB_STD_NAME.DisplayMember = "STE_NAME";

            }
            catch
            {
                return;
            }

        }

        private void CMB_CRS_ID_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            //CMB_CRS_NAME.Text = "";
            try
            {
                CMB_CRS_NAME.DataSource = CRS_DEP.GET_NAME_COURCE(Convert.ToInt32(CMB_CRS_ID.Text));
                CMB_CRS_NAME.DisplayMember = "COURSE_NAME";
            }
            catch
            {
                return;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listBox1.DataSource = CRS_DEP.GET_DEP_NAME(Convert.ToInt16(CMB_DEP_ID.SelectedValue));
            //listBox1.DisplayMember = "COURSE_NAME";
        }

        private void CMB_STD_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // CMB_STD_ID.Text = "";
            try
            {
                CMB_STD_NAME.DataSource = GRD.GET_STD_NAME(Convert.ToInt32(CMB_STD_ID.Text));
                CMB_STD_NAME.DisplayMember = "STE_NAME";
                CMB_STD_NAME.ValueMember = "STE_ID";
            }
            catch { return; }
        }

        private void CMB_NAME_DEP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Validated(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox4.Text) <= 100 && Convert.ToInt32(textBox4.Text) >= 0)
                {

                    if (Convert.ToInt32(textBox4.Text) >= 90)
                    {
                        textBox5.Text = "ممتاز";
                        textBox5.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(textBox4.Text) >= 80)
                    {
                        textBox5.Text = "جيد جدا";
                        textBox5.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(textBox4.Text) >= 75)
                    {
                        textBox5.Text = "جيد";
                        textBox5.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(textBox4.Text) >= 60)
                    {
                        textBox5.Text = "مقبول";
                        textBox5.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(textBox4.Text) >= 50)
                    {
                        textBox5.Text = "ضعيف";
                        textBox5.ReadOnly = true;
                    }
                    else if (Convert.ToInt32(textBox4.Text) < 50)
                    {
                        textBox5.Text = "راسب";
                        textBox5.ReadOnly = true;
                    }
                }
                else
                {
                    MessageBox.Show("درجة غير مقبولة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Focus();

                }

            }
            catch { return; }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (Convert.ToInt32(textBox4.Text) <= 100 && Convert.ToInt32(textBox4.Text) >= 0)
                {

                    if (Convert.ToInt32(textBox4.Text) >= 90)
                    {
                        textBox5.Text = "ممتاز";
                        textBox5.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(textBox4.Text) >= 80)
                    {
                        textBox5.Text = "جيد جدا";
                        textBox5.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(textBox4.Text) >= 75)
                    {
                        textBox5.Text = "جيد";
                        textBox5.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(textBox4.Text) >= 60)
                    {
                        textBox5.Text = "مقبول";
                        textBox5.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(textBox4.Text) >= 50)
                    {
                        textBox5.Text = "ضعيف";
                        textBox5.ReadOnly = true;
                    }
                    else if (Convert.ToInt32(textBox4.Text) < 50)
                    {
                        textBox5.Text = "راسب";
                        textBox5.ReadOnly = true;
                    }
                }
                else
                {
                    MessageBox.Show("درجة غير مقبولة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Focus();
                    textBox4.SelectionStart = 0;
                    textBox4.SelectionLength = textBox4.TextLength;

                }

            }
            catch { return; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                dt = GRD.CHECK_CRS_ID_STD_ID(Convert.ToInt32(CMB_CRS_ID.Text), Convert.ToInt32(CMB_STD_ID.Text));
                if (CMB_DEP_ID.Text == "" || CMB_NAME_DEP.Text == "" || CMB_STD_ID.Text == "" || CMB_STD_NAME.Text == "" || CMB_CRS_ID.Text == "" || CMB_CRS_NAME.Text == "" || textBox4.Text == "" || textBox5.Text == "")
                {
                    MessageBox.Show("هناك بيانات ناقصة", "خطأ في الادخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
               else if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("هذه المادة موجودة مسبقا", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    CMB_CRS_ID.Focus();
                    CMB_CRS_ID.SelectionStart = 0;
                    CMB_CRS_ID.SelectionLength = CMB_CRS_ID.Width;
                }

                else
                {

                    GRD.ADD_RUSELTS_COURSE(Convert.ToInt32(CMB_STD_ID.Text), CMB_STD_NAME.Text, Convert.ToInt32(CMB_CRS_ID.Text), CMB_CRS_NAME.Text, textBox4.Text, textBox5.Text,CMB_NAME_DEP.Text);
                    MessageBox.Show("تمت الإضافة بنجاح ", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_RESULTS.DataSource = GRD.GET_ALL_RESULTS();
                    CMB_CRS_ID.Text = "";
                    CMB_CRS_NAME.Text = "";
                    CMB_DEP_ID.Text = "";
                    CMB_NAME_DEP.Text = "";
                    CMB_STD_ID.Text = "";
                    CMB_STD_NAME.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";


                }
                
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
                if (MessageBox.Show("هل تريدالحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    GRD.DELETE_RESULT(Convert.ToInt32(DGV_RESULTS.CurrentRow.Cells[0].Value.ToString()), Convert.ToInt32(DGV_RESULTS.CurrentRow.Cells[2].Value.ToString()));
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DGV_RESULTS.DataSource = GRD.GET_ALL_RESULTS();
                }

            }
            catch
            {
                return;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_EDIT_RESULTE frm = new FRM_EDIT_RESULTE();
            frm.CMB_CRS_ID2.Text =Convert.ToString( this.DGV_RESULTS.CurrentRow.Cells[0].Value);

            frm.CMB_CRS_NAME2.Text =Convert.ToString( this.DGV_RESULTS.CurrentRow.Cells[1].Value);
          
            frm.CMB_STD_NAME2.Text =Convert.ToString( this.DGV_RESULTS.CurrentRow.Cells[3].Value);

            frm.CMB_STD_ID2.Text=Convert.ToString( this.DGV_RESULTS.CurrentRow.Cells[2].Value);

            frm.TXT_GRD.Text = this.DGV_RESULTS.CurrentRow.Cells[4].Value.ToString();

            frm.TXT_AV.Text = this.DGV_RESULTS.CurrentRow.Cells[5].Value.ToString();

            frm.TXT_AV.ReadOnly = true;
            

           
            frm.ShowDialog();


        }

        private void CMB_CRS_ID_Validated(object sender, EventArgs e)
        {
            try
            {

                //DataTable dt = new DataTable();
                //dt = GRD.CHECK_CRS_ID_STD_ID(Convert.ToInt32(CMB_CRS_ID.Text),Convert.ToInt32( CMB_STD_ID.Text));
                //if (dt.Rows.Count > 0)
                //{
                //    MessageBox.Show("هذه المادة موجودة مسبقا", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    CMB_CRS_ID.Focus();
                //    CMB_CRS_ID.SelectionStart = 0;
                //    CMB_CRS_ID.SelectionLength = CMB_CRS_ID.Width;
                //}
            }
            catch
            {
                return;
            }
        }

        private void FRM_CRS_STD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_DBDataSet.GET_ALL_CRS_DEPS' table. You can move, or remove it, as needed.
           // this.gET_ALL_CRS_DEPSTableAdapter.Fill(this.university_DBDataSet.GET_ALL_CRS_DEPS);

        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            try
            {
                RPT.RPT_RESULT_OF_STD RST = new RPT.RPT_RESULT_OF_STD();
                RST.SetParameterValue("@STD_NAME", DGV_RESULTS.CurrentRow.Cells[3].Value.ToString());

                RPT.FRM_REPORT frm = new RPT.FRM_REPORT();
                frm.crystalReportViewer1.ReportSource = RST;

                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

            try
            {
                RPT.RPT_RESULT_ALL_STD RSTA = new RPT.RPT_RESULT_ALL_STD();


                RPT.FRM_REPORT frm = new RPT.FRM_REPORT();
                frm.crystalReportViewer1.ReportSource = RSTA;

                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void CMB_CRS_NAME_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
