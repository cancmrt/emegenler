using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataSource.LiteDB
{
    public class LiteDBConnection
    {
        public LiteDatabase GetDatabase()
        {
            try
            {
                LiteDatabase db = new LiteDatabase(@"EmegenlerSelf.db");
                return db;
            }
            catch(Exception exception)
            {
                throw exception;
            }

        }
    }
}
