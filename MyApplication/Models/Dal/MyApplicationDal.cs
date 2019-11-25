using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using MyApplication.Models.Bal;


namespace MyApplication.Models
{
    public class MyApplicationDal
    {
        SqlConnection con;
        SqlCommand cmd;
        public MyApplicationDal()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        
        }

        public int myApp(MyApplicationBal myApplicationBal)
        {
            cmd = new SqlCommand("SP_Student_Register", con);
            cmd.Parameters.AddWithValue("@Name", myApplicationBal.Name);
            cmd.Parameters.AddWithValue("@Course", myApplicationBal.Course);
            cmd.Parameters.AddWithValue("@Email", myApplicationBal.Email);
            cmd.Parameters.AddWithValue("@Marks", myApplicationBal.Marks);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            int i=  cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}