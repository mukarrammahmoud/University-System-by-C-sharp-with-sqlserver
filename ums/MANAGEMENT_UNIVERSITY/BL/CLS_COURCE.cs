using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.BL
{
    class CLS_COURSE
    {
        public void ADD_COURCE(int COURS_ID, string COURS_NAME, int HOURS,string type_coruse)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@COURCE_ID", SqlDbType.Int);
            param[0].Value = COURS_ID;

            param[1] = new SqlParameter("@COURCE_NAME", SqlDbType.VarChar, 15);
            param[1].Value = COURS_NAME;

            param[2] = new SqlParameter("@HOURS ", SqlDbType.Int);
            param[2].Value = HOURS;

            param[3] = new SqlParameter("@T_COURSE ", SqlDbType.VarChar,15);
            param[3].Value = type_coruse;
            DAL.ExecuteCommand("ADD_COURCE", param);
            DAL.close();
        }
        public DataTable verifycourceid(int cource_d)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@course_id", SqlDbType.Int);
            param[0].Value = cource_d;

            DT = DAL.selectdata("verifycourceid", param);
            DAL.close();
            return DT;
        }
        public DataTable verifycourcename(string c_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@course_NAME", SqlDbType.VarChar,15);
            param[0].Value = c_name;

            DT = DAL.selectdata("verifycourcename", param);
            DAL.close();
            return DT;
        }
        public void UPDATE_COURSE(int COURS_ID, string COURS_NAME, int HOURS, string type_coruse)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@crs_id", SqlDbType.Int);
            param[0].Value = COURS_ID;

            param[1] = new SqlParameter("@CRS_N", SqlDbType.VarChar, 15);
            param[1].Value = COURS_NAME;

            param[2] = new SqlParameter("@HOUR ", SqlDbType.Int);
            param[2].Value = HOURS;

            param[3] = new SqlParameter("@TYPE ", SqlDbType.VarChar, 15);
            param[3].Value = type_coruse;
            DAL.ExecuteCommand("UPDATE_COURSE", param);
            DAL.close();
        }

        public DataTable GET_ALL_CRS_DEPS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_CRS_DEPS", null);
            DAL.close();
            return DT;
        }
        public void DELETE_CRS_FROM_DEPS(int CRS, int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

           
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@crs_id", SqlDbType.Int);
            param[0].Value = CRS;

            param[1] = new SqlParameter("@ID", SqlDbType.Int);
            param[1].Value = ID;

             DAL.ExecuteCommand("DELETE_CRS_FROM_DEPS", param);
            DAL.close();
          
        }
        public DataTable GET_ALL_CRS_DEP()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_CRS_DEP", null);
            DAL.close();
            return DT;
        }
    }

}
