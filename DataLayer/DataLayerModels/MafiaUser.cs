using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoRepository;

namespace DataLayer.DataLayerModels
{
  public class MafiaUser :Entity 

    {
        //[BsonElement("_id")]
        //public int mafiaUserId { get; set; }

        public string userName { get; set; }

        public string role { get; set; }

        public string ip { get; set;}

        public string devicetype { get; set; }
    }
}
