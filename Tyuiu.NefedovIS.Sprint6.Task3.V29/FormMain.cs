using Tyuiu.NefedovIS.Sprint6.Task3.V29.Lib;
namespace Tyuiu.NefedovIS.Sprint6.Task3.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();
        int[,] matrix = new int[,]
            {
                {-2, -13,  -15,  -9,  -17},

                {13, -20,  -15,   27,  18},

                {-12, -1, -20, 13,  0},

                {15,  32,  18, -12,   -18},

                {16,  5,  3,  -5,  -8}
            };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            matrix = dataService.Calculate(matrix);
            dataGridView_NIS.ColumnCount = columns;
            dataGridView_NIS.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridView_NIS.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridView_NIS.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }
        private void buttonHelp_NIS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы СМАРТб-24-1 Нефедов Иван Сергеевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}