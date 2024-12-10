using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NefedovIS.Sprint6.Task7.V14.Lib
{
    public class DataService : ISprint6Task7V14
    {
        public int[,] GetMatrix(string path)
        {
            string[] fileData = File.ReadAllText(path).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);

            int rows = fileData.Length;
            int columns = fileData[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = fileData[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line[j]);
                }
            }
            for (int i = 1; i <= 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (arrayValues[i, j] % 2 == 0) arrayValues[i, j] = 44;
                }
            }
            return arrayValues;
        }

        public int[,] GetMatrix(int[,] matrix)
        {
            return matrix;
        }

        public int[,] GetStartMatrix(string path)
        {
            string[] fileData = File.ReadAllText(path).Replace('\n', '\r').Split('\r', StringSplitOptions.RemoveEmptyEntries);

            int rows = fileData.Length;
            int columns = fileData[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line = fileData[i].Split(";");
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line[j]);
                }
            }
            return arrayValues;
        }
    }
}

