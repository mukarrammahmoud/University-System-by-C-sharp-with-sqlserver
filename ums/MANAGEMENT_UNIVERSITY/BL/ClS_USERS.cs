using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace MANAGEMENT_UNIVERSITY.BL
{
    class ClS_USERS
    {
        public DataTable GET_TYPE_USER()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_TYPE_USER", null);
            DAL.close();
            return DT;
        }
        public DataTable CHECK_PAS_USER(string US_NM, string PSW ,String US_TYPE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[3];
            param[0] = new SqlParameter("@USER_NM", SqlDbType.VarChar, 15);
            param[0].Value = US_NM;

            param[1] = new SqlParameter("@USER_PSW", SqlDbType.VarChar, 15);
            param[1].Value = PSW;

            param[2] = new SqlParameter("@USER_TYPE", SqlDbType.VarChar, 15);
            param[2].Value = US_TYPE;

            DT = DAL.selectdata("CHECK_PAS_USER", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_USERS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_USERS", null);
            DAL.close();
            return DT;
        }
         public DataTable SEARCH_USER(string DEP_name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@USER_NM", SqlDbType.VarChar, 20);
            param[0].Value = DEP_name;

            DT = DAL.selectdata("SEARCH_USER", param);
            DAL.close();
            return DT;
        }
        public DataTable check_user_id(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("check_user_id", param);
            DAL.close();
            return DT;
        }
        public void add_user(int id, string US_NM, string PSW, String US_TYPE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

           
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@user_nm", SqlDbType.VarChar, 15);
            param[1].Value = US_NM;

            param[2] = new SqlParameter("@user_psw", SqlDbType.VarChar, 15);
            param[2].Value = PSW;

            param[3] = new SqlParameter("@user_type", SqlDbType.VarChar, 15);
            param[3].Value = US_TYPE;

             DAL.ExecuteCommand("add_user", param);
            DAL.close();
           
        }
        public void delete_user(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("delete_user", param);
            DAL.close();
           
        }
        public void update_users(int id, string US_NM, string PSW, String US_TYPE)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@user_id", SqlDbType.Int);
            param[0].Value = id;

            param[1] = new SqlParameter("@user_nm", SqlDbType.VarChar, 15);
            param[1].Value = US_NM;

            param[2] = new SqlParameter("@user_psw", SqlDbType.VarChar, 15);
            param[2].Value = PSW;

            param[3] = new SqlParameter("@user_type", SqlDbType.VarChar, 15);
            param[3].Value = US_TYPE;

            DAL.ExecuteCommand("update_users", param);
            DAL.close();
           
        }
    }
}
