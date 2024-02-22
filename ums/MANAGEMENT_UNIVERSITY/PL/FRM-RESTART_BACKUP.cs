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
namespace MANAGEMENT_UNIVERSITY.PL
{
    public partial class FRM_RESTART_BACKUP : Form
    {
        SqlConnection CON = new SqlConnection(@"Server=.;Database=MASTER;Integrated Security=true");
        SqlCommand CMD;
        public FRM_RESTART_BACKUP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    txt_bath.Text = openFileDialog1.FileName;
                }
            }
            catch
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            String STRQUERY = "ALTER DATABASE University_DB SET OFFLINE WITH ROLLBACK IMMEDIATE; RESTORE DATABASE University_DB FROM DISK='" + txt_bath.Text+ "'WITH REPLACE";
            CMD = new SqlCommand(STRQUERY, CON);
            CON.Open();
            CMD.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("تم إستعادة النسخة الإحتياطية بنجاح", "عملية الإستعادة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
