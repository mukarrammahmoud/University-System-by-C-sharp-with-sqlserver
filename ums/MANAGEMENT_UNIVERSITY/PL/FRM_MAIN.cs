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
    public partial class FRM_MAIN : Form
    {
        BL.ClS_BACKUP BAC = new BL.ClS_BACKUP();
        private static FRM_MAIN frm;
        public FRM_START _form2;
        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }
        public static FRM_MAIN getmainform
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        public FRM_MAIN()
        {//Image.FromFile("C:\\Users\\Computer\\Pictures\\icons\\down.jpeg");
            InitializeComponent();
            if (frm == null)
                frm = this;
            timer1.Start();
          
            this.label1.Text = ""+DateTime.Now;
         

            this.notifyIcon1.Icon = this.Icon;
            this.notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "تم تشغيل نظام إدارة الجامعة";
            this.notifyIcon1.BalloonTipTitle = "INFO";
            this.notifyIcon1.ShowBalloonTip(15);
          
          
           الشؤونالماليةToolStripMenuItem.Enabled = false;
           الToolStripMenuItem.Enabled = false;
           التسجيلToolStripMenuItem.Enabled = false;
            جلبنسخةإحتياطيةToolStripMenuItem.Enabled = false;
            حفظنسخةإحتياطيةToolStripMenuItem.Enabled = false;

            تسجيلالخروجToolStripMenuItem.Enabled = true;
            تسجيلالخروجToolStripMenuItem1.Enabled = true;

            الكلياتToolStripMenuItem.Enabled = false;
        المستخدمونToolStripMenuItem.Enabled = false;
         toolStripMenuItem1.Enabled = false;
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void التسجيلToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void الشؤونالأكاديميةللطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void الشؤونالأكاديميةللموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void الشؤونالماليةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_FEES frm = new FRM_FEES();
            frm.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem1_Click(object sender, EventArgs e)
        {


            if (_form2 != null)
            {
                _form2.Close();
                _form2 = null;
            }


        }

        private void jتسجيلطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_STUDENT frm = new FRM_ADD_STUDENT();
            frm.ShowDialog();

        }

        private void تسجيلمحاضرToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FRM_DOCTORS frm = new FRM_DOCTORS();
            frm.ShowDialog();
        }

        private void الحضوروالغيابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PRT_AST frm = new FRM_PRT_AST();
            frm.ShowDialog();
        }

        private void الموادالمقررةToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            FRM_DOC_CRS frm = new FRM_DOC_CRS();
            frm.ShowDialog();
        }

        private void إدارةالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_M_STUDENTScs frm = new FRM_M_STUDENTScs();
            frm.ShowDialog();
        }

        private void الدرجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CRS_STD frm = new FRM_CRS_STD();
            frm.ShowDialog();
        }

        private void الكلياتToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void إضافةمادةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_COURSE frm = new FRM_COURSE();
            frm.ShowDialog();
        }

        private void إضافةمادةإلىقسمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_DEPS frm = new FRM_DEPS();
            frm.ShowDialog();
        }

        private void تسجيلالخروجToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
           FRM_START.ActiveForm.Close();
        }

        private void كليةالطبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CLG1 frm = new FRM_CLG1();
            frm.ShowDialog();
        }

        private void كليةالحاسوبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CLG_COM frm = new FRM_CLG_COM();
            frm.ShowDialog();
        }

        private void كليةالتجارةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CLG_COMR frm = new FRM_CLG_COMR();
            frm.ShowDialog();
        }

        private void كليةالآدابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CLG_LANG frm = new FRM_CLG_LANG();
            frm.ShowDialog();
        }

        private void كليةالهندسةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CLG_ENG frm = new FRM_CLG_ENG();
            frm.ShowDialog();
        }

        private void الحضوروالغيابToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_PRESENT_STD frm = new FRM_PRESENT_STD();
            frm.ShowDialog();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'university_DBDataSet1.ACOUNT_STD' table. You can move, or remove it, as needed.
           // this.aCOUNT_STDTableAdapter.Fill(this.university_DBDataSet1.ACOUNT_STD);
            // TODO: This line of code loads data into the 'university_DBDataSet.GET_ALL_CRS_DEPS' table. You can move, or remove it, as needed.
            //this.gET_ALL_CRS_DEPSTableAdapter.Fill(this.university_DBDataSet.GET_ALL_CRS_DEPS);

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void تسجيلالخروجToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USER frm = new FRM_USER();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {// 
            label1.Text = "          الوقت : " + DateTime.Now.ToLongTimeString()+"    ||    التاريخ :"+DateTime.Now.ToShortDateString();
         


        }

        private void حفظنسخةإحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BL.FRM_BACKUP FRM = new BL.FRM_BACKUP();
            FRM.ShowDialog();
        }

        private void جلبنسخةإحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_RESTART_BACKUP frm = new FRM_RESTART_BACKUP();
            frm.ShowDialog();
        }

        private void إعداداتالإتصالبالسيرفرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_CONFIG frm = new FRM_CONFIG();
            frm.ShowDialog();
        }
    }
}
 