using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NefedovIS.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {

        public string CollectTextFromFile(string path)
        {
            string result = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string? line;
                string[] fragments;
                while ((line = reader.ReadLine()) != null)
                {
                    fragments = line.Split(' ');
                    result += fragments[0] + " ";
                }
            }
            result = result.Trim();
            return result;
        }
    }
}