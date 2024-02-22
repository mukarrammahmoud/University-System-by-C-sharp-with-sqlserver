using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.RPT
{
    class ClS_STUDENTS
    {
        public DataTable GET_ALL_STUDENT_RPT()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_STUDENT_RPT", null);
            DAL.close();
            return DT;
        }
    }
}
