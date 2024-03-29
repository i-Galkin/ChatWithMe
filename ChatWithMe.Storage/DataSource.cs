﻿using System;
using ChatWithMe.Storage;

namespace ChatWithMe.DataStorage
{
    public class DataSource : IDisposable
    {
        protected DatabaseContext MongoContext { get; }

        public DataSource(DatabaseContext mongoContext)
        {
            MongoContext = mongoContext;
        }

        // public UserRepository Users => new UserRepository(Context);


        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
