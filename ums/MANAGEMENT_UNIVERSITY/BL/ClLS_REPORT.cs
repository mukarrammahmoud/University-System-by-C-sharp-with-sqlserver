using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.BL
{
    class ClLS_REPORT
    {
        public DataTable get_single_std(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@std_id", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("get_single_std", param);
            DAL.close();
            return DT;
        }
    }
}
