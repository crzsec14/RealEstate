using Dapper;
using RealEstate.Core.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Core.Services
{
    public class UserService
    {
        public List<User> GetUsers()
        {
            SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["dbRealEstate"].ConnectionString);            

            List<User> users = SqlMapper.Query<User>(sqlCon, "SELECT * FROM Users").ToList();
            return users;
        }
    }
}
