using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;



namespace Stuport
{

    class StudentController
    {
        public void AddStudent(String StudNum, String FName, String LName, String Email, String Phone, String Password)
        {
            String HashedPassword = Password.Sha256();

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "Insert into Student" +
                "([Student_ID],[Student_FirstName], [Student_LastName], [Student_Email], [Student_Phone], [Student_Password])" +
                "Values(?,?, ?, ?, ?, ?)";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = StudNum });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = FName });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = LName });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 100) { Value = Email });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 10) { Value = Phone });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = HashedPassword });

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

        }

        //getters
        public String getStdNum(String username)
        {
            String stdnum = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_ID From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                stdnum = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

            return stdnum;
        }

        public String getFname(String username)
        {
            String fname = "";
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);


            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_FirstName From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                fname = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

            return fname;
        }

        public String getLname(String username)
        {
            String lname = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_LastName From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lname = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

            return lname;
        }

        public String getPhone(String username)
        {
            String phone = "";
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_Phone From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                phone = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

            return phone;
        }

        public String getEmail(String username)
        {
            String stdEmail = "";
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_Email From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                stdEmail = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

            return stdEmail;
        }

        public bool StudNumExists(String StudNum)
        {

            String chckStudNum = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_ID From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = StudNum });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                chckStudNum = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();
            if (!chckStudNum.Equals(""))
            {
                Console.WriteLine(false);
                return true;
            }
            else
            {
                Console.WriteLine(false);
                return false;
            }

        }

        public bool EmailExists(String Email)
        {

            String chckEmail = "";
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_Email From Student Where Student_Email =?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 100) { Value = Email });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                chckEmail = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();
            if (!chckEmail.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool PasswordLengthCheck(String Password)
        {
            int length = Password.Length;
            if (length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PhoneNumberLengthCheck(String Phone)
        {
            int length = Phone.Length;
            if (length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidLogin(string StudNum, string password)
        {
            string PassCheck = "";

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_Password From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = StudNum });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                PassCheck = reader.GetString(0).Trim();
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

            if (PassCheck.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

    public static class HashExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">The input.<param>
        /// <returns>A hash</returns>
        public static string Sha256(this string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                using (var sha = SHA256.Create())
                {
                    var bytes = Encoding.UTF8.GetBytes(input);
                    var hash = sha.ComputeHash(bytes);

                    return Convert.ToBase64String(hash);
                }
            }
            else
            {
                return string.Empty;
            }
        }
    }



}
