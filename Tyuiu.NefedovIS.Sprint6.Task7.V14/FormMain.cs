using Tyuiu.NefedovIS.Sprint6.Task7.V14.Lib;
namespace Tyuiu.NefedovIS.Sprint6.Task7.V14
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_NIS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_NIS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        DataService dataService = new DataService();
        static int rows;
        static int columns;
        static string? openFilePath;

        private void buttonOpenFile_NIS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NIS.ToolTipTitle = "";
        }

        private void buttonDone_NIS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NIS.ToolTipTitle = "";
        }

        private void buttonSaveFile_NIS_MouseEnter(object sender, EventArgs e)
        {
            toolTip_NIS.ToolTipTitle = "";
        }

        private void buttonAbout_NIS_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_NIS_Click(object sender, EventArgs e)
        {
            int[,] values = dataService.GetMatrix(openFilePath);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPut_NIS.Rows[i].Cells[j].Value = values[i, j];
                }
            }
            buttonSaveFile_NIS.Enabled = true;
        }

        private void buttonOpenFile_NIS_Click(object sender, EventArgs e)
        {
            openFileDialog_NIS.ShowDialog();
            openFilePath = openFileDialog_NIS.FileName;

            if (openFilePath != null)
            {
                int[,] arrayValues = dataService.GetStartMatrix(openFilePath);

                rows = arrayValues.GetLength(0);
                columns = arrayValues.GetLength(1);

                dataGridViewInPut_NIS.ColumnCount = columns;
                dataGridViewInPut_NIS.RowCount = rows;
                dataGridViewOutPut_NIS.ColumnCount = columns;
                dataGridViewOutPut_NIS.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInPut_NIS.Columns[i].Width = 25;
                    dataGridViewOutPut_NIS.Columns[i].Width = 25;
                }
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInPut_NIS.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }
                buttonDone_NIS.Enabled = true;
            }
        }

        private void buttonSaveFile_NIS_Click(object sender, EventArgs e)
        {
            saveFileDialog_NIS.FileName = "OutPutFileTask7.csv";
            saveFileDialog_NIS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_NIS.ShowDialog();

            string path = saveFileDialog_NIS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutPut_NIS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutPut_NIS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
