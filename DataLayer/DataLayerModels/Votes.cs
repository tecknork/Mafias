using MongoDB.Bson.Serialization.Attributes;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayerModels
{
    public class Votes : Entity
    {
       
      
        public int userVotingID { get; set; }
        public int userVotedForID { get; set; }
        public int result { get; set; }

    }
}
