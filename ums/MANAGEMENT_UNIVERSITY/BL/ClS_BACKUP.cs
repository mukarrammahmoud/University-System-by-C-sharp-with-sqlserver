using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MANAGEMENT_UNIVERSITY.BL
{
    class ClS_BACKUP
    {
        public DataTable SAVE_BACKUP()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("SAVE_BACKUP", null);
            DAL.close();
            return DT;
        }
    }
}
