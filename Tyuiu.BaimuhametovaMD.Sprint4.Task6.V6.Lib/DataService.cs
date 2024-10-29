using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task6.V6.Lib
{
    public class DataService: ISprint4Task6V6
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, s => s.Length == 5);
            return result;
        }
    }
}
