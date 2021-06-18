using Microsoft.VisualStudio.TestTools.UnitTesting;
using RoboticSpider.Model;
using RoboticSpider.Enums;

namespace UnitTestSpider
{
    [TestClass]
    public class UnitTestSpider
    {
        [TestMethod]
        public void TestRightInput()
        {
            var spider = new Spider(7, 15, 4, 10, SpiderDirection.Left);
            SpiderMove[]  moves = new SpiderMove[] { SpiderMove.F, SpiderMove.L, SpiderMove.F, SpiderMove.L, SpiderMove.F, SpiderMove.R, SpiderMove.F, SpiderMove.F, SpiderMove.L, SpiderMove.F };
            spider.SetMove(moves);

            Assert.AreEqual(5, spider.CurrX, "CurrX doen not match");
            Assert.AreEqual(7, spider.CurrY, "CurrX doen not match");
            Assert.AreEqual(SpiderDirection.Right, spider.Direction, "Direction doen not match");

        }
    }
}
