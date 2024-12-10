namespace Tyuiu.NefedovIS.Sprint6.Task4.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chart_NIS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            buttonSave_NIS = new Button();
            buttonHelp_NIS = new Button();
            groupBoxInput_NIS = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBoxStopStep_NIS = new TextBox();
            textBoxStartStep_NIS = new TextBox();
            groupBoxTask_NIS = new GroupBox();
            textBoxTask_NIS = new TextBox();
            buttonDone_NIS = new Button();
            panel2 = new Panel();
            groupBoxOutPut_NIS = new GroupBox();
            textBoxResult_NIS = new TextBox();
            panel3 = new Panel();
            label1 = new Label();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)chart_NIS).BeginInit();
            panel1.SuspendLayout();
            groupBoxInput_NIS.SuspendLayout();
            groupBoxTask_NIS.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutPut_NIS.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // chart_NIS
            // 
            chartArea1.Name = "ChartArea1";
            chart_NIS.ChartAreas.Add(chartArea1);
            chart_NIS.Location = new Point(9, 11);
            chart_NIS.Name = "chart_NIS";
            chart_NIS.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chart_NIS.Series.Add(series1);
            chart_NIS.Size = new Size(710, 295);
            chart_NIS.TabIndex = 0;
            chart_NIS.Text = "chart1";
            chart_NIS.UseWaitCursor = true;
            chart_NIS.Click += chart_NIS_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonSave_NIS);
            panel1.Controls.Add(buttonHelp_NIS);
            panel1.Controls.Add(groupBoxInput_NIS);
            panel1.Controls.Add(groupBoxTask_NIS);
            panel1.Controls.Add(buttonDone_NIS);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 100);
            panel1.TabIndex = 1;
            // 
            // buttonSave_NIS
            // 
            buttonSave_NIS.BackColor = SystemColors.HotTrack;
            buttonSave_NIS.Location = new Point(770, 12);
            buttonSave_NIS.Name = "buttonSave_NIS";
            buttonSave_NIS.Size = new Size(81, 82);
            buttonSave_NIS.TabIndex = 11;
            buttonSave_NIS.Text = "Сохранить";
            buttonSave_NIS.UseVisualStyleBackColor = false;
            buttonSave_NIS.Click += buttonSave_Click;
            // 
            // buttonHelp_NIS
            // 
            buttonHelp_NIS.BackColor = SystemColors.MenuHighlight;
            buttonHelp_NIS.Location = new Point(857, 12);
            buttonHelp_NIS.Name = "buttonHelp_NIS";
            buttonHelp_NIS.Size = new Size(66, 82);
            buttonHelp_NIS.TabIndex = 10;
            buttonHelp_NIS.Text = "Справка";
            buttonHelp_NIS.UseVisualStyleBackColor = false;
            buttonHelp_NIS.Click += buttonHelp_Click;
            // 
            // groupBoxInput_NIS
            // 
            groupBoxInput_NIS.Controls.Add(label2);
            groupBoxInput_NIS.Controls.Add(label3);
            groupBoxInput_NIS.Controls.Add(textBoxStopStep_NIS);
            groupBoxInput_NIS.Controls.Add(textBoxStartStep_NIS);
            groupBoxInput_NIS.Location = new Point(370, 3);
            groupBoxInput_NIS.Name = "groupBoxInput_NIS";
            groupBoxInput_NIS.Size = new Size(287, 91);
            groupBoxInput_NIS.TabIndex = 1;
            groupBoxInput_NIS.TabStop = false;
            groupBoxInput_NIS.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 25);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 13;
            label2.Text = "Конец шага:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 11;
            label3.Text = "Старт шага:";
            // 
            // textBoxStopStep_NIS
            // 
            textBoxStopStep_NIS.Location = new Point(146, 43);
            textBoxStopStep_NIS.Name = "textBoxStopStep_NIS";
            textBoxStopStep_NIS.Size = new Size(128, 23);
            textBoxStopStep_NIS.TabIndex = 12;
            // 
            // textBoxStartStep_NIS
            // 
            textBoxStartStep_NIS.Location = new Point(12, 43);
            textBoxStartStep_NIS.Name = "textBoxStartStep_NIS";
            textBoxStartStep_NIS.Size = new Size(128, 23);
            textBoxStartStep_NIS.TabIndex = 10;
            // 
            // groupBoxTask_NIS
            // 
            groupBoxTask_NIS.Controls.Add(textBoxTask_NIS);
            groupBoxTask_NIS.Location = new Point(3, 3);
            groupBoxTask_NIS.Name = "groupBoxTask_NIS";
            groupBoxTask_NIS.Padding = new Padding(5);
            groupBoxTask_NIS.Size = new Size(361, 91);
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
            textBoxTask_NIS.Size = new Size(351, 65);
            textBoxTask_NIS.TabIndex = 0;
            textBoxTask_NIS.TextChanged += textBoxTask_NIS_TextChanged;
            // 
            // buttonDone_NIS
            // 
            buttonDone_NIS.BackColor = Color.Green;
            buttonDone_NIS.Location = new Point(663, 12);
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
            groupBoxOutPut_NIS.Controls.Add(textBoxResult_NIS);
            groupBoxOutPut_NIS.Dock = DockStyle.Fill;
            groupBoxOutPut_NIS.Location = new Point(0, 0);
            groupBoxOutPut_NIS.Name = "groupBoxOutPut_NIS";
            groupBoxOutPut_NIS.Padding = new Padding(5);
            groupBoxOutPut_NIS.Size = new Size(200, 311);
            groupBoxOutPut_NIS.TabIndex = 0;
            groupBoxOutPut_NIS.TabStop = false;
            groupBoxOutPut_NIS.Text = "Вывод:";
            // 
            // textBoxResult_NIS
            // 
            textBoxResult_NIS.BackColor = Color.White;
            textBoxResult_NIS.BorderStyle = BorderStyle.None;
            textBoxResult_NIS.Dock = DockStyle.Fill;
            textBoxResult_NIS.Location = new Point(5, 21);
            textBoxResult_NIS.Multiline = true;
            textBoxResult_NIS.Name = "textBoxResult_NIS";
            textBoxResult_NIS.ReadOnly = true;
            textBoxResult_NIS.Size = new Size(190, 285);
            textBoxResult_NIS.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(chart_NIS);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(731, 311);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(224, 3);
            label1.Name = "label1";
            label1.Size = new Size(329, 25);
            label1.TabIndex = 2;
            label1.Text = "Функция 2x-3/(cos(x)-2x) + 5x - sin(x)";
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
            ClientSize = new Size(931, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 4 | Нефедов И.С. ";
            ((System.ComponentModel.ISupportInitialize)chart_NIS).EndInit();
            panel1.ResumeLayout(false);
            groupBoxInput_NIS.ResumeLayout(false);
            groupBoxInput_NIS.PerformLayout();
            groupBoxTask_NIS.ResumeLayout(false);
            groupBoxTask_NIS.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutPut_NIS.ResumeLayout(false);
            groupBoxOutPut_NIS.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_NIS;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask_NIS;
        private GroupBox groupBoxOutPut_NIS;
        private TextBox textBoxResult_NIS;
        private GroupBox groupBoxInput_NIS;
        private TextBox textBoxTask_NIS;
        private Label label2;
        private Label label3;
        private TextBox textBoxStopStep_NIS;
        private TextBox textBoxStartStep_NIS;
        private Button buttonHelp_NIS;
        private Button buttonDone_NIS;
        private Button buttonSave_NIS;
        private Label label1;
    }
}