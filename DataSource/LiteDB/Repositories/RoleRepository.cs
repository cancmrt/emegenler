using Domain.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSource.LiteDB.Repositories
{
    public class RoleRepository
    {
        LiteCollection<Role> _collection;
        public RoleRepository()
        {
            LiteDBConnection connect = new LiteDBConnection();
            var db = connect.GetDatabase();
            _collection = db.GetCollection<Role>("roles");

        }
        public bool AddNewRole(Role newRole)
        {
            try
            {
                _collection.Insert(newRole);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
