using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Stratis.Guru.Models
{
    public class LotteryDraw
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public long DrawDate { get; set; }
        public bool Passed { get; set; }
    }
}