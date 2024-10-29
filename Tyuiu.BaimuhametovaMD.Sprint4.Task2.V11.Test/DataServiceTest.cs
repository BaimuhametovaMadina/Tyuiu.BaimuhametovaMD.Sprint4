using Tyuiu.BaimuhametovaMD.Sprint4.Task2.V11.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int[] array = { 7, 8, 3, 4, 5, 6, 7, 8, 7, 8, 3, 4, 5, 6, 7 };
            int res = ds.Calculate(array);
            Assert.AreEqual(res, 44);
        }
    }
}