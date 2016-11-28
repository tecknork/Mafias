using MongoDB.Bson.Serialization.Attributes;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayerModels
{
    public class Game :Entity
    {
        //[BsonElement("_id")]
        public long serverid { get; set; }
        public string serverName { get; set; }
        [BsonIgnoreIfNull]
        public List<MafiaUser> users { get; set; }
        [BsonIgnoreIfNull]
        public List<Rounds> rounds { get; set; }
        [BsonIgnoreIfNull]
        public string wonBy { get; set; }

    }
}
