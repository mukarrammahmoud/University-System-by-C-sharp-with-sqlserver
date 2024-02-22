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
    public partial class FRM_LOGIN : Form
    { BL.ClS_USERS USE = new BL.ClS_USERS();
        public FRM_LOGIN()
        {
            InitializeComponent();
            
        
                cmb_use.DataSource = USE.GET_TYPE_USER();
                cmb_use.DisplayMember = "TYPE_USER";
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                txt_psw.UseSystemPasswordChar = false;
                PCTB_V.Visible = true;
                PCTB_A.Visible = false;
            }
            else if(checkBox1.Checked==false)
            {
                txt_psw.UseSystemPasswordChar = true;
                PCTB_V.Visible = false;
                PCTB_A.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PCTB_V_Click(object sender, EventArgs e)
        {
            //PCTB_V.Visible = true;

            //PCTB_A.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = new DataTable();
                DT = USE.CHECK_PAS_USER(txt_usr.Text, txt_psw.Text, cmb_use.Text);
                if(DT.Rows.Count>0)
                {if (cmb_use.Text == "رئيس")
                    {
                        FRM_MAIN.getmainform.الشؤونالماليةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.الToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.التسجيلToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.لفToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.الكلياتToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.جلبنسخةإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.حفظنسخةإحتياطيةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.toolStripMenuItem1.Enabled = true;
                        this.Close();


                    }
                    if (cmb_use.Text == "مسؤول مالي")
                    {
                        FRM_MAIN.getmainform.الشؤونالماليةToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.الToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.التسجيلToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.لفToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.الكلياتToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.toolStripMenuItem1.Enabled = false;
                        this.Close();
                    }
                    if (cmb_use.Text == "المسجل العام")
                    {
                        FRM_MAIN.getmainform.الشؤونالماليةToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.الToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.التسجيلToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.لفToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.الكلياتToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.toolStripMenuItem1.Enabled = false;
                      

                        this.Close();
                    }
                    if (cmb_use.Text == "رئيس الكنترول")
                    {
                        FRM_MAIN.getmainform.الشؤونالماليةToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.الToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.التسجيلToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.لفToolStripMenuItem.Enabled = true;
                        FRM_MAIN.getmainform.الكلياتToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.المستخدمونToolStripMenuItem.Enabled = false;
                        FRM_MAIN.getmainform.toolStripMenuItem1.Enabled = false;
                        this.Close();
                    }
                
                }
                else
                {
                    MessageBox.Show("فشل تسجيل الدخول", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                return;
            }
        }

        private void txt_psw_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_use_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
