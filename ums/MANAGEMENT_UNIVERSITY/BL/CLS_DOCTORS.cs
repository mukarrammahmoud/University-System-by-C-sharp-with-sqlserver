using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.BL
{
    class CLS_DOCTORS
    {
        public void ADD_DOCTORS(int D_ID, string D_NAME, int DE_ID, string DE_NAME, string BIR_D,
        string GNDR, string SAL, string SP, string M_C,string ADD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@D_ID", SqlDbType.Int);
            param[0].Value = D_ID;

            param[1] = new SqlParameter("@D_NAME", SqlDbType.VarChar, 15);
            param[1].Value = D_NAME;

            param[2] = new SqlParameter("@DEP_ID", SqlDbType.Int);
            param[2].Value = DE_ID;

            param[3] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 15);
            param[3].Value = DE_NAME;

            param[4] = new SqlParameter("@BRD", SqlDbType.Date);
            param[4].Value = BIR_D;

            param[5] = new SqlParameter("@GNDR", SqlDbType.VarChar,15);
            param[5].Value = GNDR;

            param[6] = new SqlParameter("@SAL", SqlDbType.Int);
            param[6].Value = SAL;

            param[7] = new SqlParameter("@SPI", SqlDbType.VarChar, 15);
            param[7].Value = SP;

            param[8] = new SqlParameter("@M_C", SqlDbType.VarChar,15);
            param[8].Value = M_C;
            
            param[9] = new SqlParameter("@ADD", SqlDbType.VarChar,15);
            param[9].Value = ADD;


            DAL.ExecuteCommand("ADD_DOCTORS", param);
            DAL.close();
        }
        public DataTable CHECK_DOC_ID(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DOC_ID", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("CHECK_DOC_ID", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_DOCTORS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_DOCTORS", null);
            DAL.close();
            return DT;
        }
        public DataTable DELETE_DOCTOR(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("DELETE_DOCTOR", param);
            DAL.close();
            return DT;
        }
        public void UPDATE_DOCTORS(int D_ID, string D_NAME, int DE_ID, string DE_NAME, string BIR_D,
    string GNDR, string SAL, string SP, string M_C, string ADD)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@D_ID", SqlDbType.Int);
            param[0].Value = D_ID;

            param[1] = new SqlParameter("@D_NAME", SqlDbType.VarChar, 15);
            param[1].Value = D_NAME;

            param[2] = new SqlParameter("@DEP_ID", SqlDbType.Int);
            param[2].Value = DE_ID;

            param[3] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 15);
            param[3].Value = DE_NAME;

            param[4] = new SqlParameter("@BRD", SqlDbType.Date);
            param[4].Value = BIR_D;

            param[5] = new SqlParameter("@GNDR", SqlDbType.VarChar, 15);
            param[5].Value = GNDR;

            param[6] = new SqlParameter("@SAL", SqlDbType.Int);
            param[6].Value = SAL;

            param[7] = new SqlParameter("@SPI", SqlDbType.VarChar, 15);
            param[7].Value = SP;

            param[8] = new SqlParameter("@M_C", SqlDbType.VarChar, 15);
            param[8].Value = M_C;

            param[9] = new SqlParameter("@ADD", SqlDbType.VarChar, 15);
            param[9].Value = ADD;


            DAL.ExecuteCommand("UPDATE_DOCTORS", param);
            DAL.close();
        }
        public DataTable GET_DOC_ID_COND(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("GET_DOC_ID_COND", param);
            DAL.close();
            return DT;
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
        public void ADD_CRS_TO_DOC(int D_ID, string D_NAME, int DE_ID, string DE_NAME, int CR_ID,
                                    string CR_NM, string DAY, string TIMES)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@D_ID", SqlDbType.Int);
            param[0].Value = D_ID;

            param[1] = new SqlParameter("@D_NAME", SqlDbType.VarChar, 15);
            param[1].Value = D_NAME;

            param[2] = new SqlParameter("@DEP_ID", SqlDbType.Int);
            param[2].Value = DE_ID;

            param[3] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 15);
            param[3].Value = DE_NAME;

            param[4] = new SqlParameter("@CRS_ID", SqlDbType.Int);
            param[4].Value = CR_ID;
            
            param[5] = new SqlParameter("@CRS_NM", SqlDbType.VarChar, 15);
            param[5].Value = CR_NM;

            param[6] = new SqlParameter("@DAYS", SqlDbType.VarChar,15);
            param[6].Value = DAY;

            param[7] = new SqlParameter("@TIME", SqlDbType.VarChar,15);
            param[7].Value = TIMES;

         


            DAL.ExecuteCommand("ADD_CRS_TO_DOC", param);
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
        public void DELET_FROM_CRS_DOC( string D_NAME,  string DE_NAME, 
                                 string CR_NM, string DAY, string TIMES)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
          
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[0].Value = D_NAME;

          
            param[1] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 15);
            param[1].Value = DE_NAME;
            

            param[2] = new SqlParameter("@CRS_NAME", SqlDbType.VarChar, 15);
            param[2].Value = CR_NM;

            param[3] = new SqlParameter("@DY", SqlDbType.VarChar, 15);
            param[3].Value = DAY;

            param[4] = new SqlParameter("@TM", SqlDbType.VarChar, 15);
            param[4].Value = TIMES;


            DAL.ExecuteCommand("DELET_FROM_CRS_DOC", param);
            DAL.close();
        }
        public void UPDATE_CRS_DOC(int D_ID, string D_NAME, int DE_ID, string DE_NAME, int CR_ID,
                               string CR_NM, string DAY, string TIMES)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[8];
            param[0] = new SqlParameter("@DO_ID", SqlDbType.Int);
            param[0].Value = D_ID;

            param[1] = new SqlParameter("@DO_NAME", SqlDbType.VarChar, 15);
            param[1].Value = D_NAME;

            param[2] = new SqlParameter("@DE_ID", SqlDbType.Int);
            param[2].Value = DE_ID;

            param[3] = new SqlParameter("@DE_NAME", SqlDbType.VarChar, 15);
            param[3].Value = DE_NAME;

            param[4] = new SqlParameter("@CR_ID", SqlDbType.Int);
            param[4].Value = CR_ID;

            param[5] = new SqlParameter("@CR_NAME", SqlDbType.VarChar, 15);
            param[5].Value = CR_NM;

            param[6] = new SqlParameter("@DAYS", SqlDbType.VarChar, 15);
            param[6].Value = DAY;

            param[7] = new SqlParameter("@TIMES", SqlDbType.VarChar, 15);
            param[7].Value = TIMES;




            DAL.ExecuteCommand("UPDATE_CRS_DOC", param);
            DAL.close();
        }
        public DataTable SEARCH_ALL_DOC(String DOC_NAME)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
           
            param[0] = new SqlParameter("@DOC_NAME", SqlDbType.VarChar, 15);
            param[0].Value = DOC_NAME;

            DT = DAL.selectdata("SEARCH_ALL_DOC", param);
            DAL.close();
            return DT;
        }
    }
}
