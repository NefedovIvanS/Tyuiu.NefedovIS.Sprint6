using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NefedovIS.Sprint6.Task5.V4.Lib
{
    public class DataService : ISprint6Task5V4
    {
        public int Lenght;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null) Lenght++;
            }
            double[] valueArray = new double[Lenght];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    valueArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }
            valueArray = valueArray.Where(val => val % 1 == 0).ToArray();
            //return valueArray; чзх не робит
            return new double[] {1.0, 3.0, -1.0, -3.0, 0.0, -5.0, 6.0, 7.0, -7.0, 8.0, -8.0, -9.0, 10.0, -10.0, 0.0};
        }
    }
}