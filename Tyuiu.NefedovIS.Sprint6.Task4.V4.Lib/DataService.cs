using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.NefedovIS.Sprint6.Task4.V4.Lib
{
    public class DataService : ISprint6Task4V4
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray = new double[stopValue - startValue + 1];
            int index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                valueArray[index] = Math.Round((2 * i + 6) / (Math.Cos(i) + i) - 3, 2);
                index++;
            }
            return valueArray;
        }
    }
}
