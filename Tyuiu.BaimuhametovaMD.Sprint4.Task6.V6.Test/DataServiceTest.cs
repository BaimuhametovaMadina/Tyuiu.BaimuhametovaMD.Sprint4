using Tyuiu.BaimuhametovaMD.Sprint4.Task6.V6.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ResultLengthValid()
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] wait = { "Борис", "Ирина" };
            string[] res = ds.Calculate(names);
            Assert.AreEqual(2, res.Length);
        }
        [TestMethod]
        public void FirstValid()
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] wait = { "Борис", "Ирина" };
            string[] res = ds.Calculate(names);
            Assert.AreEqual(wait[0], res[0]);
        }
        [TestMethod]
        public void SecondValid()
        {
            DataService ds = new DataService();
            string[] names = new string[] { "Борис", "Анна", "Михаил", "Ирина", "Сергей", "Татьяна", "Олег" };
            string[] wait = { "Борис", "Ирина" };
            string[] res = ds.Calculate(names);
            Assert.AreEqual(wait[1], res[1]);
        }
    }
}