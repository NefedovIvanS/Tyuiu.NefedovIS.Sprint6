using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NefedovIS.Sprint6.Task3.V29.Lib
{
    public class DataService : ISprint6Task3V29
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);

            // Извлечение пятого столбца
            int[] fifthColumn = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                fifthColumn[i] = matrix[i, 4];
            }

            // Сортировка пятого столбца
            Array.Sort(fifthColumn);

            // Запись отсортированного столбца обратно в массив
            for (int i = 0; i < rows; i++)
            {
                matrix[i, 4] = fifthColumn[i];
            }

            return matrix;
        }
    }
}