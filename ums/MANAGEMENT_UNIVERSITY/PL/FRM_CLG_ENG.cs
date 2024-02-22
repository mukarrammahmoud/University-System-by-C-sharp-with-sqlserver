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
    public partial class FRM_CLG_ENG : Form
    {
        BL.ClS_CLG CLG = new BL.ClS_CLG();

        public FRM_CLG_ENG()
        {

            InitializeComponent();
            try
            {
                CMB_ACNT_STD_CLG.DataSource = CLG.GET_ALL_DEP_TO_CLG(LBL_CLG_NM.Text);
                CMB_ACNT_STD_CLG.DisplayMember = "ACOUNT_STD";
                LST_B_DEP.DataSource = CLG.GET_ALL_DEP_TO_CLG1(LBL_CLG_NM.Text);
                LST_B_DEP.DisplayMember = "DEP_NAME";
                CMB_DOC_NAME.DataSource = CLG.GET_DOC_CLG(LBL_CLG_NM.Text);
                CMB_DOC_NAME.DisplayMember = "DOC_CLG";
            }
            catch
            {
                return;
            }
        }

        private void LST_B_DEP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CMB_ACT_STD_DEP.DataSource = CLG.GET_ACOUNT_STD_FROM_DEP(LST_B_DEP.Text);
                CMB_ACT_STD_DEP.DisplayMember = "ACOUNT_STD";
                CMB_FEES_DEP.DataSource = CLG.GET_FESS_FROM_DEP(LST_B_DEP.Text);
                CMB_FEES_DEP.DisplayMember = "FEES";
                CMB_FEES_CLG.DataSource = CLG.SUM_FESS_FROM_STUDENTS(LST_B_DEP.Text);
                CMB_FEES_CLG.DisplayMember = "FEES_ALL_DEP";
                LST_B_CRS.DataSource = CLG.GET_COURSE_DEP(LST_B_DEP.Text);
                LST_B_CRS.DisplayMember = "COURSE_NAM";
            }
            catch
            {
                return;
            }
        
    }
    }
}
