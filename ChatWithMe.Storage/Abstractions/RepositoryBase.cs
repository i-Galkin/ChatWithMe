using ChatWithMe.Storage;
using MongoDB.Driver;

namespace ChatWithMe.DataStorage.Abstractions
{
    /// <summary>
    /// Repository base class
    /// </summary>
    public abstract class RepositoryBase<T> where T : EntityBase
    {
        protected IMongoCollection<T> Collection { get; }
        protected DatabaseContext DbContext { get; }

        protected RepositoryBase(IMongoCollection<T> collection, DatabaseContext dbContext)
        {
            Collection = collection;
            DbContext = dbContext;
        }
        
        // TODO: Investigate about template mongo CRUD methods

    }
}