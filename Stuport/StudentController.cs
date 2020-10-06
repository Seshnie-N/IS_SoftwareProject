using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Data.OleDb;


namespace Stuport
{
    class StudentController
    {
        public void AddStudent(String FName, String LName, String Email, String Phone, String Password)
        {

            String HashedPassword = Password.Sha256();

            OleDbConnection con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;Data Source=StuportDatabase.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "Insert into Student"+
                "([Student_FirstName], [Student_LastName], [Student_Email], [Student_Phone], [Student_Password])" +
                "Values(@FirstName, @LastName, @Email, @Phone, @Password)";

            cmd.Parameters.AddRange(new OleDbParameter[]
           {
               new OleDbParameter("@FirstName", FName),
               new OleDbParameter("@LastName", LName),
              new OleDbParameter("@Email", Email),
              new OleDbParameter("@Phone", Phone),
              new OleDbParameter("@Password", HashedPassword)
           });


            cmd.Connection = con;
            cmd.ExecuteNonQuery();
        
            con.Close();
           



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
