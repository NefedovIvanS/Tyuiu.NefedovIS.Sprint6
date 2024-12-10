using Tyuiu.NefedovIS.Sprint6.Task4.V4.Lib;
namespace Tyuiu.NefedovIS.Sprint6.Task4.V4
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

                double[] valueArray = dataService.GetMassFunction(startStep, stopStep);
                chart_NIS.ChartAreas[0].AxisX.Title = "Ось X";
                chart_NIS.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_NIS.Text = "";
                for (int i = 0; i < valueArray.Length; i++)
                {
                    chart_NIS.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_NIS.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы СМАРТб-24-1 Нефедов Иван Сергеевич", "Сообщение", MessageBoxButtons.OK);
        }
        private void buttonSave_Click(Object sender, EventArgs e)
        {
            try
            {
                string[] paths = { Path.GetTempPath(), Path.GetTempFileName() };
                string path = Path.Combine(paths);
                File.WriteAllText(path, textBoxResult_NIS.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранён успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxTask_NIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void chart_NIS_Click(object sender, EventArgs e)
        {

        }
    }
}