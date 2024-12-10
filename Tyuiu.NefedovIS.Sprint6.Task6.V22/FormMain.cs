using Tyuiu.NefedovIS.Sprint6.Task6.V22.Lib;
namespace Tyuiu.NefedovIS.Sprint6.Task6.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxOutput_NIS.ScrollBars = ScrollBars.Vertical;
            textBoxInput_NIS.ScrollBars = ScrollBars.Vertical;
        }
        string openFilePath;
        DataService dataService = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput_NIS.Text = dataService.CollectTextFromFile(openFilePath);
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog_NIS.ShowDialog();
            openFilePath = openFileDialog_NIS.FileName;
            try
            {
                textBoxInput_NIS.Text = File.ReadAllText(openFilePath);
                groupBoxInput_NIS.Text = groupBoxInput_NIS.Text + " " + openFileDialog_NIS.FileName;
                buttonDone_NIS.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}