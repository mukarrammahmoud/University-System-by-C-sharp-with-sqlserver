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
    public partial class FRM_FEES : Form
        
    {
        private static FRM_FEES frm;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_FEES getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_FEES();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        BL.CLS_FEES FS = new BL.CLS_FEES();
        BL.CLS_PRESENT sr = new BL.CLS_PRESENT();
        public FRM_FEES()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource=FS.GET_ALL_FEES_SAL();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
               CMB_DOC_NAM.DataSource= FS.GET_DOC_NAME(Convert.ToInt32( TXT_DOC_ID.Text));
                CMB_DOC_NAM.DisplayMember = "DOC_NAME";
                CMB_SAL.DataSource = FS.GET_SAL_DOC(Convert.ToInt32(TXT_DOC_ID.Text));
                CMB_SAL.DisplayMember = "SALARY";
                CMB_COUNT_AB.DataSource = FS.GET_ABSENT_DOC(CMB_DOC_NAM.Text);
                CMB_COUNT_AB.DisplayMember = "ABSENT";
            }
            catch
            {
                return;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            try
            {

                dataGridView1.DataSource = FS.GET_ALL_FESS(Convert.ToInt32(TXT_STD_ID.Text));
                dataGridView1.DataSource = FS.GET_ALL_FESS_2(Convert.ToInt32(TXT_STD_ID.Text), CMB_LEVEL.Text);

                DataTable DT = new DataTable();
                DT= FS.GET_ID_STD_TO_FEES(Convert.ToInt32(TXT_STD_ID.Text));
                if (DT.Rows.Count > 0)
                {
                    CMB_STD_NAME.DataSource = FS.GET_ID_STD_TO_FEES(Convert.ToInt32(TXT_STD_ID.Text));
                    CMB_STD_NAME.DisplayMember = "STE_NAME";
                    CMB_STD_NAME.DropDownStyle = ComboBoxStyle.DropDownList;
                    CMB_STD_NAME.Enabled = true;
                    CMB_DEP_NM.DataSource = FS.GET_DEP_NAME_FROM_STD(CMB_STD_NAME.Text);
                    CMB_DEP_NM.DisplayMember = "DEPARTMENT";
                    CMB_DEP_NM.DropDownStyle = ComboBoxStyle.DropDownList;
                    CMB_DEP_NM.Enabled = true;
                    CMB_FEES.DataSource = FS.GET_FEES(CMB_DEP_NM.Text);
                    CMB_FEES.DisplayMember = "FEES";
                    CMB_FEES.DropDownStyle = ComboBoxStyle.DropDownList;
                    CMB_FEES.Enabled = true;
                    CMB_REST.DataSource = FS.GET_REST_FEES(Convert.ToInt32(TXT_STD_ID.Text), CMB_LEVEL.Text);
                    CMB_REST.DisplayMember = "REST_OF_FEES";
                    CMB_REST.DropDownStyle = ComboBoxStyle.DropDownList;
                    CMB_REST.Enabled = true;
                    try
                    {
                        DataTable dta = new DataTable();
                        dta = FS.GET_REST_FEES(Convert.ToInt32(TXT_STD_ID.Text), CMB_LEVEL.Text);
                        if (dta.Rows.Count > 0)
                        {
                            CMB_REST.DataSource = dta;

                            CMB_REST.DisplayMember = "REST_OF_FEES";
                            CMB_REST.DropDownStyle = ComboBoxStyle.DropDownList;
                        }
                        
                        else
                        {
                            CMB_FEES.DropDownStyle = ComboBoxStyle.DropDown;
                            CMB_REST.DropDownStyle = ComboBoxStyle.DropDown;
                            CMB_REST.Text = CMB_FEES.Text;
                            //CMB_REST.DropDownStyle = ComboBoxStyle.DropDownList;
                            CMB_FEES.DropDownStyle = ComboBoxStyle.DropDownList;
                            
                            //if(CMB_REST.DropDownStyle == ComboBoxStyle.DropDown)
                            //CMB_REST.DropDownStyle = ComboBoxStyle.DropDownList;




                        }
                    }
                    catch
                    {
                        return;
                    }
                    //CMB_REST.DataSource = FS.GET_REST_FEES(Convert.ToInt32(TXT_STD_ID.Text), CMB_LEVEL.Text);
                    //CMB_REST.DisplayMember = "REST";

                }
                else
                {
                    CMB_STD_NAME.DropDownStyle = ComboBoxStyle.DropDown;            
                    CMB_STD_NAME.Text = "";
                    CMB_STD_NAME.Enabled = false;

                    CMB_DEP_NM.DropDownStyle = ComboBoxStyle.DropDown;
                    CMB_DEP_NM.Text = "";
                    CMB_DEP_NM.Enabled = false;

                    CMB_FEES.DropDownStyle = ComboBoxStyle.DropDown;
                    CMB_FEES.Text = "";
                    CMB_FEES.Enabled = false;

                    CMB_REST.DropDownStyle = ComboBoxStyle.DropDown;
                    CMB_REST.Text = "";
                    CMB_REST.Enabled = false;
                }
            }
            
            catch
            {
                return;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
         {
        
        }

        private void FRM_FEES_Load(object sender, EventArgs e)
        {
            
        }

        private void CMB_LEVEL_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = FS.GET_ALL_FESS_2(Convert.ToInt32(TXT_STD_ID.Text), CMB_LEVEL.Text);
                DataTable DT = new DataTable();
               DT =FS.GET_REST_FEES(Convert.ToInt32(TXT_STD_ID.Text), CMB_LEVEL.Text);
                if (DT.Rows.Count > 0)
                {
                    CMB_REST.DataSource = DT;
                    CMB_REST.DisplayMember = "REST_OF_FEES";
                    CMB_REST.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                else
                {
                    CMB_FEES.DropDownStyle = ComboBoxStyle.DropDown;
                    CMB_REST.DropDownStyle = ComboBoxStyle.DropDown;
                    CMB_REST.Text = CMB_FEES.Text;
                    CMB_FEES.DropDownStyle = ComboBoxStyle.DropDownList;

                    //CMB_REST.DropDownStyle = ComboBoxStyle.DropDown;
                    //CMB_REST.Text = "";
                }
            }
            catch
            {
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (TXT_STD_ID.Text == "" || CMB_LEVEL.Text == "" || CMB_RERM.Text == "" || TXT_AMOUNT.Text == "")
            {
                MessageBox.Show("هناك قيم فارغة", "خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                int x;
                x = Convert.ToInt32(CMB_REST.Text);
                int a;
                a = Convert.ToInt32(TXT_AMOUNT.Text);
                if (x == 0)
                {
                    MessageBox.Show("لا توجد رسوم متبقية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {

                    if (x < a)
                    {
                        MessageBox.Show("القيمة المدخلة اكبر من الرسوم المتبقية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TXT_AMOUNT.Focus();
                        TXT_AMOUNT.SelectionStart = 0;
                        TXT_AMOUNT.SelectionLength = TXT_AMOUNT.TextLength;

                    }
                    else
                    {
                        DataTable d = new DataTable();
                        d = FS.check_id_and_term_and_level(Convert.ToInt32(TXT_STD_ID.Text), CMB_RERM.Text, CMB_LEVEL.Text);
                        if (d.Rows.Count > 0)
                        {
                            MessageBox.Show("هناك رسوم مدفوعة في هذا السنة \n قم بتغيير رسوم الترم ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        else
                        {

                            //DataTable DD = new DataTable();
                            //DD = FS.check_id_and_term_and_level(Convert.ToInt32(TXT_STD_ID.Text), CMB_RERM.Text, CMB_LEVEL.Text);

                            //if (DD.Rows.Count > 0)
                            //{
                            //    MessageBox.Show("هناك رسوم مدفوعة في هذا termقم بتغيير رسوم الترم ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //    CMB_RERM.Focus();
                            //    CMB_RERM.SelectedText = CMB_RERM.Text;

                            //}

                                FS.ADD_TO_FEES(Convert.ToInt32(TXT_STD_ID.Text), CMB_STD_NAME.Text, CMB_DEP_NM.Text, Convert.ToInt32(CMB_FEES.Text), Convert.ToInt32(TXT_AMOUNT.Text), DT_DATE.Text, CMB_RERM.Text, CMB_LEVEL.Text);
                                MessageBox.Show("تم الدفع", "عملية الدفع", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CMB_REST.DataSource = FS.GET_REST_FEES(Convert.ToInt32(TXT_STD_ID.Text), CMB_LEVEL.Text);
                                CMB_REST.DisplayMember = "REST_OF_FEES";
                            }
                        }
                    
                }
            }
         }
            
          

        private void TXT_STD_ID_Validated(object sender, EventArgs e)
        {
            try
            {

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

                if (MessageBox.Show("هل تريدالحذف", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    FS.DELETE_FEES(Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value.ToString()), dataGridView1.CurrentRow.Cells[6].Value.ToString());
                    MessageBox.Show("تم الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = FS.GET_ALL_FESS(Convert.ToInt32(TXT_STD_ID.Text));

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

                FRM_EDIT_FEES frm = new FRM_EDIT_FEES();
                frm.TXT_STD_ID2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                frm.TXT_STD_NAME2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                frm.TXT_DEP_NAME2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                frm.TXT_AMOUNT2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                frm.TXT_FEES_DEP.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                frm.DT_DATE2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                frm.TXT_TERM2.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                frm.CMB_LEVEL2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                frm.ShowDialog();
            }
            catch
            {
                return;
            }
        }

        private void TXT__TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(Convert.ToInt16(TXT_.Text)>Convert.ToInt16(CMB_SAL.Text))
                {
                    MessageBox.Show("حجم الخصم اكبر من الراتب ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_.Focus();
                }
               else if (Convert.ToInt32(CMB_COUNT_AB.Text) > 0)
                {

                    TXT_NETT.Text = Convert.ToString(Convert.ToInt32(CMB_SAL.Text) - Convert.ToInt32(TXT_.Text));
                }
                else
                {
                    TXT_NETT.Text = CMB_SAL.Text;
                }
            }
           
            catch
            {
                return;
            }

        }

        private void TXT__Validated(object sender, EventArgs e)
        {try
            {
                if (Convert.ToInt16(TXT_.Text) > Convert.ToInt16(CMB_SAL.Text))
                {
                    MessageBox.Show("حجم الخصم اكبر من الراتب ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TXT_.Focus();
                }
               else if (Convert.ToInt32(CMB_COUNT_AB.Text) > 0)
                {

                    TXT_NETT.Text = Convert.ToString(Convert.ToInt32(CMB_SAL.Text) - Convert.ToInt32(TXT_.Text));
                }
                else
                {
                    if( MessageBox.Show("لا يوجد غياب \n هل تريد الإستمرار في عملية الخصم؟ ","تنبيه",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        TXT_NETT.Text = Convert.ToString(Convert.ToInt32(CMB_SAL.Text) - Convert.ToInt32(TXT_.Text));

                    }
                    else
                    {
                        TXT_NETT.Text = CMB_SAL.Text;

                    }

                }
            }
            catch
            {
                return;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
                if (TXT_DOC_ID.Text == "" || TXT_.Text == "" || CMB_MONTH.Text == "")
                {
                    MessageBox.Show("توجد بيانات ناقصة ", " خطأ في الإدخال", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DataTable DATATABLE = new DataTable();
                    DATATABLE = FS.CHECK_MONTH_DOC_ID(Convert.ToInt32(TXT_DOC_ID.Text), CMB_MONTH.Text);

                    if (DATATABLE.Rows.Count > 0)
                    {
                        MessageBox.Show("تم تكرير الدفع ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        CMB_MONTH.Focus();
                    }
                    else
                    {
                        FS.ADD_TO_SAL(Convert.ToInt32(TXT_DOC_ID.Text), CMB_DOC_NAM.Text, Convert.ToInt32(CMB_COUNT_AB.Text), Convert.ToInt32(CMB_SAL.Text), Convert.ToInt32(TXT_.Text), Convert.ToInt32(TXT_NETT.Text), D_DATE.Text, CMB_MONTH.Text);
                        MessageBox.Show("تمت عملية الدفع", "عملية صرف الرواتب", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = FS.GET_ALL_FEES_SAL();
                        //MessageBox.Show("تمت عملية الدفع", "عملية صرف الرواتب", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

          

        }

        private void D_DATE_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void TXT_AMOUNT_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
