using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MANAGEMENT_UNIVERSITY.BL
{
    class CLS_GRADES
    {
        public DataTable SELECT_CRSID_FRPM_DEP(int d)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = d;

            DT = DAL.selectdata("SELECT_CRSID_FRPM_DEP", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_STD_ID(String STD_ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@STD_ID", SqlDbType.VarChar,20);
            param[0].Value = STD_ID;

            DT = DAL.selectdata("GET_STD_ID", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_STD_NAME(int d)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = d;

            DT = DAL.selectdata("GET_STD_NAME", param);
            DAL.close();
            return DT;
        }
        public void ADD_RUSELTS_COURSE(int ST_ID, string ST_NAME, int CRS_ID, String CRS_NM, string GRD, String AVG ,String DEP_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            param[0].Value = ST_ID;

            param[1] = new SqlParameter("@STD_NM", SqlDbType.VarChar, 20);
            param[1].Value = ST_NAME;

            param[2] = new SqlParameter("@CRS_ID ", SqlDbType.Int);
            param[2].Value = CRS_ID;

            param[3] = new SqlParameter("@CRS_NAME", SqlDbType.VarChar,20);
            param[3].Value = CRS_NM;

            param[4] = new SqlParameter("@GRADE", SqlDbType.VarChar, 20);
            param[4].Value = GRD;

            param[5] = new SqlParameter("@AVR", SqlDbType.VarChar, 20);
            param[5].Value = AVG;

            param[6] = new SqlParameter("@DEP_NMAE", SqlDbType.VarChar, 20);
            param[6].Value = DEP_NAME;

            DAL.ExecuteCommand("ADD_RUSELTS_COURSE", param);
            DAL.close();
        }
        public DataTable GET_ALL_RESULTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_RESULTS", null);
            DAL.close();
            return DT;
        }
        public DataTable DELETE_RESULT(int CRS,int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@crs_id", SqlDbType.Int);
            param[0].Value = CRS;

            param[1] = new SqlParameter("@ID", SqlDbType.Int);
            param[1].Value = ID;

            DT = DAL.selectdata("DELETE_RESULT", param);
            DAL.close();
            return DT;
        }
        public void EDIT_RESULT(int d ,int C_ID,String G ,String A)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            param[0].Value = d;

            param[1] = new SqlParameter("@CRS_ID", SqlDbType.Int);
            param[1].Value = C_ID;

            param[2] = new SqlParameter("@GRD", SqlDbType.VarChar,20);
            param[2].Value = G;

            param[3] = new SqlParameter("@AVE", SqlDbType.VarChar,20);
            param[3].Value = A;

            DAL.ExecuteCommand("EDIT_RESULT", param);
            DAL.close();
            
        }
        public DataTable CHECK_CRS_ID_STD_ID(int CRS,int id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@crs_id", SqlDbType.Int);
            param[0].Value = CRS;

            param[1] = new SqlParameter("@id", SqlDbType.Int);
            param[1].Value = id;

            DT = DAL.selectdata("CHECK_CRS_ID_STD_ID", param);
            DAL.close();
            return DT;
        }
    }
}
