using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace MANAGEMENT_UNIVERSITY.BL
{
    class CLS_PRESENT
    {
        public DataTable GET_ALL_DEP_NAME()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_DEP_NAME", null);
            DAL.close();
            return DT;
        }
        public DataTable GET_DOC_NAME_TO_PRSENT(string DEP_name,string day)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 20);
            param[0].Value = DEP_name;

            param[1] = new SqlParameter("@DAY", SqlDbType.VarChar, 15);
            param[1].Value = day;

            DT = DAL.selectdata("GET_DOC_NAME_TO_PRSENT", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_DAY_LAT(string DOC_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[0].Value = DOC_name;

            DT = DAL.selectdata("GET_DAY_LAT", param);
            DAL.close();
            return DT;
        }
        public void ADD_TO_PR_AB(string DC_NAME, string DY, string PA, string DTE,string DE_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

           
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[0].Value = DC_NAME;

            param[1] = new SqlParameter("@DAY_LAT", SqlDbType.VarChar, 15);
            param[1].Value = DY;

            param[2] = new SqlParameter("@PR_AB", SqlDbType.VarChar, 15);
            param[2].Value = PA;

            param[3] = new SqlParameter("@DATTE", SqlDbType.VarChar, 15);
            param[3].Value = DTE;

            param[4] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 15);
            param[4].Value = DE_NAME;

            DAL.ExecuteCommand("ADD_TO_PR_AB", param);
            DAL.close();
          
        }
        public DataTable CHECK_DATE(string DC_NAME, string date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[0].Value = DC_NAME;

            param[1] = new SqlParameter("@DATE", SqlDbType.VarChar, 15);
            param[1].Value = date;

            DT = DAL.selectdata("CHECK_DATE", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_DAY_OF_DOCTORS(string DOC_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[0].Value = DOC_name;

            DT = DAL.selectdata("GET_DAY_OF_DOCTORS", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_FROM_PR_AB()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_FROM_PR_AB", null);
            DAL.close();
            return DT;
        }
        public void DELETE_FROM_PR_AB(string DC_NAME, string date)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[0].Value = DC_NAME;

            param[1] = new SqlParameter("@DATE", SqlDbType.VarChar, 15);
            param[1].Value = date;

            DAL.ExecuteCommand("DELETE_FROM_PR_AB", param);
            DAL.close();
            
        }
        public void UPDATE_PR(string DC_NAME, string DY, string PA, string DTE, string DE_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

           ;
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[0].Value = DC_NAME;

            param[1] = new SqlParameter("@DATE", SqlDbType.VarChar, 15);
            param[1].Value = DY;

            param[2] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 15);
            param[2].Value = PA;

            param[3] = new SqlParameter("@DAY", SqlDbType.VarChar, 15);
            param[3].Value = DTE;

            param[4] = new SqlParameter("@PR_AB", SqlDbType.VarChar, 15);
            param[4].Value = DE_NAME;

            DAL.ExecuteCommand("UPDATE_PR", param);
            DAL.close();
          
        }
        public DataTable GET_COURSE_ID_FROM_DEP(string DEP_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 20);
            param[0].Value = DEP_name;

            DT = DAL.selectdata("GET_COURSE_ID_FROM_DEP", param);
            DAL.close();
            return DT;
        }
        public DataTable PRESENT_ABSENT_STD(string CRS_NAME, string DEP_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@COURSE_NAME", SqlDbType.VarChar, 20);
            param[0].Value = CRS_NAME;

            param[1] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 20);
            param[1].Value = DEP_NM;

            DT = DAL.selectdata("PRESENT_ABSENT_STD", param);
            DAL.close();
            return DT;
        }
    }
    
}
