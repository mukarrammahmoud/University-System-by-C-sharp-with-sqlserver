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

namespace MANAGEMENT_UNIVERSITY.BL
{
    public partial class FRM_BACKUP : Form
    {
        SqlConnection CON = new SqlConnection(@"Server=.;Database=University_DB;Integrated Security=true");
        SqlCommand CMD;

        public FRM_BACKUP()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog()==DialogResult.OK)
            {
                TXT_BACKUP.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

                String FILE_BACK = TXT_BACKUP.Text + "\\University_DB " + DateTime.Now.ToShortDateString().Replace('/','-') + "-" + DateTime.Now.ToShortTimeString().Replace(':','-');
                String STRQUERY = "BACKUP DATABASE University_DB TO DISK='" + FILE_BACK + ".back'";
                CMD = new SqlCommand(STRQUERY, CON);
                CON.Open();
                CMD.ExecuteNonQuery();
                CON.Close();
                MessageBox.Show("تم إنشاء نسخة إحتياطية بنجاح", "عملية الإنشاء", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }
    }
}
