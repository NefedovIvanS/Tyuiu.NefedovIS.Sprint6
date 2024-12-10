namespace Tyuiu.NefedovIS.Sprint6.Task3.V29
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
            textBoxTask_NIS = new TextBox();
            groupBoxTask_NIS = new GroupBox();
            dataGridView_NIS = new DataGridView();
            buttonHelp_NIS = new Button();
            groupBoxTask_NIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NIS).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask_NIS
            // 
            textBoxTask_NIS.BorderStyle = BorderStyle.None;
            textBoxTask_NIS.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_NIS.Location = new Point(11, 19);
            textBoxTask_NIS.Multiline = true;
            textBoxTask_NIS.Name = "textBoxTask_NIS";
            textBoxTask_NIS.ReadOnly = true;
            textBoxTask_NIS.Size = new Size(183, 144);
            textBoxTask_NIS.TabIndex = 0;
            textBoxTask_NIS.Text = "Дан массив 5 на 5 элементов. Выполнить сортировку по возрастанию в пятом столбце.\r\n-2 -13 -15  -9 -17\r\n 13 -20 -15  27  18\r\n-12  -1 -20  13  0\r\n 15  32  18 -12 -18\r\n 16   5   3  -5  -8\r\n";
            // 
            // groupBoxTask_NIS
            // 
            groupBoxTask_NIS.Controls.Add(dataGridView_NIS);
            groupBoxTask_NIS.Controls.Add(textBoxTask_NIS);
            groupBoxTask_NIS.Location = new Point(12, 12);
            groupBoxTask_NIS.Name = "groupBoxTask_NIS";
            groupBoxTask_NIS.Size = new Size(602, 296);
            groupBoxTask_NIS.TabIndex = 3;
            groupBoxTask_NIS.TabStop = false;
            groupBoxTask_NIS.Text = "Условие";
            // 
            // dataGridView_NIS
            // 
            dataGridView_NIS.AllowUserToAddRows = false;
            dataGridView_NIS.AllowUserToDeleteRows = false;
            dataGridView_NIS.AllowUserToResizeColumns = false;
            dataGridView_NIS.AllowUserToResizeRows = false;
            dataGridView_NIS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_NIS.ColumnHeadersVisible = false;
            dataGridView_NIS.Location = new Point(313, 19);
            dataGridView_NIS.Name = "dataGridView_NIS";
            dataGridView_NIS.ReadOnly = true;
            dataGridView_NIS.RowHeadersVisible = false;
            dataGridView_NIS.Size = new Size(283, 267);
            dataGridView_NIS.TabIndex = 1;
            // 
            // buttonHelp_NIS
            // 
            buttonHelp_NIS.BackColor = SystemColors.MenuHighlight;
            buttonHelp_NIS.FlatStyle = FlatStyle.System;
            buttonHelp_NIS.Location = new Point(621, 267);
            buttonHelp_NIS.Name = "buttonHelp_NIS";
            buttonHelp_NIS.Size = new Size(43, 41);
            buttonHelp_NIS.TabIndex = 13;
            buttonHelp_NIS.Text = "?";
            buttonHelp_NIS.UseVisualStyleBackColor = false;
            buttonHelp_NIS.Click += buttonHelp_NIS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 313);
            Controls.Add(buttonHelp_NIS);
            Controls.Add(groupBoxTask_NIS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 29 | Нефедов И. С. ";
            Load += FormMain_Load;
            groupBoxTask_NIS.ResumeLayout(false);
            groupBoxTask_NIS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_NIS).EndInit();
            ResumeLayout(false);
        }


        private TextBox textBoxTask_NIS;
        private GroupBox groupBoxTask_NIS;
        private DataGridView dataGridView_NIS;
        private Button buttonHelp_NIS;
    }
}
