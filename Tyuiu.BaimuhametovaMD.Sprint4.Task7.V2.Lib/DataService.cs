using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.BaimuhametovaMD.Sprint4.Task7.V2.Lib
{
    public class DataService: ISprint4Task7V2
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n,m];
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[3 * i + j + i].ToString());
                    if (matrix[i, j] % 2 != 0) c += matrix[i, j];
                }
            }
            return c;
        }
    }
}
