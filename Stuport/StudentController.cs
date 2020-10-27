﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Xml;

namespace Stuport
{
    class StudentController
    {
        public void AddStudent(String StudNum,String FName, String LName, String Email, String Phone, String Password)
        {

            String HashedPassword = Password.Sha256();

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");
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
        public String RequestAppointment(String Date,String ServiceType,String Time)
        {

            //make placeholder 00 
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");



            con.Open();
            string query = $"UPDATE [Appointment] SET [Appointment_Date] = @1, [Appointment_Time] = @2," +
                "[Personnel_ID] = @3, [Service_ID] = @4, [Appointment_Status] = @5 WHERE [Student_ID] = @6";
            OleDbCommand cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@1", Convert.ToDateTime(Date));
            cmd.Parameters.AddWithValue("@2", Time);
            cmd.Parameters.AddWithValue("@3", "00");
            cmd.Parameters.AddWithValue("@4", ServiceType);
            cmd.Parameters.AddWithValue("@5", "Requested");
            String StdNum = getStdNum();
            cmd.Parameters.AddWithValue("@6", StdNum );
            cmd.ExecuteNonQuery();
            con.Close();
            string output = "request received";
            return output;
        }

        public void ServicesFill()
        {
            serviceTypesList = new List<ServiceType>();

            OleDbConnection conn;
            OleDbCommand dbCommand;

            string query = "SELECT Service_ID, Service_Description FROM Service ORDER BY Service_Type";

            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");
            conn.Open();

            dbCommand = conn.CreateCommand();

            dbCommand.Parameters.Clear();
            dbCommand.CommandText = query;

            var reader = dbCommand.ExecuteReader();

            while (reader.Read())
            {
                var serviceType = new ServiceType()
                {
                    ServiceId = (int)reader["Service_ID"],
                };
                if (!reader["Service_Description"].Equals(DBNull.Value))
                    serviceType.ServiceTypeName = (string)reader["Service_Description"];
                serviceTypesList.Add(serviceType);
            }
            reader.Close();
            conn.Close();
        }


        //getters
        public String getStdNum()
        {
            String stdnum = "";

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_ID From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = "20907029" });

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

        public String getFname()
        {
            String fname = "";

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_FirstName From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = "20907029" });

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

        public String getLname()
        {
            String lname = "";

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_LastName From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = "20907029" });

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

        public String getPhone()
        {
            String phone = "";

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_Phone From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = "20907029" });

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

        public String getEmail()
        {
            String stdEmail = "";

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_Email From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = "20907029" });

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

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+AppDomain.CurrentDomain.BaseDirectory+"StuportDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_ID From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = StudNum });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
              chckStudNum =  reader.GetString(0);
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

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + AppDomain.CurrentDomain.BaseDirectory + "StuportDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Student_Email From Student Where Student_Email =?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 100) { Value = Email});

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
