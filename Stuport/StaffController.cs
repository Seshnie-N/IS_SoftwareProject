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
    class StaffController
    {
        public void AddStaff(String FName, String LName, String Email, String Phone, String Type)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "Insert into Personnel" +
                "([Personnel_FirstName], [Personnel_LastName], [Personnel_Email], [Personnel_Phone], [Personnel_Type])" +
                "Values(?, ?, ?, ?, ?)";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = FName });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = LName });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 100) { Value = Email });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 10) { Value = Phone });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = Type });

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

        }


        public void UpdateFName(int ID, String FName)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE Personnel SET Personnel_FirstName = ? WHERE Personnel_ID = ?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = FName });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

        }

        public void UpdateLName(int ID, String LName)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE Personnel SET Personnel_LastName = ? WHERE Personnel_ID = ?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = LName });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

        }

        public void UpdateEmail(int ID, String Email)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE Personnel SET Personnel_Email = ? WHERE Personnel_ID = ?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 100) { Value = Email });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

        }

        public void UpdatePhone(int ID, String Phone)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE Personnel SET Personnel_Phone = ? WHERE Personnel_ID = ?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 10) { Value = Phone });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

        }

        public void UpdateType(int ID, String Type)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand cmd = con.CreateCommand();

            cmd.CommandText = "UPDATE Personnel SET Personnel_Type = ? WHERE Personnel_ID = ?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 100) { Value = Type });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

        }





        //getters
        public String getID(String Email)
        {
            String stdnum = "";
            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Personnel_ID From Personnel Where Personnel_Email=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 100) { Value = Email });

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

        public String getFname(int ID)
        {
            String fname = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Personnel_FirstName From Personnel Where Personnel_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

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

        public String getType(int ID)
        {
            String type = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Personnel_Type From Personnel Where Personnel_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                type = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();

            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();

            return type;
        }


        public String getLname(int ID)
        {
            String lname = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Personnel_LastName From Personnel Where Personnel_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

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

        public String getPhone(int ID)
        {
            String phone = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Personnel_Phone From Personnel Where Personnel_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

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

        public String getEmail(int ID)
        {
            String stdEmail = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Personnel_Email From Personnel Where Personnel_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

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


        public bool IDExists(int ID)
        {

            String chckStudNum = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);

            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Personnel_ID From Personnel Where Personnel_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.Integer) { Value = ID });

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
            cmd.CommandText = "Select Personnel_Email From Personnel Where Personnel_Email =?";
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

        public bool PhoneExists(String Phone)
        {

            String chckEmail = "";

            string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
            OleDbConnection con = new OleDbConnection(connectionString);
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Select Personnel_Phone From Personnel Where Personnel_Phone =?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 100) { Value = Phone });

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

}

