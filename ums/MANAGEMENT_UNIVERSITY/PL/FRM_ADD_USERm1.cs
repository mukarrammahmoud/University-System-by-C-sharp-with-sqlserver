using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MANAGEMENT_UNIVERSITY.DAL
{
    public partial class FRM_ADD_USERm1 : Form
    { BL.ClS_USERS use = new BL.ClS_USERS();
        public string state = "add";
        public FRM_ADD_USERm1()
        {
          
            InitializeComponent();
            try
            {
                CMB_TYPE_USE.DataSource = use.GET_TYPE_USER();
                CMB_TYPE_USE.DisplayMember = "TYPE_USER";
                pct_psw.Visible = false;
                pct_c_psw.Visible = false;
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

        private void TXT_COMVORT_PSW_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TXT_COMVORT_PSW_Validated(object sender, EventArgs e)
        {try
            {


                if (TXT_COMVORT_PSW.Text != TXT_PSW.Text)
                {
                    MessageBox.Show("كلمة المرور غير متوافقة", "خطأ في عملية التأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXT_COMVORT_PSW.Focus();
                    TXT_COMVORT_PSW.SelectionStart = 0;
                    TXT_COMVORT_PSW.SelectionLength = TXT_COMVORT_PSW.TextLength;
                }
            }
            catch
            {
                return;
            }
        }

        private void TXT_ID_Validated(object sender, EventArgs e)
        {
            try
            {if (state == "add")
                {
                    DataTable dt = new DataTable();
                    dt = use.check_user_id(Convert.ToInt32(TXT_ID.Text));
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("هذا الرقم موجود ", "تكرار رقم المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TXT_ID.Focus();
                        TXT_ID.SelectionStart = 0;
                        TXT_ID.SelectionLength = TXT_ID.TextLength;
                    }
                }
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
                if (state == "add")
                {
                    if (TXT_ID.Text == string.Empty || TXT_NM.Text == string.Empty || TXT_PSW.Text == string.Empty || TXT_COMVORT_PSW.Text == string.Empty || CMB_TYPE_USE.Text == string.Empty)
                    {
                        MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        use.add_user(Convert.ToInt32(TXT_ID.Text), TXT_NM.Text, TXT_PSW.Text, CMB_TYPE_USE.Text);
                        MessageBox.Show("تمت الإضافة", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TXT_PSW.Text = string.Empty;
                        TXT_ID.Text = string.Empty;
                        TXT_NM.Text = string.Empty;
                        CMB_TYPE_USE.Text = string.Empty;
                        TXT_COMVORT_PSW.Text = string.Empty;
                    }
                }
                else if(state=="update")
                {
                    if (TXT_ID.Text == string.Empty || TXT_NM.Text == string.Empty || TXT_PSW.Text == string.Empty || TXT_COMVORT_PSW.Text == string.Empty || CMB_TYPE_USE.Text == string.Empty)
                    {
                        MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        use.update_users(Convert.ToInt32(TXT_ID.Text), TXT_NM.Text, TXT_PSW.Text, CMB_TYPE_USE.Text);
                        MessageBox.Show("تم التعديل", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
              PL.FRM_USER.getmainform. dataGridView1.DataSource = use.GET_ALL_USERS();
            }
            catch (Exception)
            {
                {
                    return;
                }
                throw;
            }
        }

        private void pct_v_psw_Click(object sender, EventArgs e)
        {
            try
            {
                pct_v_psw.Visible = false;
                pct_psw.Visible = true;
                TXT_PSW.UseSystemPasswordChar = false;

            }
            catch
            {
                return;
            }
        }

        private void pct_v_c_psw_Click(object sender, EventArgs e)
        {
        
        }

        private void pct_v_c_psw_Click_1(object sender, EventArgs e)
        {
            try
            {
                pct_v_c_psw.Visible = false;
                pct_c_psw.Visible = true;
                TXT_COMVORT_PSW.UseSystemPasswordChar = false;

            }
            catch
            {
                return;
            }
        }

        private void pct_psw_Click(object sender, EventArgs e)
        {
            try
            {
                pct_v_psw.Visible = true;
                pct_psw.Visible = false;
                TXT_PSW.UseSystemPasswordChar = true;

            }
            catch
            {
                return;
            }
        }

        private void pct_c_psw_Click(object sender, EventArgs e)
        {
            try
            {
                pct_v_c_psw.Visible = true;
                pct_c_psw.Visible = false;
                TXT_COMVORT_PSW.UseSystemPasswordChar = true;

            }
            catch
            {
                return;
            }
        }
    }
}
