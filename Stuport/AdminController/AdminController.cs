using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stuport.AdminController.Model;
using Stuport.Groups_Service;
using System.Data;

namespace Stuport.AdminController
{
    class AdminController
    {
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ReposUni\IS_SoftwareProject\Stuport\bin\Debug\StuportDatabase.accdb";

        public List<ServiceType> serviceTypesList { get; set; }

        public List<PersonnelType> personnelTypesList { get; set; }

        public void RefreshGridGroups(ref DataTable dt)
        {
            dt = new DataTable();
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            string query = $"SELECT [Group_ID], [Service_Type], [Personnel_ID], [Group_Venue], [Group_Time], [Group_Date], [Group_Status]" +
                   "FROM[Group]  LEFT OUTER JOIN [Service] on [Group].[Service_ID] =[Service].[Service_ID]" +
                   "ORDER BY Group_ID";
            var da = new OleDbDataAdapter(query, conn);
            da.Fill(dt);
        }

        public void RefreshAppointment(ref DataTable dt)
        {
            dt = new DataTable();
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            string query = $"SELECT [Group_ID], [Service_Type], [Personnel_ID], [Group_Venue], [Group_Time], [Group_Date], [Group_Status]" +
                   "FROM[Group]  LEFT OUTER JOIN [Service] on [Group].[Service_ID] =[Service].[Service_ID]" +
                   "ORDER BY Group_ID";
            var da = new OleDbDataAdapter(query, conn);
            da.Fill(dt);
        }

        public void FillerService()
        {
            serviceTypesList = new List<ServiceType>();

            OleDbConnection conn;
            OleDbCommand dbCommand;

            string query = "SELECT Service_ID, Service_Type FROM Service ORDER BY Service_Type";

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
                if (!reader["Service_Type"].Equals(DBNull.Value))
                    serviceType.ServiceTypeName = (string)reader["Service_Type"];
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
                    personnelType.PersonnelFirstName = (string)reader["Personnel_FirstName"];
                personnelTypesList.Add(personnelType);
            }
            reader.Close();
            conn.Close();
        }
    }
}
