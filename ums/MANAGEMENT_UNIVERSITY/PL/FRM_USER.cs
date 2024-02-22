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
   
    public partial class FRM_USER : Form
    {
        private static FRM_USER frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_USER getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_USER();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }

        BL.ClS_USERS USE = new BL.ClS_USERS();

        public FRM_USER()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
           dataGridView1.DataSource= USE.GET_ALL_USERS();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = USE.SEARCH_USER(txt_search.Text);
            }
            catch
            {
                return;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
         
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
          
        }

        private void treeView1_TabIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DAL.FRM_ADD_USERm1 FRM = new DAL.FRM_ADD_USERm1();
            FRM.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("هل تريدالحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    USE.delete_user(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = USE.GET_ALL_USERS();
                }

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
                DAL.FRM_ADD_USERm1 FRM = new DAL.FRM_ADD_USERm1();
                FRM.TXT_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                FRM.TXT_NM.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                FRM.TXT_PSW.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                FRM.CMB_TYPE_USE.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                FRM.button1.Text = "تعديل";
                FRM.button1.ImageList = this.imageList1;
                FRM.state = "update";
                FRM.TXT_ID.ReadOnly = true;
                FRM.TXT_NM.Focus();

                FRM.ShowDialog();
            }
            catch
            {
                return;
            }
        }
    }
}
