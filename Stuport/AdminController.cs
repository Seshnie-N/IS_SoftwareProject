using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stuport.Appointment_personnel.Model;
using Stuport.Appointment_Service.Model;
using Stuport.Groups_Service.Model;
using Stuport.Groups_Personnel.Model;
using Stuport.Groups_Service;
using System.Data;

namespace Stuport.AdminController
{
    class AdminController
    {
        static string _path = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\ReposUni\IS_SoftwareProject\Stuport\bin\Debug\StuportDatabase.accdb";
        public OleDbCommand dbCommand;
        public List<Appointment_Service.Model.ServiceType> AppServiceTypesList;
        public List<Appointment_personnel.Model.PersonnelType> AppPersonnelTypesList;
        public List<Groups_Service.Model.ServiceType> serviceTypesList;
        public List<Groups_Personnel.Model.PersonnelType> personnelTypesList;



        public void RefreshGridGroups(ref DataTable dt)
        {
            dt = new DataTable();
            OleDbConnection conn;
            conn = new OleDbConnection(_path);
            //string query = $"SELECT Group_ID,Service_Type,[Personnel].[Personnel_FirstName] , [Personnel].[Personnel_LastName]," +
            //    " Group_Venue, Group_Time, Group_Date, Group_Status" +
            //   "FROM(([Group]  LEFT OUTER JOIN[Service] on[Group].[Service_ID] =[Service].[Service_ID])" +
            //    "LEFT OUTER JOIN[Personnel] on[Group].[Personnel_ID] =[Personnel].[Personnel_ID]) " +
            //    "ORDER BY Group_ID";
            string query = $"SELECT [Group_ID], [Service_Type], [Personnel_ID], [Group_Venue], [Group_Time], [Group_Date], [Group_Status]" +
                   "FROM[Group]  LEFT OUTER JOIN [Service] on [Group].[Service_ID] =[Service].[Service_ID]" +
                   "ORDER BY Group_ID";
            var da = new OleDbDataAdapter(query, conn);
            da.Fill(dt);
            //dgvGroups.DataSource = dt;
  
        }
    }
}
