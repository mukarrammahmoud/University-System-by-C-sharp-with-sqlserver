using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MANAGEMENT_UNIVERSITY.BL
{
    class CLS_STUDENTS
    {
        public DataTable GETT_ALL_COLLAGE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GETT_ALL_COLLAGE", null);
            DAL.close();
            return DT;
        }
        public DataTable GETT_ALL_DEPARTMENT(int col)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@CLG_ID", SqlDbType.Int);
            param[0].Value = col;

            DT = DAL.selectdata("GETT_ALL_DEPARTMENT", param);
            DAL.close();
            return DT;
        }
        public void ADD_STUDENT(int ST_ID, string ST_NAME, string GENDER, string PHONE, string ADDRESS,
            string BIRTHDATE,string COLLAGE,string DEPT, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ST_ID", SqlDbType.Int);
            param[0].Value = ST_ID;

            param[1] = new SqlParameter("@ST_NAME", SqlDbType.VarChar, 30);
            param[1].Value = ST_NAME;

            param[2] = new SqlParameter("@GENDER ", SqlDbType.VarChar, 15);
            param[2].Value = GENDER;

            param[3] = new SqlParameter("@PHONE", SqlDbType.VarChar,15);
            param[3].Value = PHONE;

            param[4] = new SqlParameter("@ADDRESS", SqlDbType.VarChar, 15);
            param[4].Value = ADDRESS;

            param[5] = new SqlParameter("@BIRTHDATE", SqlDbType.VarChar,15);
            param[5].Value = BIRTHDATE;

            param[6] = new SqlParameter("@COLLAGE", SqlDbType.VarChar, 20);
            param[6].Value = COLLAGE;

            param[7] = new SqlParameter("@DEPT", SqlDbType.VarChar, 20);
            param[7].Value = DEPT;

            param[8] = new SqlParameter("@img", SqlDbType.Image);
            param[8].Value = img;

         

            DAL.ExecuteCommand("ADD_STUDENT", param);
            DAL.close();
        }
        public DataTable verifystudentid(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@st_id", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("verifystudentid", param);
            DAL.close();
            return DT;
        }
        public DataTable GET_ALL_STUDENTS()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            DT = DAL.selectdata("GET_ALL_STUDENTS", null);
            DAL.close();
            return DT;
        }
        public DataTable GET_IMAGE_STUDENT(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ST_ID", SqlDbType.Int);
            param[0].Value = ID;

            DT = DAL.selectdata("GET_IMAGE_STUDENT", param);
            DAL.close();
            return DT;
        }
        public DataTable SEARCHSTUDENT(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            DataTable DT = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ST_ID", SqlDbType.VarChar,20);
            param[0].Value = ID;

            DT = DAL.selectdata("SEARCHSTUDENT", param);
            DAL.close();
            return DT;
        }
        public void UPDATE_STUDENTS(int ST_ID, string ST_NAME, string GENDER, string PHONE, string ADDRESS,
          string BIRTHDATE, string COLLAGE, string DEPT, byte[] img)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.open();
            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@ST_ID", SqlDbType.Int);
            param[0].Value = ST_ID;

            param[1] = new SqlParameter("@ST_NAME", SqlDbType.VarChar, 30);
            param[1].Value = ST_NAME;

            param[2] = new SqlParameter("@GENDER ", SqlDbType.VarChar, 15);
            param[2].Value = GENDER;

            param[3] = new SqlParameter("@PHONE", SqlDbType.VarChar, 15);
            param[3].Value = PHONE;

            param[4] = new SqlParameter("@ADDRESS", SqlDbType.VarChar, 15);
            param[4].Value = ADDRESS;

            param[5] = new SqlParameter("@BIRTHDATE", SqlDbType.VarChar,15);
            param[5].Value = BIRTHDATE;

            param[6] = new SqlParameter("@COLLAGE", SqlDbType.VarChar, 20);
            param[6].Value = COLLAGE;

            param[7] = new SqlParameter("@DEPT", SqlDbType.VarChar, 20);
            param[7].Value = DEPT;

            param[8] = new SqlParameter("@img", SqlDbType.Image);
            param[8].Value = img;



            DAL.ExecuteCommand("UPDATE_STUDENTS", param);
            DAL.close();
        }
        public void deletestudent(int ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();

            
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = ID;

             DAL.ExecuteCommand("deletestudent", param);
            DAL.close();
            
        }
    }
}
