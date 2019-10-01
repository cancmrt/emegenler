using Domain.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSource.LiteDB.Repositories
{
    public class PolicyRepository
    {
        LiteCollection<Policy> _collection;
        public PolicyRepository()
        {
            LiteDBConnection connect = new LiteDBConnection();
            var db = connect.GetDatabase();
            _collection = db.GetCollection<Policy>("policies");
            
        }
        public bool AddNewPolicy(Policy newPolicy)
        {
            try
            {
                _collection.Insert(newPolicy);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
            
        }
    }
}
