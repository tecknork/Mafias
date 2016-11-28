using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;
using DataLayer.DataLayerModels;
using DataLayer.Repository;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        static GameRepository customerrepo = new GameRepository();
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void CreateGameServer()
        {
            Game game = new Game();
            game.serverid = 12312313;
            game.serverName = "asdasd";

            Game returnobject=customerrepo.AddNewGame(game);

            var FindObject = customerrepo.GetById(game.Id);

            Assert.IsNotNull(returnobject);
            Assert.IsNotNull(FindObject);
            Assert.AreEqual(returnobject.serverid, FindObject.serverid);


            //   var returnObject= customerrepo.GetById()

        }
    }
}
