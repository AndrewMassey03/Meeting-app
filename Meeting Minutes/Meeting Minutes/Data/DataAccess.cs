using Meeting_Minutes.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration.UserSecrets;
using System.Collections;
using System.Linq;

namespace Meeting_Minutes.Data
{
    internal class DataAccess
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=meeting-db;Integrated Security=True";

        //fetch all users
        public List<User> FetchAllUser()
        {
            List<User> returnList = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM [user]";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        User user = new User();
                        user.UserId = reader.GetInt32(0);
                        user.UserName = reader.GetString(1);

                        returnList.Add(user);
                    }
                }
            }
            return returnList;
        }

        //fetch one user
        public User FetchOneUser(int id)
        {


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "SELECT * FROM [user] WHERE UserId = @id";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                User user = new User();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        user.UserId = reader.GetInt32(0);
                        user.UserName = reader.GetString(1);


                    }
                }
                return user;
            }

        }

        //create user

        public int CreateOrUpdate(User user)
        {

            //access the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "";
                if (user.UserId <= 0)
                {
                    sqlQuery = "INSERT INTO [user] Values(@UserName)";
                }
                else
                {
                    sqlQuery = "UPDATE [User] SET UserName = @UserName WHERE UserId = @UserId";
                }

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@UserId", System.Data.SqlDbType.VarChar, 100).Value = user.UserId;
                command.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar, 100).Value = user.UserName;
                connection.Open();
                int newID = command.ExecuteNonQuery();

                return newID;
            }

        }

        //delete user
        public int Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = "DELETE from [user] WHERE UserId = @Id ";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.Add("@Id", System.Data.SqlDbType.VarChar, 100).Value = id;
                connection.Open();
                int deletedID = command.ExecuteNonQuery();

                return deletedID;
            }
        }


        //Fetch All Meetings
        public List<Meeting>  FetchAllMeets()
        {
            List<Meeting> returnList = new List<Meeting>();
            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string sqlQuery = "SELECT * FROM [meeting]";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        Meeting meets = new Meeting();
                        meets.meetingID = reader.GetInt32(0) ;
                        meets.meetingNumber = reader.GetInt32(1);
                        meets.meetingDate = reader.GetDateTime(2);
                        meets.MeetingTypeId= reader.GetInt32(3);
                        
                        returnList.Add(meets);
                    }
                }
            }
            return returnList;
        }

    }

}
    

