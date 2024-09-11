

using blog.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

namespace blog
{
    class Program
    {
        private const string CONNECTION_STRING = "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Trust Server Certificate=True";

        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING)) 
            {
                var users = connection.GetAll<User>();

                foreach(var user in users)
                {
                    Console.WriteLine(user.Name);
                }
            }

            Console.ReadKey();
        }
    }

}
