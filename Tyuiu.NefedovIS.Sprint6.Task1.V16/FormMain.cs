using Tyuiu.NefedovIS.Sprint6.Task1.V16.Lib;
namespace Tyuiu.NefedovIS.Sprint6.Task1.V16
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
                string strLine;
                int len = dataService.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = dataService.GetMassFunction(startStep, stopStep);

                textBoxResult_NIS.Text = "";
                textBoxResult_NIS.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_NIS.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_NIS.AppendText("+----------+----------+" + Environment.NewLine);
                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     | {1,6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_NIS.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_NIS.AppendText("+----------+----------+" + Environment.NewLine);

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
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-24-1 Нефедов Иван Сергеевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
