namespace Tyuiu.NefedovIS.Sprint6.Task5.V4
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart_NIS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            buttonOpen_NIS = new Button();
            buttonHelp_NIS = new Button();
            groupBoxTask_NIS = new GroupBox();
            textBoxTask_NIS = new TextBox();
            buttonDone_NIS = new Button();
            panel2 = new Panel();
            groupBoxOutPut_NIS = new GroupBox();
            dataGridView_NIS = new DataGridView();
            panel3 = new Panel();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)chart_NIS).BeginInit();
            panel1.SuspendLayout();
            groupBoxTask_NIS.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutPut_NIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NIS).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // chart_NIS
            // 
            chartArea1.Name = "ChartArea1";
            chart_NIS.ChartAreas.Add(chartArea1);
            chart_NIS.Location = new Point(9, 11);
            chart_NIS.Name = "chart_NIS";
            chart_NIS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart_NIS.Series.Add(series1);
            chart_NIS.Size = new Size(612, 295);
            chart_NIS.TabIndex = 0;
            chart_NIS.Text = "chart1";
            chart_NIS.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonOpen_NIS);
            panel1.Controls.Add(buttonHelp_NIS);
            panel1.Controls.Add(groupBoxTask_NIS);
            panel1.Controls.Add(buttonDone_NIS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 100);
            panel1.TabIndex = 1;
            // 
            // buttonOpen_NIS
            // 
            buttonOpen_NIS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_NIS.BackColor = SystemColors.HotTrack;
            buttonOpen_NIS.Location = new Point(655, 12);
            buttonOpen_NIS.Name = "buttonOpen_NIS";
            buttonOpen_NIS.Size = new Size(81, 82);
            buttonOpen_NIS.TabIndex = 11;
            buttonOpen_NIS.Text = "Открыть файл";
            buttonOpen_NIS.UseVisualStyleBackColor = false;
            buttonOpen_NIS.Click += buttonOpen_Click;
            // 
            // buttonHelp_NIS
            // 
            buttonHelp_NIS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_NIS.BackColor = SystemColors.MenuHighlight;
            buttonHelp_NIS.Location = new Point(742, 12);
            buttonHelp_NIS.Name = "buttonHelp_NIS";
            buttonHelp_NIS.Size = new Size(66, 82);
            buttonHelp_NIS.TabIndex = 10;
            buttonHelp_NIS.Text = "Справка";
            buttonHelp_NIS.UseVisualStyleBackColor = false;
            buttonHelp_NIS.Click += buttonHelp_Click;
            // 
            // groupBoxTask_NIS
            // 
            groupBoxTask_NIS.Controls.Add(textBoxTask_NIS);
            groupBoxTask_NIS.Location = new Point(3, 3);
            groupBoxTask_NIS.Name = "groupBoxTask_NIS";
            groupBoxTask_NIS.Padding = new Padding(5);
            groupBoxTask_NIS.Size = new Size(539, 91);
            groupBoxTask_NIS.TabIndex = 0;
            groupBoxTask_NIS.TabStop = false;
            groupBoxTask_NIS.Text = "Условие:";
            // 
            // textBoxTask_NIS
            // 
            textBoxTask_NIS.BackColor = Color.White;
            textBoxTask_NIS.BorderStyle = BorderStyle.None;
            textBoxTask_NIS.Dock = DockStyle.Fill;
            textBoxTask_NIS.Location = new Point(5, 21);
            textBoxTask_NIS.Multiline = true;
            textBoxTask_NIS.Name = "textBoxTask_NIS";
            textBoxTask_NIS.ReadOnly = true;
            textBoxTask_NIS.Size = new Size(529, 65);
            textBoxTask_NIS.TabIndex = 0;
            textBoxTask_NIS.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести все целые числа.\r\n\r\n\r\n";
            textBoxTask_NIS.TextChanged += textBoxTask_NIS_TextChanged;
            // 
            // buttonDone_NIS
            // 
            buttonDone_NIS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_NIS.BackColor = Color.Green;
            buttonDone_NIS.Location = new Point(548, 12);
            buttonDone_NIS.Name = "buttonDone_NIS";
            buttonDone_NIS.Size = new Size(101, 82);
            buttonDone_NIS.TabIndex = 9;
            buttonDone_NIS.Text = "Выполнить";
            buttonDone_NIS.UseVisualStyleBackColor = false;
            buttonDone_NIS.Click += buttonDone_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(groupBoxOutPut_NIS);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 311);
            panel2.TabIndex = 2;
            // 
            // groupBoxOutPut_NIS
            // 
            groupBoxOutPut_NIS.BackColor = Color.White;
            groupBoxOutPut_NIS.Controls.Add(dataGridView_NIS);
            groupBoxOutPut_NIS.Dock = DockStyle.Fill;
            groupBoxOutPut_NIS.Location = new Point(0, 0);
            groupBoxOutPut_NIS.Name = "groupBoxOutPut_NIS";
            groupBoxOutPut_NIS.Padding = new Padding(5);
            groupBoxOutPut_NIS.Size = new Size(200, 311);
            groupBoxOutPut_NIS.TabIndex = 0;
            groupBoxOutPut_NIS.TabStop = false;
            groupBoxOutPut_NIS.Text = "Вывод данных:";
            // 
            // dataGridView_NIS
            // 
            dataGridView_NIS.AllowUserToAddRows = false;
            dataGridView_NIS.AllowUserToDeleteRows = false;
            dataGridView_NIS.AllowUserToResizeColumns = false;
            dataGridView_NIS.AllowUserToResizeRows = false;
            dataGridView_NIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_NIS.ColumnHeadersVisible = false;
            dataGridView_NIS.Dock = DockStyle.Fill;
            dataGridView_NIS.Location = new Point(5, 21);
            dataGridView_NIS.Name = "dataGridView_NIS";
            dataGridView_NIS.ReadOnly = true;
            dataGridView_NIS.RowHeadersVisible = false;
            dataGridView_NIS.Size = new Size(190, 285);
            dataGridView_NIS.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(chart_NIS);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(624, 311);
            panel3.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 311);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(840, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 4 | Нефедов И.С. ";
            ((System.ComponentModel.ISupportInitialize)chart_NIS).EndInit();
            panel1.ResumeLayout(false);
            groupBoxTask_NIS.ResumeLayout(false);
            groupBoxTask_NIS.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutPut_NIS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_NIS).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_NIS;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask_NIS;
        private GroupBox groupBoxOutPut_NIS;
        private TextBox textBoxTask_NIS;
        private Button buttonHelp_NIS;
        private Button buttonDone_NIS;
        private Button buttonOpen_NIS;
        private DataGridView dataGridView_NIS;
    }
}