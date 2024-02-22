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
    public partial class FRM_EDIT_RESULTE : Form
    {
        BL.CLS_GRADES GR = new BL.CLS_GRADES();
        BL.CLS_COURSE_DEP CRS = new BL.CLS_COURSE_DEP();
        public FRM_EDIT_RESULTE()
        {
            InitializeComponent();
            try
            {
                CMB_CRS_ID2.DataSource = GR.SELECT_CRSID_FRPM_DEP(Convert.ToInt32(FRM_CRS_STD.getmainform.CMB_DEP_ID.Text));
                CMB_CRS_ID2.DisplayMember = "COURSE_ID";

            }
            catch
            {
                return;
            }
        }

        private void TXT_GRD_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(TXT_GRD.Text) <= 100 && Convert.ToInt32(TXT_GRD.Text) >= 0)
                {

                    if (Convert.ToInt32(TXT_GRD.Text) >= 90)
                    {
                        TXT_AV.Text = "ممتاز";
                        TXT_AV.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(TXT_GRD.Text) >= 80)
                    {
                        TXT_AV.Text = "جيد جدا";
                        TXT_AV.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(TXT_GRD.Text) >= 75)
                    {
                        TXT_AV.Text = "جيد";
                        TXT_AV.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(TXT_GRD.Text) >= 60)
                    {
                        TXT_AV.Text = "مقبول";
                        TXT_AV.ReadOnly = true;
                    }

                    else if (Convert.ToInt32(TXT_GRD.Text) >= 50)
                    {
                        TXT_AV.Text = "ضعيف";
                        TXT_AV.ReadOnly = true;
                    }
                    else if (Convert.ToInt32(TXT_GRD.Text) < 50)
                    {
                        TXT_AV.Text = "راسب";
                        TXT_AV.ReadOnly = true;
                    }
                }
                else
                {
                    MessageBox.Show("درجة غير مقبولة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TXT_GRD.Focus();

                }

            }
            catch { return; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                GR.EDIT_RESULT(Convert.ToInt32( CMB_STD_ID2.Text),Convert.ToInt32( CMB_CRS_ID2.Text), TXT_GRD.Text, TXT_AV.Text);
                    MessageBox.Show("تم تعديل البيانات", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_CRS_STD FRM = new FRM_CRS_STD();
               FRM_CRS_STD.getmainform. DGV_RESULTS.DataSource = GR.GET_ALL_RESULTS();
            }
            catch
            {
                return;
            }
        }

        private void CMB_CRS_ID2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CMB_CRS_NAME2.DataSource = CRS.GET_NAME_COURCE(Convert.ToInt32(CMB_CRS_ID2.Text));
                CMB_CRS_NAME2.DisplayMember = "COURSE_NAME";
            }
            catch
            {
                return;
            }
        }
    }
}
