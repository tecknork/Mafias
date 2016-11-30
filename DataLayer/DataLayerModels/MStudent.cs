using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DataLayerModels
{
   public class MStudent : Entity
    {
        public int StudentID { get; set; }
        public string RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

    }
}
