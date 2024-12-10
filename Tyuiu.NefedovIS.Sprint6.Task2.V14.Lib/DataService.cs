using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NefedovIS.Sprint6.Task2.V14.Lib
{
    public class DataService : ISprint6Task2V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values = new double[stopValue - startValue + 1];
            int index = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                values[index] = Math.Round(5 - 3*i + (1+Math.Sin(i))/(2*i - 0.5), 2);
                index++;
            }
            return values;
        }
    }
}
