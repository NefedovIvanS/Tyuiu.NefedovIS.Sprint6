using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NefedovIS.Sprint6.Task1.V16.Lib
{
    public class DataService : ISprint6Task1V16
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values = new double[stopValue - startValue + 1];
            int index = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                if (Math.Cos(i) - 2 * i == 0)
                {
                    values[index] = 0;
                    index++;
                    continue;
                }
                values[index] = Math.Round((Math.Sin(i)/(i + 1.2) + Math.Cos(i) * 7*i - 2), 2);
                index++;
            }
            return values;
        }
    }
}