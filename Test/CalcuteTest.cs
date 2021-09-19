using Business;
using Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class CalcuteTest
    {
        Calcute Calcute;
        public CalcuteTest()
        {
             Calcute = new Calcute();
        }
        [TestMethod]
        public void Test_TurnDirection()
        {       
            string Rdirection = Calcute.TurnDirection("N",'R');
            Assert.AreEqual(Rdirection, "E");
            string Ldirection = Calcute.TurnDirection("W", 'L');
            Assert.AreEqual(Ldirection, "S");
        }
        [TestMethod]
        public void Test_RoverMove()
        {
            LocationVector LocationVector = new LocationVector()
            {
                LocationX = 1,
                LocationY = 2,
                Direction = "N"
            };
            LocationVector Correct = LocationVector;
            Correct.LocationY = 3;
            LocationVector Moved = Calcute.RoverMove(LocationVector);
            Assert.AreEqual(Moved, Correct);  
        }
        [TestMethod]
        public void Test_LocationCalcute()
        {
            LocationVector LocationVector = new LocationVector()
            {
                LocationX = 1,
                LocationY = 2,
                Direction = "N"
            };
            string Moved = Calcute.LocationCalcute(LocationVector, "LMLMLMLMM");
            Assert.AreEqual(Moved, "1 3 N");
        }

    }
}
