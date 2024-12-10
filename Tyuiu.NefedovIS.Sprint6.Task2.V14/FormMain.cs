using Tyuiu.NefedovIS.Sprint6.Task2.V14.Lib;
namespace Tyuiu.NefedovIS.Sprint6.Task2.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_NIS.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_NIS.Text);

                int len = dataService.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = dataService.GetMassFunction(startStep, stopStep);
                chartResult_NIS.Titles.Add("5 - 3*i + (1+Math.Sin(i))/(2*i - 0.5)");

                chartResult_NIS.ChartAreas[0].AxisX.Title = "Ось X";
                chartResult_NIS.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    dataGridView_NIS.Rows.Add(Convert.ToString(startStep), valueArray[i]);
                    chartResult_NIS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxSteps_NIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_NIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы СМАРТб-24-1 Нефедов Иван Сергеевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBoxTask_NIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
