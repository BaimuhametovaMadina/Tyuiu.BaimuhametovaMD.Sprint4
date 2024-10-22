using Tyuiu.BaimuhametovaMD.Sprint4.Task0.V27.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int[] array = new int[] { 7, 4, 3, 2, 1, 5, 9, 8, 7, 4 };
            int res = 6615;
            Assert.AreEqual(res, ds.GetMultOddArrEl(array));
        }
    }
}