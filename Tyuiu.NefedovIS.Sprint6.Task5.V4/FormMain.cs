using Tyuiu.NefedovIS.Sprint6.Task5.V4.Lib;
namespace Tyuiu.NefedovIS.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();
        string path = Path.Combine(@"C:\Users\cumsh\source\repos\Tyuiu.NefedovIS.Sprint6\Tyuiu.NefedovIS.Sprint6.Task5.V4\bin\Debug\net8.0-windows\InPutDataFileTask5V4.txt");

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridView_NIS.ColumnCount = 2;
            dataGridView_NIS.Columns[0].Width = 20;
            dataGridView_NIS.Columns[1].Width = 50;

            chart_NIS.ChartAreas[0].AxisX.Title = "Ось X";
            chart_NIS.ChartAreas[0].AxisY.Title = "Ось Y";
            chart_NIS.Series[0].Points.Clear();

            double[] valueArray = new double[dataService.Lenght];

            valueArray = dataService.LoadFromDataFile(path);

            for (int i = 0; i < valueArray.Length; i++)
            {
                dataGridView_NIS.Rows.Add(Convert.ToString(i), Convert.ToString(valueArray[i]));
                chart_NIS.Series[0].Points.AddXY(i, valueArray[i]);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы СМАРТб-24-1 Нефедов Иван Сергеевич", "Сообщение", MessageBoxButtons.OK);
        }
        private void buttonOpen_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxTask_NIS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}