using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stuport.AdminController.Model;
using Stuport.Groups_Service;
using System.Data;
using System.Drawing.Printing;

namespace Stuport.AdminController
{
    class AdminController
    {
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ReposUni\IS_SoftwareProject\Stuport\bin\Debug\StuportDatabase-Updated-v2.accdb";

        public List<ServiceType> serviceTypesList { get; set; }

        public List<PersonnelType> personnelTypesList { get; set; }

        public void RefreshGridGroups(ref DataTable dt)
        {
            dt = new DataTable();
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            string query = $"SELECT [Group_ID], [Service_Description], [Personnel_ID], [Group_Venue], [Group_Time], [Group_Date], [Group_Status], [Std_Counter]" +
                   "FROM[Group]  LEFT OUTER JOIN [Service] on [Group].[Service_ID] =[Service].[Service_ID]" +
                   "ORDER BY Group_ID";
            var da = new OleDbDataAdapter(query, conn);
            da.Fill(dt);
        } 

        public void RefreshGridAppointment(ref DataTable dt)
        {
            dt = new DataTable();
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            string query = $"SELECT [Appointment_ID], [Service_Description], [Personnel_ID], [Student_ID], [Appointment_Date], [Appointment_Time], [Appointment_Status]" +
                   "FROM[Appointment]  LEFT OUTER JOIN [Service] on [Appointment].[Service_ID] =[Service].[Service_ID]" +
                   "ORDER BY Appointment_ID";
            var da = new OleDbDataAdapter(query, conn);
            da.Fill(dt);
        } 

        public void RefreshGridStudent(ref DataTable dt)
        {
            dt = new DataTable();
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            string query = $"SELECT * FROM Student";
            var da = new OleDbDataAdapter(query, conn);
            da.Fill(dt);
        }

        public void FillerService()
        {
            serviceTypesList = new List<ServiceType>();

            OleDbConnection conn;
            OleDbCommand dbCommand;

            string query = "SELECT Service_ID, Service_Description FROM Service ORDER BY Service_Type";

            conn = new OleDbConnection(_path);
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

        public void FillerPersonnel()
        {
            personnelTypesList = new List<PersonnelType>();

            OleDbConnection conn;
            OleDbCommand dbCommand;

            string query = "SELECT [Personnel_ID], [Personnel_FirstName], [Personnel_LastName] FROM [Personnel] ORDER BY [Personnel_FirstName]";

            conn = new OleDbConnection(_path);
            conn.Open();

            dbCommand = conn.CreateCommand();

            dbCommand.Parameters.Clear();
            dbCommand.CommandText = query;

            var reader = dbCommand.ExecuteReader();

            while (reader.Read())
            {
                var personnelType = new PersonnelType()
                {
                    PersonnelId = (int)reader["Personnel_ID"],
                };
                if (!reader["Personnel_FirstName"].Equals(DBNull.Value))
                {
                    personnelType.PersonnelFirstName = (string)reader["Personnel_FirstName"];
                }
                personnelTypesList.Add(personnelType);
            }
            reader.Close();
            conn.Close();
        } 

        public void updateGroup()
        {

        } //TODO

        public void removeGroup(int intGroupID) 
        {
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM [Group] WHERE Group_ID = @1", conn);
            cmd.Parameters.AddWithValue("@1", intGroupID);
            cmd.ExecuteNonQuery();
            conn.Close();
        } 

        public void updateAppointment()
        {

        } //TODO

        public void removeAppointment(int AppointmentId)
        {
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("DELETE FROM [Appointment] WHERE [Appointment_ID] = @1", conn);
            cmd.Parameters.AddWithValue("@1", AppointmentId);
            cmd.ExecuteNonQuery();
            conn.Close();
        } 

        public void addStudent(string strStuNumber, string strFName, string strLName, string strPassword, string strEmail, string strContactNo)
        {
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            OleDbCommand cmd = conn.CreateCommand();

            cmd.CommandText = "Insert into Student" +
                "([Student_ID],[Student_FirstName], [Student_LastName], [Student_Email], [Student_Phone], [Student_Password])" +
                "Values(?,?, ?, ?, ?, ?)";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = strStuNumber });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = strFName });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = strLName });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 100) { Value = strEmail });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 10) { Value = strContactNo });
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 50) { Value = strPassword });

            conn.Open();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        } 

        public void updateStudent(string strStuNumber, string strFName, string strLName, string strPassword, string strEmail, string strContactNo)
        {
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            conn.Open();
            string query = $"UPDATE Student SET Student_FirstName = @1, Student_LastName = @2," +
                " Student_Email = @3, Student_Phone = @4, Student_Password = @5  WHERE Student_ID = @6";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@1", strFName);
            cmd.Parameters.AddWithValue("@2", strLName);
            cmd.Parameters.AddWithValue("@3", strEmail);
            cmd.Parameters.AddWithValue("@4", strContactNo);
            cmd.Parameters.AddWithValue("@5", strPassword);
            cmd.Parameters.AddWithValue("@6", strStuNumber);
            cmd.ExecuteNonQuery();
            conn.Close();
        } 

        public bool StudentExist(string StudentNum)
        {
            string StdNum = "";
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            OleDbCommand cmd = conn.CreateCommand();
            conn.Open();
            cmd.CommandText = "Select Student_ID From Student Where Student_ID=?";
            cmd.Parameters.Add(new OleDbParameter("?", OleDbType.VarChar, 15) { Value = StudentNum });

            OleDbDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                StdNum = reader.GetString(0);
            }
            // always call Close when done reading.
            reader.Close();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            if (StdNum == StudentNum)
                return (true);
            else
                return (false);
        } 

    }
}
