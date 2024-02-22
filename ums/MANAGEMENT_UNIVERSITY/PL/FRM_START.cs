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
    public partial class FRM_START : Form
    {
        public FRM_START()
        {
            InitializeComponent();
            timer1.Start();
            timer2.Start();
            timer3.Start();

            label1.Visible = true;
            label2.Visible = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value < progressBar1.Maximum)
            {
                label2.Visible = true;
                label2.Text = "WAITING .";
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Stop();
               
                label2.Visible = false;
                
                FRM_MAIN FRM = new FRM_MAIN();
                FRM.ShowDialog();
                this.Close();
                //
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
          
                label2.Visible = true;

                label2.Text = "WAITING ..";
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {

                label2.Visible = true;

                label2.Text = "WAITING ...";
            }
        }
    }
}
