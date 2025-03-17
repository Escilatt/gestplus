using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftUI.MVVM.Model;
using System.Net;
using System.Data.SqlClient;
using System.Data;

namespace SoftUI.Repositories
{
    public class UserRepository : RepositoryBase, IUserRepository
    {
        public void Add(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public bool AuthenticateUser(NetworkCredential credential)
        {
            {
                bool validUser;
                using (var connection = GetConnection()) 
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "select* from [Usu] where Nombre=@Nombre and [Pass]=@Pass";
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = credential.UserName;
                    command.Parameters.Add("@Pass", SqlDbType.VarChar).Value = credential.Password;
                    validUser = command.ExecuteScalar() == null ? false : true;
                    
                }
                return validUser;

            }
        }

        public void Edit(UserModel userModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserModel> GetByAll()
        {
            throw new NotImplementedException();
        }

        public UserModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserModel GetByUsername(string username)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
