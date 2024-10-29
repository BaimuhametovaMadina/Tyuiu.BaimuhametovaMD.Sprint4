using Tyuiu.BaimuhametovaMD.Sprint4.Task7.V2.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            string v = "597643158942";
            int n = 3, m = 4;
            DataService ds = new DataService();
            int res = 5 + 9 + 7 + 3 + 1 + 5 + 9;
            Assert.AreEqual(res, ds.Calculate(n, m, v));
        }
    }
}