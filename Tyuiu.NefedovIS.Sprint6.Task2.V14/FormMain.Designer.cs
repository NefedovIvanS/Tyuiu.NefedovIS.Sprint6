namespace Tyuiu.NefedovIS.Sprint6.Task2.V14
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
            chartResult_NIS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            textBoxTask_NIS = new TextBox();
            groupBoxTask_NIS = new GroupBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBoxStopStep_NIS = new TextBox();
            textBoxStartStep_NIS = new TextBox();
            buttonHelp_NIS = new Button();
            buttonDone_NIS = new Button();
            groupBox2 = new GroupBox();
            label1 = new Label();
            dataGridView_NIS = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)chartResult_NIS).BeginInit();
            groupBoxTask_NIS.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NIS).BeginInit();
            SuspendLayout();
            // 
            // chartResult_NIS
            // 
            chartArea1.Name = "ChartArea1";
            chartResult_NIS.ChartAreas.Add(chartArea1);
            chartResult_NIS.Cursor = Cursors.SizeNWSE;
            chartResult_NIS.Location = new Point(131, 19);
            chartResult_NIS.Name = "chartResult_NIS";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartResult_NIS.Series.Add(series1);
            chartResult_NIS.Size = new Size(415, 314);
            chartResult_NIS.TabIndex = 0;
            chartResult_NIS.Text = "chart1";
            // 
            // textBoxTask_NIS
            // 
            textBoxTask_NIS.BorderStyle = BorderStyle.None;
            textBoxTask_NIS.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_NIS.Location = new Point(11, 19);
            textBoxTask_NIS.Multiline = true;
            textBoxTask_NIS.Name = "textBoxTask_NIS";
            textBoxTask_NIS.ReadOnly = true;
            textBoxTask_NIS.Size = new Size(468, 127);
            textBoxTask_NIS.TabIndex = 0;
            textBoxTask_NIS.Text = "Протабулировать функцию sin(x) + cos(2x)/2 - 1,5x на заданном диапозоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            textBoxTask_NIS.TextChanged += textBoxTask_NIS_TextChanged;
            // 
            // groupBoxTask_NIS
            // 
            groupBoxTask_NIS.Controls.Add(textBoxTask_NIS);
            groupBoxTask_NIS.Location = new Point(12, 12);
            groupBoxTask_NIS.Name = "groupBoxTask_NIS";
            groupBoxTask_NIS.Size = new Size(513, 241);
            groupBoxTask_NIS.TabIndex = 2;
            groupBoxTask_NIS.TabStop = false;
            groupBoxTask_NIS.Text = "Условие";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxStopStep_NIS);
            groupBox1.Controls.Add(textBoxStartStep_NIS);
            groupBox1.Location = new Point(12, 259);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(301, 92);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 39);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 9;
            label2.Text = "Конец шага:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 39);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Старт шага:";
            // 
            // textBoxStopStep_NIS
            // 
            textBoxStopStep_NIS.Location = new Point(145, 57);
            textBoxStopStep_NIS.Name = "textBoxStopStep_NIS";
            textBoxStopStep_NIS.Size = new Size(128, 23);
            textBoxStopStep_NIS.TabIndex = 8;
            textBoxStopStep_NIS.KeyPress += textBoxSteps_NIS_KeyPress;
            // 
            // textBoxStartStep_NIS
            // 
            textBoxStartStep_NIS.Location = new Point(11, 57);
            textBoxStartStep_NIS.Name = "textBoxStartStep_NIS";
            textBoxStartStep_NIS.Size = new Size(128, 23);
            textBoxStartStep_NIS.TabIndex = 6;
            textBoxStartStep_NIS.KeyPress += textBoxSteps_NIS_KeyPress;
            // 
            // buttonHelp_NIS
            // 
            buttonHelp_NIS.BackColor = SystemColors.MenuHighlight;
            buttonHelp_NIS.Location = new Point(319, 259);
            buttonHelp_NIS.Name = "buttonHelp_NIS";
            buttonHelp_NIS.Size = new Size(66, 92);
            buttonHelp_NIS.TabIndex = 8;
            buttonHelp_NIS.Text = "Справка";
            buttonHelp_NIS.UseVisualStyleBackColor = false;
            buttonHelp_NIS.Click += buttonHelp_NIS_Click;
            // 
            // buttonDone_NIS
            // 
            buttonDone_NIS.BackColor = Color.Green;
            buttonDone_NIS.Location = new Point(391, 259);
            buttonDone_NIS.Name = "buttonDone_NIS";
            buttonDone_NIS.Size = new Size(134, 92);
            buttonDone_NIS.TabIndex = 7;
            buttonDone_NIS.Text = "Выполнить";
            buttonDone_NIS.UseVisualStyleBackColor = false;
            buttonDone_NIS.Click += buttonDone_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dataGridView_NIS);
            groupBox2.Controls.Add(chartResult_NIS);
            groupBox2.Location = new Point(531, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(552, 339);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Результат";
            // 
            // dataGridView_NIS
            // 
            dataGridView_NIS.AllowUserToAddRows = false;
            dataGridView_NIS.AllowUserToDeleteRows = false;
            dataGridView_NIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_NIS.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView_NIS.Location = new Point(6, 37);
            dataGridView_NIS.Name = "dataGridView_NIS";
            dataGridView_NIS.ReadOnly = true;
            dataGridView_NIS.RowHeadersVisible = false;
            dataGridView_NIS.Size = new Size(119, 296);
            dataGridView_NIS.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "X";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 50;
            // 
            // Column2
            // 
            Column2.HeaderText = "F(X)";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 363);
            Controls.Add(groupBox2);
            Controls.Add(buttonHelp_NIS);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone_NIS);
            Controls.Add(groupBoxTask_NIS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 14 | Нефедов И.С. ";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)chartResult_NIS).EndInit();
            groupBoxTask_NIS.ResumeLayout(false);
            groupBoxTask_NIS.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NIS).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_NIS;
        private TextBox textBoxTask_NIS;
        private GroupBox groupBoxTask_NIS;
        private GroupBox groupBox1;
        private Button buttonHelp_NIS;
        private Button buttonDone_NIS;
        private GroupBox groupBox2;
        private Label label1;
        private DataGridView dataGridView_NIS;
        private Label label2;
        private Label label3;
        private TextBox textBoxStopStep_NIS;
        private TextBox textBoxStartStep_NIS;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
