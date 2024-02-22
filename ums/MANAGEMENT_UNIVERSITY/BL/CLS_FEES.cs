using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.BL
{
    class CLS_FEES
    {
        public DataTable GET_ID_STD_TO_FEES(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("GET_ID_STD_TO_FEES", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_DEP_NAME_FROM_STD(String STD_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@STD_NAME", SqlDbType.VarChar,30);
            param[0].Value = STD_NM;

            DT = DAL.selectdata("GET_DEP_NAME_FROM_STD", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_FEES(String DEP_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DEP_NM", SqlDbType.VarChar, 20);
            param[0].Value = DEP_NM;

            DT = DAL.selectdata("GET_FEES", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_REST_FEES(int ID,String LVL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@LVL", SqlDbType.VarChar,15);
            param[1].Value = LVL;

            DT = DAL.selectdata("GET_REST_FEES", param);
            DAL.close();
            return DT;
        }
        public void ADD_TO_FEES(int ST_ID,String ST_NM,String DP_NM,int FES_OF_DP ,int AMOUNT,String DATE,String TRM,String LVL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
           
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            param[0].Value = ST_ID;

            param[1] = new SqlParameter("@STD_NAME", SqlDbType.VarChar,20);
            param[1].Value = ST_NM;

            param[2] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 20);
            param[2].Value = DP_NM;

            param[3] = new SqlParameter("@FEES_OF_DEP", SqlDbType.Int);
            param[3].Value = FES_OF_DP;

            param[4] = new SqlParameter("@AMOUNT_PAID", SqlDbType.Int);
            param[4].Value = AMOUNT;

            param[5] = new SqlParameter("@DATE_PAID", SqlDbType.VarChar, 20);
            param[5].Value = DATE;

            param[6] = new SqlParameter("@TERM", SqlDbType.VarChar, 15);
            param[6].Value = TRM;

            param[7] = new SqlParameter("@LEVEL", SqlDbType.VarChar, 15);
            param[7].Value = LVL;

             DAL.ExecuteCommand("ADD_TO_FEES", param);
            DAL.close();
            
        }
        public DataTable GET_ALL_FESS(int st_id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            param[0].Value = st_id;
            DT = DAL.selectdata("GET_ALL_FESS", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_FESS_2(int ID, String LVL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@lvl", SqlDbType.VarChar, 15);
            param[1].Value = LVL;

            DT = DAL.selectdata("GET_ALL_FESS_2", param);
            DAL.close();
            return DT;
        }
        public DataTable CHECK_TERM_AND_STID(int ID, String TRM )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            param[0].Value = ID;
            

            param[1] = new SqlParameter("@TRM", SqlDbType.VarChar, 15);
            param[1].Value = TRM;

           

            DT = DAL.selectdata("CHECK_TERM_AND_STID", param);
            DAL.close();
            return DT;
        }
        public void DELETE_FEES(int ID, String TRM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

           
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@TRM", SqlDbType.VarChar, 15);
            param[1].Value = TRM;

            DAL.ExecuteCommand("DELETE_FEES", param);
            DAL.close();
            
        }
        public void UPDATE_FEES(int ST_ID, String ST_NM, String DP_NM, int FES_OF_DP, int AMOUNT, String DATE, String TRM, String LVL)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@STD_ID", SqlDbType.Int);
            param[0].Value = ST_ID;

            param[1] = new SqlParameter("@STD_NAME", SqlDbType.VarChar, 20);
            param[1].Value = ST_NM;

            param[2] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 20);
            param[2].Value = DP_NM;

            param[3] = new SqlParameter("@FEES_OF_DEP", SqlDbType.Int);
            param[3].Value = FES_OF_DP;

            param[4] = new SqlParameter("@AMOUNT_PAID", SqlDbType.Int);
            param[4].Value = AMOUNT;

            param[5] = new SqlParameter("@DATE_PAID", SqlDbType.VarChar, 20);
            param[5].Value = DATE;

            param[6] = new SqlParameter("@TERM", SqlDbType.VarChar, 15);
            param[6].Value = TRM;

            param[7] = new SqlParameter("@LEVEL", SqlDbType.VarChar, 15);
            param[7].Value = LVL;

             DAL.ExecuteCommand("UPDATE_FEES", param);
            DAL.close();
            
        }
        public DataTable GET_DOC_NAME(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("GET_DOC_NAME", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_SAL_DOC(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("GET_SAL_DOC", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ABSENT_DOC(String DC_NM)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[0].Value = DC_NM;

            DT = DAL.selectdata("GET_ABSENT_DOC", param);
            DAL.close();
            return DT;
        }
        public void ADD_TO_SAL(int DOC_ID,String DOC_NAME,int ACOT_AB ,int SAL ,int DICOUNT,
            int NETT,String D_DATE ,String MONTH)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@DOC_ID", SqlDbType.Int);
            param[0].Value = DOC_ID;

            param[1] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[1].Value = DOC_NAME;

            param[2] = new SqlParameter("@ACOT_AB", SqlDbType.Int);
            param[2].Value = ACOT_AB;

            param[3] = new SqlParameter("@SA", SqlDbType.Int);
            param[3].Value = SAL;

            param[4] = new SqlParameter("@DICONT", SqlDbType.Int);
            param[4].Value = DICOUNT;

            param[5] = new SqlParameter("@NETT", SqlDbType.Int);
            param[5].Value = NETT;

            param[6] = new SqlParameter("@DELV_DATE", SqlDbType.Date);
            param[6].Value = D_DATE;

            param[7] = new SqlParameter("@MONTH", SqlDbType.VarChar, 15);
            param[7].Value = MONTH;

             DAL.ExecuteCommand("ADD_TO_SAL", param);
            DAL.close();
           
        }
        public DataTable CHECK_MONTH_DOC_ID(int DOC_ID, String MNTH )
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@DOC_ID", SqlDbType.Int);
            param[0].Value = DOC_ID;

            param[1] = new SqlParameter("@MONTH", SqlDbType.VarChar, 15);
            param[1].Value = MNTH;
            

            DT = DAL.selectdata("CHECK_MONTH_DOC_ID", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_FEES_SAL()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_FEES_SAL", null);
            DAL.close();
            return DT;
        }
        public DataTable check_id_and_term_and_level(int ID, String TRM, String lvl)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@trm", SqlDbType.VarChar, 15);
            param[1].Value = TRM;

            param[2] = new SqlParameter("@lvl", SqlDbType.VarChar, 15);
            param[2].Value = lvl;

            DT = DAL.selectdata("check_id_and_term_and_level", param);
            DAL.close();
            return DT;
        }
    }
}
