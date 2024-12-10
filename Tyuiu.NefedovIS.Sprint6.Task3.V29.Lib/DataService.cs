using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NefedovIS.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Сортировка строк по пятому столбцу
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    // Если значение в пятом столбце текущей строки больше, чем у следующей
                    if (matrix[j, 4] > matrix[j + 1, 4])
                    {
                        // Меняем строки местами
                        for (int k = 0; k < cols; k++)
                        {
                            int temp = matrix[j, k];
                            matrix[j, k] = matrix[j + 1, k];
                            matrix[j + 1, k] = temp;
                        }
                    }
                }
            }

            return matrix;
        }
    }
}
