using Tyuiu.BaimuhametovaMD.Sprint4.Task5.V22.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int[,] arr = new int[,]
            {
                {1, 6, -5, -4, 9 },
                {1, -6, -5, -4, -9 },
                {-1, 6, -5, -4, 9 },
                {1, 6, -5, -4, 9 },
                {1, -6, -5, -4, 9 }
            };
            int res = ds.Calculate(arr);
            Assert.AreEqual(14, res);
        }
    }
}