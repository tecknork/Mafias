using DataLayer.DataLayerModels;
using MongoRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
   public class GameRepository: MongoRepository<Game>
    {
        public Game AddNewGame(Game game)
        {
          return this.Add(game);

        }

    }
}
