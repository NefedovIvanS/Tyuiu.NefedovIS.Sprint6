using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NefedovIS.Sprint6.Task0.V15.Lib
{
    public class DataService : ISprint6Task0V15
    {
        public double Calculate(int x)
        {
            return Math.Round(Math.Pow((double)x, 3) +
                2 * Math.Pow((double)x, 2) +
                5 * x + 4, 3);
        }
    }
}
