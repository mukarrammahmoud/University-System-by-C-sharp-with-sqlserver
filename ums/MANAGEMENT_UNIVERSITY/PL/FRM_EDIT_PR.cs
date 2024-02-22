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
    public partial class FRM_EDIT_PR : Form
    {
        BL.CLS_PRESENT PR_AB = new BL.CLS_PRESENT();
        public FRM_EDIT_PR()
        {
            InitializeComponent();
           


          }

        private void FRM_EDIT_PR_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                PR_AB.UPDATE_PR(txt_doc_name.Text, TXT_DATE.Text, txt_dep_name.Text, CMB_DAYS2.Text, CMB_PA2.Text);
                MessageBox.Show("تم التعــديـل", "عملـيـة التعــديـل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_PRT_AST.getmainform.dataGridView1.DataSource = PR_AB.GET_ALL_FROM_PR_AB();
            }
            catch
            {
                return;
            }
        }
    }
}
