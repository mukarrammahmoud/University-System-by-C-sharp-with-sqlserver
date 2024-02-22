using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace MANAGEMENT_UNIVERSITY.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;
        //this constructor inisialize the connection opject
        public DataAccessLayer()
        {
          
                String Mode = Properties.Settings.Default.MODE;
                if (Mode == "SQL")
                {
                    sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.SERVER
                     + "; DataBase=" + Properties.Settings.Default.DATABASE
                      + "; integrated security=false ;user id=" + Properties.Settings.Default.USERID
                      + ";password =" + Properties.Settings.Default.PSW + "");

                }
                else
                {
                    sqlconnection = new SqlConnection(@"server=" + Properties.Settings.Default.SERVER + "; DataBase=" + Properties.Settings.Default.DATABASE + "; integrated security=true");
                }
            
           
        }
        //method to open connection
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }

        }
        //method to close connection
        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        //method to read data from database
        public DataTable selectdata(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //method to insert ,update and delete data from database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    }
}
