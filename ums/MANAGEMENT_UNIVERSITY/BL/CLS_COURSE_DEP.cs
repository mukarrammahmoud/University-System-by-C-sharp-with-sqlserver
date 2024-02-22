using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.BL
{
    class CLS_COURSE_DEP
    {

        public DataTable GET_NAME_COURCE(int d)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@COURSE_ID", SqlDbType.Int);
            param[0].Value = d;

            DT = DAL.selectdata("GET_NAME_COURCE", param);
            DAL.close();
            return DT;
        }
        public DataTable get_all_idcoourse()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("get_all_idcoourse", null);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_DEPT_ID()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_DEPT_ID", null);
            DAL.close();
            return DT;
        }
        public DataTable GET_DEP_NAME(int d)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@DEPT_ID", SqlDbType.Int);
            param[0].Value = d;

            DT = DAL.selectdata("GET_DEP_NAME", param);
            DAL.close();
            return DT;
        }
        public DataTable ADD_CRS_TO_DEPT(int CRSID,int DEPID,String TERMS,String LEVELS,String T_COURSE,String CRS,String DEPT)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@CRS_ID", SqlDbType.Int);
            param[0].Value = CRSID;

            param[1] = new SqlParameter("@DEP_ID", SqlDbType.Int);
            param[1].Value = DEPID;

            param[2] = new SqlParameter("@TERM", SqlDbType.VarChar,15);
            param[2].Value = TERMS;

            param[3] = new SqlParameter("@LEVELS", SqlDbType.VarChar,15);
            param[3].Value = LEVELS;

            param[4] = new SqlParameter("@T_COURSE", SqlDbType.VarChar, 15);
            param[4].Value = T_COURSE;

            param[5] = new SqlParameter("@CRS_NAME", SqlDbType.VarChar, 15);
            param[5].Value = CRS;

            param[6] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 15);
            param[6].Value = DEPT;

            DT = DAL.selectdata("ADD_CRS_TO_DEPT", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_TYPE_COURSE(int COURSEID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@COURSE_ID", SqlDbType.Int);
            param[0].Value = COURSEID;

            DT = DAL.selectdata("GET_TYPE_COURSE", param);
            DAL.close();
            return DT;
        }
        public DataTable CHECK_ADD_COURSE(int ID,int ID_DEP)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@COURSE_ID", SqlDbType.Int);
            param[0].Value = ID;

            param[1] = new SqlParameter("@DEP_ID", SqlDbType.Int);
            param[1].Value = ID_DEP;

            DT = DAL.selectdata("CHECK_ADD_COURSE", param);
            DAL.close();
            return DT;
        }
        public DataTable get_all_containt_course()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("get_all_containt_course", null);
            DAL.close();
            return DT;
        }
        public DataTable delete_course(int COURSEID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = COURSEID;

            DT = DAL.selectdata("delete_course", param);
            DAL.close();
            return DT;
        }
        public DataTable CHECK_NAME_COURCE(String d)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@COURSE_nm", SqlDbType.VarChar,15);
            param[0].Value = d;

            DT = DAL.selectdata("CHECK_NAME_COURCE", param);
            DAL.close();
            return DT;
        }
        public DataTable UPDATE_CRS_DEP(int CRSID,String CRS_NM ,int DEP_ID,String DEP_NM,String TRM,String LVL,String TYP_CRS)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@CRS_ID", SqlDbType.Int);
            param[0].Value = CRSID;

            param[1] = new SqlParameter("@CRS_NAME", SqlDbType.VarChar,15);
            param[1].Value = CRS_NM;

            param[2] = new SqlParameter("@DEP_ID", SqlDbType.Int);
            param[2].Value = DEP_ID;

            param[3] = new SqlParameter("@DEP_NAME", SqlDbType.VarChar, 15);
            param[3].Value = DEP_NM;

            param[4] = new SqlParameter("@TERM", SqlDbType.VarChar, 15);
            param[4].Value = TRM;

            param[5] = new SqlParameter("@LVL", SqlDbType.VarChar, 15);
            param[5].Value = LVL;

            param[6] = new SqlParameter("@TYPE_CRS", SqlDbType.VarChar, 15);
            param[6].Value = TYP_CRS;

            DT = DAL.selectdata("UPDATE_CRS_DEP", param);
            DAL.close();
            return DT;
        }
    }
}
