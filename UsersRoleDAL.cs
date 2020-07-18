using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MenaxhimiTaksit.BO;
using MenaxhimiTaksit.BO.Interfaces;

namespace MenaxhimiTaksit.DAL
{
    class UsersRoleDAL : IBaseCrud<UsersRoleDAL>, IConvertToObject<UsersRoleDAL>
    {
        public int Add(UsersRoleDAL model)
        {
            throw new NotImplementedException();
        }

        public UsersRoleDAL Get(int id)
        {
            throw new NotImplementedException();
        }

        public UsersRoleDAL Get(UsersRoleDAL model)
        {
            throw new NotImplementedException();
        }

        public List<UsersRoleDAL> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Modify(UsersRoleDAL model)
        {
            throw new NotImplementedException();
        }

        public int Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int Remove(UsersRoleDAL model)
        {
            throw new NotImplementedException();
        }

        public int Remove(string id)
        {
            throw new NotImplementedException();
        }

        public UsersRoleDAL ToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
