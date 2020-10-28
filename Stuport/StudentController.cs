﻿using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using Stuport.Login;
using System.Xml;
using System.Globalization;
using System.Configuration;
using System.Data;

namespace Stuport
{

    static class Global
    {
        public static string Token;
    }

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


        public void RefreshGridAppointment(ref DataTable dt)
        {
            dt = new DataTable();
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn = new OleDbConnection(connectionString);

            string query = $"SELECT [Appointment_ID], [Service_Description], [Appointment_Date], [Appointment_Time] " +
                   "FROM [Appointment] inner join Service on Service.Service_ID = Appointment.Service_ID WHERE Appointment.Student_ID = ? ORDER BY Appointment_ID ";
            
            OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
            da.SelectCommand.Parameters.Add("?", OleDbType.VarChar, 15).Value = Global.Token;
                conn.Open();
                da.Fill(dt);
       
            conn.Close();

        }

        public String RequestAppointment(String Date,String ServiceType,String Time)
        {

            //make placeholder 00 
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);



            con.Open();
            string query = $"Insert into Appointment  ([Appointment_Date], [Appointment_Time]," +
                "[Personnel_ID], [Service_ID], [Appointment_Status], [Student_ID]) VALUES(@1,@2,@3,@4,@5,@6)";
            OleDbCommand cmd = new OleDbCommand(query, con);
          //  DateTime DateAppointment =DateTime.ParseExact(Date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            cmd.Parameters.AddWithValue("@1", Date);
            cmd.Parameters.AddWithValue("@2", Time);
            cmd.Parameters.AddWithValue("@3", 1);
            cmd.Parameters.AddWithValue("@4", Convert.ToInt32(ServiceType));
            cmd.Parameters.AddWithValue("@5", "Requested");
            String StdNum = getStdNum();
            cmd.Parameters.AddWithValue("@6", StdNum );
            cmd.ExecuteNonQuery();
            con.Close();
            string output = "request received";
            return output;
        }

        //getters
        public String getStdNum()
        {
            String stdnum = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_ID From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = Global.Token});

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
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = Global.Token });

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
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = Global.Token });

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
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = Global.Token });

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
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = Global.Token });

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


        public void CancelAppointment(int AppointmentID)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Delete From Appointment where Appointment_ID = ?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = AppointmentID });
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }


        public bool ValidLogin(string StudNum, string password)
        {
            string PassCheck = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
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

            if (PassCheck.Equals(HashExtensions.Sha256(password)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool AdminExists(String username)
        {

            String chckAdmin = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Admin_FirstName From Admin Where Admin_FirstName=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                chckAdmin = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();
            if (!chckAdmin.Equals(""))
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

        public bool ValidAdmin(string username, string password)
        {
            string PassCheck = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Admin_Password From Admin Where Admin_FirstName=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = username });

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
