using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Windows.Forms;

namespace CheckMateApp
{
    class DBAccess
    {

        SqlConnection conn;

        public DBAccess()
        {
            conn = ConnectionManager.GetConnection();
        }


        public DataSet FindLetter(int no)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select q.ID,q.LETTER from t001_Quiz q where  q.ID='" + no + "'";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t001_Quiz");
            conn.Close();
            return ds;
        }
        public DataSet FindWord(int no)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select w.ID,w.WORD,w.PRONOUNCE from t003_Word w where w.ID='" + no + "'";
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "t003_Word");
            conn.Close();
            return ds;
        }

        public void addUser(string uname, string pass, string fname,string lname,string utype,string telno,string email,string nic)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd1 = conn.CreateCommand();
            newCmd1.Connection = conn;
            newCmd1.CommandType = CommandType.Text;
            newCmd1.CommandText = "insert into t004_Users(UserName,Passwrod,Fname,Lname,UserType,Telno,Email,Nic) values('" + uname + "','" + pass + "','" + fname + "','" + lname + "','" + utype + "','" + telno + "','" + email + "','" + nic + "')";
            newCmd1.ExecuteNonQuery();
            conn.Close();
        }

        public bool AuthenticateUser(string uname, string pass)
        {
            try
            {


                if (conn.State.ToString() == "Closed")
                {
                    conn.Open();

                }

                string queryText = @"SELECT COUNT(*) FROM t004_Users WHERE UserName=@uname AND Passwrod=@pass";
                SqlCommand cmd = new SqlCommand(queryText, conn);
                cmd.Parameters.AddWithValue("@uname", uname);
                cmd.Parameters.AddWithValue("@pass", pass);
                int result = (int)cmd.ExecuteScalar();
                conn.Close();
                if (result > 0)
                    return true;
                else

                    return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void SetSession(string username)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            string query = "select UserName,UserType from t004_Users where UserName='" + username + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "t004_Users");

            DataTable dt = ds.Tables["t004_Users"];

            foreach (DataRow dr in dt.Rows)
            {
                Session.logedInType = (dr["UserType"].ToString());
            }

            Session.logedInAs = username;


            conn.Close();

        }
        public string getMatchLetterFromDB(int id,bool IsThumb, bool IsIndex, bool IsMiddle, bool IsRing, bool IsPinky)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand cmd = new SqlCommand("dbo.GetMatchLetter", conn);
            cmd.Parameters.Add("IsThumb", SqlDbType.Bit).Value = IsThumb;
            cmd.Parameters.Add("IsIndex", SqlDbType.Bit).Value = IsIndex;
            cmd.Parameters.Add("IsMiddle", SqlDbType.Bit).Value = IsMiddle;
            cmd.Parameters.Add("IsRing", SqlDbType.Bit).Value = IsRing;
            cmd.Parameters.Add("IsPinky", SqlDbType.Bit).Value = IsPinky;
            cmd.Parameters.Add("ID", SqlDbType.Int).Value = id;
            //cmd.Parameters.Add("T_val", SqlDbType.Float).Value = t_val;
            //cmd.Parameters.Add("I_val", SqlDbType.Float).Value = i_val;
            //cmd.Parameters.Add("M_val", SqlDbType.Float).Value = m_val;
            //cmd.Parameters.Add("R_val", SqlDbType.Float).Value = r_val;
            //cmd.Parameters.Add("P_val", SqlDbType.Float).Value = p_val;
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable("GetMatchLetter");
            da.Fill(dt);
            cmd.Dispose();
            //conn.Close();
            //conn.Dispose();
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0].Field<string>("LETTER");
            }
            else
            {
                return null;
            }
        }

   


        internal void marksAdd(string getMarks, string qmark, int qmarks)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into t005_UserMarks(Uname,max_marks,attems,adate) values('" + getMarks + "','" + qmark + "','" + qmarks + "',GETDATE())";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
