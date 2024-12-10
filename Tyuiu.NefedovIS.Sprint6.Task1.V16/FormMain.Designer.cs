namespace Tyuiu.NefedovIS.Sprint6.Task1.V16
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
            groupBoxTask_NIS = new GroupBox();
            textBoxTask_NIS = new TextBox();
            groupBoxResult_NIS = new GroupBox();
            labelResult_NIS = new Label();
            textBoxResult_NIS = new TextBox();
            groupBoxInput_NIS = new GroupBox();
            label2 = new Label();
            textBoxStopStep_NIS = new TextBox();
            label1 = new Label();
            textBoxStartStep_NIS = new TextBox();
            buttonDone_NIS = new Button();
            buttonHelp_NIS = new Button();
            groupBoxTask_NIS.SuspendLayout();
            groupBoxResult_NIS.SuspendLayout();
            groupBoxInput_NIS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_NIS
            // 
            groupBoxTask_NIS.Controls.Add(textBoxTask_NIS);
            groupBoxTask_NIS.Location = new Point(12, 12);
            groupBoxTask_NIS.Name = "groupBoxTask_NIS";
            groupBoxTask_NIS.Size = new Size(485, 308);
            groupBoxTask_NIS.TabIndex = 1;
            groupBoxTask_NIS.TabStop = false;
            groupBoxTask_NIS.Text = "Условие";
            groupBoxTask_NIS.Enter += groupBoxTask_NIS_Enter;
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
            textBoxTask_NIS.Text = "Протабулировать функцию (2x-3)/(cos(x)-2x) + 5x - sin(x) на заданном диапозоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxResult_NIS
            // 
            groupBoxResult_NIS.Controls.Add(labelResult_NIS);
            groupBoxResult_NIS.Controls.Add(textBoxResult_NIS);
            groupBoxResult_NIS.Location = new Point(503, 12);
            groupBoxResult_NIS.Name = "groupBoxResult_NIS";
            groupBoxResult_NIS.Size = new Size(285, 414);
            groupBoxResult_NIS.TabIndex = 2;
            groupBoxResult_NIS.TabStop = false;
            groupBoxResult_NIS.Text = "Вывод данных";
            // 
            // labelResult_NIS
            // 
            labelResult_NIS.AutoSize = true;
            labelResult_NIS.Location = new Point(6, 23);
            labelResult_NIS.Name = "labelResult_NIS";
            labelResult_NIS.Size = new Size(63, 15);
            labelResult_NIS.TabIndex = 2;
            labelResult_NIS.Text = "Результат:";
            // 
            // textBoxResult_NIS
            // 
            textBoxResult_NIS.BorderStyle = BorderStyle.None;
            textBoxResult_NIS.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_NIS.Location = new Point(6, 41);
            textBoxResult_NIS.Multiline = true;
            textBoxResult_NIS.Name = "textBoxResult_NIS";
            textBoxResult_NIS.ReadOnly = true;
            textBoxResult_NIS.ScrollBars = ScrollBars.Vertical;
            textBoxResult_NIS.Size = new Size(273, 367);
            textBoxResult_NIS.TabIndex = 1;
            // 
            // groupBoxInput_NIS
            // 
            groupBoxInput_NIS.Controls.Add(label2);
            groupBoxInput_NIS.Controls.Add(textBoxStopStep_NIS);
            groupBoxInput_NIS.Controls.Add(label1);
            groupBoxInput_NIS.Controls.Add(textBoxStartStep_NIS);
            groupBoxInput_NIS.Location = new Point(12, 326);
            groupBoxInput_NIS.Name = "groupBoxInput_NIS";
            groupBoxInput_NIS.Size = new Size(273, 100);
            groupBoxInput_NIS.TabIndex = 3;
            groupBoxInput_NIS.TabStop = false;
            groupBoxInput_NIS.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 35);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 5;
            label2.Text = "Конец шага:";
            // 
            // textBoxStopStep_NIS
            // 
            textBoxStopStep_NIS.Location = new Point(140, 53);
            textBoxStopStep_NIS.Name = "textBoxStopStep_NIS";
            textBoxStopStep_NIS.Size = new Size(128, 23);
            textBoxStopStep_NIS.TabIndex = 4;
            textBoxStopStep_NIS.KeyPress += textBoxSteps_NIS_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 3;
            label1.Text = "Старт шага:";
            // 
            // textBoxStartStep_NIS
            // 
            textBoxStartStep_NIS.Location = new Point(6, 53);
            textBoxStartStep_NIS.Name = "textBoxStartStep_NIS";
            textBoxStartStep_NIS.Size = new Size(128, 23);
            textBoxStartStep_NIS.TabIndex = 0;
            textBoxStartStep_NIS.KeyPress += textBoxSteps_NIS_KeyPress;
            // 
            // buttonDone_NIS
            // 
            buttonDone_NIS.BackColor = Color.Green;
            buttonDone_NIS.Location = new Point(363, 337);
            buttonDone_NIS.Name = "buttonDone_NIS";
            buttonDone_NIS.Size = new Size(134, 89);
            buttonDone_NIS.TabIndex = 5;
            buttonDone_NIS.Text = "Выполнить";
            buttonDone_NIS.UseVisualStyleBackColor = false;
            buttonDone_NIS.Click += buttonDone_Click;
            // 
            // buttonHelp_NIS
            // 
            buttonHelp_NIS.BackColor = SystemColors.MenuHighlight;
            buttonHelp_NIS.Location = new Point(291, 337);
            buttonHelp_NIS.Name = "buttonHelp_NIS";
            buttonHelp_NIS.Size = new Size(66, 89);
            buttonHelp_NIS.TabIndex = 6;
            buttonHelp_NIS.Text = "Справка";
            buttonHelp_NIS.UseVisualStyleBackColor = false;
            buttonHelp_NIS.Click += buttonHelp_NIS_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp_NIS);
            Controls.Add(buttonDone_NIS);
            Controls.Add(groupBoxInput_NIS);
            Controls.Add(groupBoxResult_NIS);
            Controls.Add(groupBoxTask_NIS);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 16 | Нефедов И.С.";
            groupBoxTask_NIS.ResumeLayout(false);
            groupBoxTask_NIS.PerformLayout();
            groupBoxResult_NIS.ResumeLayout(false);
            groupBoxResult_NIS.PerformLayout();
            groupBoxInput_NIS.ResumeLayout(false);
            groupBoxInput_NIS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NIS;
        private TextBox textBoxTask_NIS;
        private GroupBox groupBoxResult_NIS;
        private GroupBox groupBoxInput_NIS;
        private Label label1;
        private TextBox textBoxStartStep_NIS;
        private Label label2;
        private TextBox textBoxStopStep_NIS;
        private Label labelResult_NIS;
        private TextBox textBoxResult_NIS;
        private Button buttonDone_NIS;
        private Button buttonHelp_NIS;
    }
}
