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
        //public string id { get; set; }

        public string serverName { get; set; }

        public List<MafiaUser> users { get; set; }

        public List<Rounds> rounds { get; set; }


        public string wonBy { get; set; }

    }
}
