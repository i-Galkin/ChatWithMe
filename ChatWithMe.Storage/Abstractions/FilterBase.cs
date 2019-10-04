using MongoDB.Bson;

namespace ChatWithMe.Storage.Abstractions
{
    /// <summary>
    /// Database filter base class
    /// </summary>
    public abstract class FilterBase
    {
        /// <summary>
        /// Entity identificator
        /// </summary>
        public ObjectId? ObjectId { get; set; }
    }
}