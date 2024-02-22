using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.BL
{
    class ClS_CLG
    {
        public DataTable GET_ALL_DEP_TO_CLG(String CLG_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CLG_NAME", SqlDbType.VarChar, 20);
            param[0].Value = CLG_NM;

            DT = DAL.selectdata("GET_ALL_DEP_TO_CLG", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_DEP_TO_CLG1(String CLG_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CLG_NAME", SqlDbType.VarChar, 20);
            param[0].Value = CLG_NM;

            DT = DAL.selectdata("GET_ALL_DEP_TO_CLG1", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ACOUNT_STD_FROM_DEP(String DEP_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 20);
            param[0].Value = DEP_NM;

            DT = DAL.selectdata("GET_ACOUNT_STD_FROM_DEP", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_FESS_FROM_DEP(String DEP_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 20);
            param[0].Value = DEP_NM;

            DT = DAL.selectdata("GET_FESS_FROM_DEP", param);
            DAL.close();
            return DT;
        }

        public DataTable SUM_FESS_FROM_STUDENTS(String DEP_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 20);
            param[0].Value = DEP_NM;

            DT = DAL.selectdata("SUM_FESS_FROM_STUDENTS", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_COURSE_DEP(String DEP_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 20);
            param[0].Value = DEP_NM;

            DT = DAL.selectdata("GET_COURSE_DEP", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_DOC_CLG(String CLG_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 20);
            param[0].Value = CLG_NM;

            DT = DAL.selectdata("GET_DOC_CLG", param);
            DAL.close();
            return DT;
        }

    }
}
