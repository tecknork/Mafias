using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayerModels
{
  public class MafiaUser
    {
        [BsonElement("_id")]
        public int mafiaUserId { get; set; }

        public string userName { get; set; }

        public string role { get; set; }


    }
}
