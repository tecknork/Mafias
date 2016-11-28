using MongoDB.Bson.Serialization.Attributes;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayerModels
{
   public class Rounds : Entity
    {
        //[BsonElement("_id")]
        //public string roundId { get; set; }
        public int round { get; set; }
        public string type { get; set; }
        public int noOfUsers { get; set; }
        public int usersAliveBeforeRound { get; set; }
        public int userAliveAfterRound { get; set; }
        public List<Votes> votes { get; set; }


    }
}
