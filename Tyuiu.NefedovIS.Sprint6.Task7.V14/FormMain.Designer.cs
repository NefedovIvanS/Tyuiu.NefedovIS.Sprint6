namespace Tyuiu.NefedovIS.Sprint6.Task7.V14
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_NIS = new Panel();
            buttonSaveFile_NIS = new Button();
            buttonAbout_NIS = new Button();
            buttonHelp_NIS = new Button();
            buttonDone_NIS = new Button();
            buttonOpenFile_NIS = new Button();
            panel2 = new Panel();
            groupBoxTask_NIS = new GroupBox();
            textBoxTask_NIS = new TextBox();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBoxInPut_NIS = new GroupBox();
            dataGridViewInPut_NIS = new DataGridView();
            groupBoxOutPut_NIS = new GroupBox();
            dataGridViewOutPut_NIS = new DataGridView();
            toolTip_NIS = new ToolTip(components);
            openFileDialog_NIS = new OpenFileDialog();
            saveFileDialog_NIS = new SaveFileDialog();
            panelButtons_NIS.SuspendLayout();
            groupBoxTask_NIS.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxInPut_NIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_NIS).BeginInit();
            groupBoxOutPut_NIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_NIS).BeginInit();
            SuspendLayout();
            // 
            // panelButtons_NIS
            // 
            panelButtons_NIS.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_NIS.Controls.Add(buttonSaveFile_NIS);
            panelButtons_NIS.Controls.Add(buttonAbout_NIS);
            panelButtons_NIS.Controls.Add(buttonHelp_NIS);
            panelButtons_NIS.Controls.Add(buttonDone_NIS);
            panelButtons_NIS.Controls.Add(buttonOpenFile_NIS);
            panelButtons_NIS.Controls.Add(panel2);
            panelButtons_NIS.Dock = DockStyle.Top;
            panelButtons_NIS.Location = new Point(0, 0);
            panelButtons_NIS.Name = "panelButtons_NIS";
            panelButtons_NIS.Size = new Size(800, 72);
            panelButtons_NIS.TabIndex = 1;
            // 
            // buttonSaveFile_NIS
            // 
            buttonSaveFile_NIS.BackColor = Color.Transparent;
            buttonSaveFile_NIS.BackgroundImage = (Image)resources.GetObject("buttonSaveFile_NIS.BackgroundImage");
            buttonSaveFile_NIS.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_NIS.Enabled = false;
            buttonSaveFile_NIS.Location = new Point(171, 3);
            buttonSaveFile_NIS.Name = "buttonSaveFile_NIS";
            buttonSaveFile_NIS.Size = new Size(78, 62);
            buttonSaveFile_NIS.TabIndex = 6;
            toolTip_NIS.SetToolTip(buttonSaveFile_NIS, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_NIS.UseVisualStyleBackColor = false;
            buttonSaveFile_NIS.Click += buttonSaveFile_NIS_Click;
            buttonSaveFile_NIS.MouseEnter += buttonSaveFile_NIS_MouseEnter;
            // 
            // buttonAbout_NIS
            // 
            buttonAbout_NIS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_NIS.BackColor = Color.Transparent;
            buttonAbout_NIS.BackgroundImage = (Image)resources.GetObject("buttonAbout_NIS.BackgroundImage");
            buttonAbout_NIS.BackgroundImageLayout = ImageLayout.Center;
            buttonAbout_NIS.Location = new Point(715, 3);
            buttonAbout_NIS.Name = "buttonAbout_NIS";
            buttonAbout_NIS.Size = new Size(78, 62);
            buttonAbout_NIS.TabIndex = 5;
            buttonAbout_NIS.UseVisualStyleBackColor = false;
            buttonAbout_NIS.Click += buttonAbout_NIS_Click;
            // 
            // buttonHelp_NIS
            // 
            buttonHelp_NIS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_NIS.BackColor = Color.Transparent;
            buttonHelp_NIS.BackgroundImage = (Image)resources.GetObject("buttonHelp_NIS.BackgroundImage");
            buttonHelp_NIS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_NIS.Location = new Point(1311, 3);
            buttonHelp_NIS.Name = "buttonHelp_NIS";
            buttonHelp_NIS.Size = new Size(78, 62);
            buttonHelp_NIS.TabIndex = 4;
            buttonHelp_NIS.UseVisualStyleBackColor = false;
            // 
            // buttonDone_NIS
            // 
            buttonDone_NIS.BackColor = Color.Transparent;
            buttonDone_NIS.BackgroundImage = (Image)resources.GetObject("buttonDone_NIS.BackgroundImage");
            buttonDone_NIS.BackgroundImageLayout = ImageLayout.Center;
            buttonDone_NIS.Enabled = false;
            buttonDone_NIS.Location = new Point(87, 3);
            buttonDone_NIS.Name = "buttonDone_NIS";
            buttonDone_NIS.Size = new Size(78, 62);
            buttonDone_NIS.TabIndex = 3;
            toolTip_NIS.SetToolTip(buttonDone_NIS, "Выполнить обработку данных");
            buttonDone_NIS.UseVisualStyleBackColor = false;
            buttonDone_NIS.Click += buttonDone_NIS_Click;
            buttonDone_NIS.MouseEnter += buttonDone_NIS_MouseEnter;
            // 
            // buttonOpenFile_NIS
            // 
            buttonOpenFile_NIS.BackColor = Color.Transparent;
            buttonOpenFile_NIS.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_NIS.BackgroundImage");
            buttonOpenFile_NIS.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_NIS.Location = new Point(3, 3);
            buttonOpenFile_NIS.Name = "buttonOpenFile_NIS";
            buttonOpenFile_NIS.Size = new Size(78, 62);
            buttonOpenFile_NIS.TabIndex = 2;
            toolTip_NIS.SetToolTip(buttonOpenFile_NIS, "Открыть файл для обработки данных в формате CSV\r\n");
            buttonOpenFile_NIS.UseVisualStyleBackColor = false;
            buttonOpenFile_NIS.Click += buttonOpenFile_NIS_Click;
            buttonOpenFile_NIS.MouseEnter += buttonOpenFile_NIS_MouseEnter;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 76);
            panel2.TabIndex = 1;
            // 
            // groupBoxTask_NIS
            // 
            groupBoxTask_NIS.Controls.Add(textBoxTask_NIS);
            groupBoxTask_NIS.Dock = DockStyle.Fill;
            groupBoxTask_NIS.Location = new Point(5, 5);
            groupBoxTask_NIS.Name = "groupBoxTask_NIS";
            groupBoxTask_NIS.RightToLeft = RightToLeft.No;
            groupBoxTask_NIS.Size = new Size(790, 107);
            groupBoxTask_NIS.TabIndex = 2;
            groupBoxTask_NIS.TabStop = false;
            groupBoxTask_NIS.Text = "Условие:";
            // 
            // textBoxTask_NIS
            // 
            textBoxTask_NIS.BorderStyle = BorderStyle.None;
            textBoxTask_NIS.Dock = DockStyle.Fill;
            textBoxTask_NIS.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_NIS.Location = new Point(3, 19);
            textBoxTask_NIS.Multiline = true;
            textBoxTask_NIS.Name = "textBoxTask_NIS";
            textBoxTask_NIS.ReadOnly = true;
            textBoxTask_NIS.Size = new Size(784, 85);
            textBoxTask_NIS.TabIndex = 0;
            textBoxTask_NIS.Text = resources.GetString("textBoxTask_NIS.Text");
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBoxTask_NIS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 72);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(800, 117);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(groupBoxInPut_NIS, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBoxOutPut_NIS, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 189);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(3);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 261);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBoxInPut_NIS
            // 
            groupBoxInPut_NIS.Controls.Add(dataGridViewInPut_NIS);
            groupBoxInPut_NIS.Dock = DockStyle.Fill;
            groupBoxInPut_NIS.Location = new Point(6, 6);
            groupBoxInPut_NIS.Name = "groupBoxInPut_NIS";
            groupBoxInPut_NIS.Size = new Size(391, 249);
            groupBoxInPut_NIS.TabIndex = 0;
            groupBoxInPut_NIS.TabStop = false;
            groupBoxInPut_NIS.Text = "Ввод:";
            // 
            // dataGridViewInPut_NIS
            // 
            dataGridViewInPut_NIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_NIS.ColumnHeadersVisible = false;
            dataGridViewInPut_NIS.Dock = DockStyle.Fill;
            dataGridViewInPut_NIS.Location = new Point(3, 19);
            dataGridViewInPut_NIS.Name = "dataGridViewInPut_NIS";
            dataGridViewInPut_NIS.RowHeadersVisible = false;
            dataGridViewInPut_NIS.Size = new Size(385, 227);
            dataGridViewInPut_NIS.TabIndex = 0;
            // 
            // groupBoxOutPut_NIS
            // 
            groupBoxOutPut_NIS.Controls.Add(dataGridViewOutPut_NIS);
            groupBoxOutPut_NIS.Dock = DockStyle.Fill;
            groupBoxOutPut_NIS.Location = new Point(403, 6);
            groupBoxOutPut_NIS.Name = "groupBoxOutPut_NIS";
            groupBoxOutPut_NIS.Size = new Size(391, 249);
            groupBoxOutPut_NIS.TabIndex = 1;
            groupBoxOutPut_NIS.TabStop = false;
            groupBoxOutPut_NIS.Text = "Вывод:";
            // 
            // dataGridViewOutPut_NIS
            // 
            dataGridViewOutPut_NIS.AllowUserToResizeRows = false;
            dataGridViewOutPut_NIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_NIS.ColumnHeadersVisible = false;
            dataGridViewOutPut_NIS.Dock = DockStyle.Fill;
            dataGridViewOutPut_NIS.Location = new Point(3, 19);
            dataGridViewOutPut_NIS.Name = "dataGridViewOutPut_NIS";
            dataGridViewOutPut_NIS.RowHeadersVisible = false;
            dataGridViewOutPut_NIS.Size = new Size(385, 227);
            dataGridViewOutPut_NIS.TabIndex = 0;
            // 
            // toolTip_NIS
            // 
            toolTip_NIS.IsBalloon = true;
            // 
            // openFileDialog_NIS
            // 
            openFileDialog_NIS.FileName = "file.csv";
            // 
            // saveFileDialog_NIS
            // 
            saveFileDialog_NIS.FileName = "file.csv";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(panelButtons_NIS);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 7 | Вариант 14 | Нефедов И.С. ";
            panelButtons_NIS.ResumeLayout(false);
            groupBoxTask_NIS.ResumeLayout(false);
            groupBoxTask_NIS.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxInPut_NIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_NIS).EndInit();
            groupBoxOutPut_NIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_NIS).EndInit();
            ResumeLayout(false);
        }


        private Panel panelButtons_NIS;
        private Button buttonHelp_NIS;
        private Button buttonDone_NIS;
        private Button buttonOpenFile_NIS;
        private Panel panel2;
        private Button buttonAbout_NIS;
        private GroupBox groupBoxTask_NIS;
        private TextBox textBoxTask_NIS;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxInPut_NIS;
        private DataGridView dataGridViewInPut_NIS;
        private GroupBox groupBoxOutPut_NIS;
        private DataGridView dataGridViewOutPut_NIS;
        private Button buttonSaveFile_NIS;
        private ToolTip toolTip_NIS;
        private OpenFileDialog openFileDialog_NIS;
        private SaveFileDialog saveFileDialog_NIS;
    }
}