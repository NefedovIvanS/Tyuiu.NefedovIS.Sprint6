namespace Tyuiu.NefedovIS.Sprint6.Task0.V15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_NIS = new GroupBox();
            pictureBoxTask_NIS = new PictureBox();
            textBoxTask_NIS = new TextBox();
            groupBoxInput_NIS = new GroupBox();
            label1 = new Label();
            textBoxX_NIS = new TextBox();
            groupBoxOutput_NIS = new GroupBox();
            label4 = new Label();
            textBoxResult_NIS = new TextBox();
            buttonQuestion_NIS = new Button();
            buttonDoneResult_NIS = new Button();
            groupBoxTask_NIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_NIS).BeginInit();
            groupBoxInput_NIS.SuspendLayout();
            groupBoxOutput_NIS.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_NIS
            // 
            groupBoxTask_NIS.Controls.Add(pictureBoxTask_NIS);
            groupBoxTask_NIS.Controls.Add(textBoxTask_NIS);
            groupBoxTask_NIS.Location = new Point(12, 12);
            groupBoxTask_NIS.Name = "groupBoxTask_NIS";
            groupBoxTask_NIS.Size = new Size(706, 231);
            groupBoxTask_NIS.TabIndex = 0;
            groupBoxTask_NIS.TabStop = false;
            groupBoxTask_NIS.Text = "Условие";
            // 
            // pictureBoxTask_NIS
            // 
            pictureBoxTask_NIS.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxTask_NIS.Image = Properties.Resources.Screenshot_2;
            pictureBoxTask_NIS.InitialImage = (Image)resources.GetObject("pictureBoxTask_NIS.InitialImage");
            pictureBoxTask_NIS.Location = new Point(463, 44);
            pictureBoxTask_NIS.Name = "pictureBoxTask_NIS";
            pictureBoxTask_NIS.Size = new Size(220, 38);
            pictureBoxTask_NIS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxTask_NIS.TabIndex = 1;
            pictureBoxTask_NIS.TabStop = false;
            // 
            // textBoxTask_NIS
            // 
            textBoxTask_NIS.BorderStyle = BorderStyle.None;
            textBoxTask_NIS.Location = new Point(11, 19);
            textBoxTask_NIS.Multiline = true;
            textBoxTask_NIS.Name = "textBoxTask_NIS";
            textBoxTask_NIS.ReadOnly = true;
            textBoxTask_NIS.Size = new Size(326, 127);
            textBoxTask_NIS.TabIndex = 0;
            textBoxTask_NIS.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxInput_NIS
            // 
            groupBoxInput_NIS.Controls.Add(label1);
            groupBoxInput_NIS.Controls.Add(textBoxX_NIS);
            groupBoxInput_NIS.Location = new Point(12, 261);
            groupBoxInput_NIS.Name = "groupBoxInput_NIS";
            groupBoxInput_NIS.Size = new Size(426, 100);
            groupBoxInput_NIS.TabIndex = 1;
            groupBoxInput_NIS.TabStop = false;
            groupBoxInput_NIS.Text = "Ввод данных";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 3;
            label1.Text = "Переменная X:";
            // 
            // textBoxX_NIS
            // 
            textBoxX_NIS.Location = new Point(11, 53);
            textBoxX_NIS.Name = "textBoxX_NIS";
            textBoxX_NIS.Size = new Size(108, 23);
            textBoxX_NIS.TabIndex = 0;
            textBoxX_NIS.KeyPress += textBoxVarX_NIS_KeyPress;
            // 
            // groupBoxOutput_NIS
            // 
            groupBoxOutput_NIS.Controls.Add(label4);
            groupBoxOutput_NIS.Controls.Add(textBoxResult_NIS);
            groupBoxOutput_NIS.Location = new Point(444, 261);
            groupBoxOutput_NIS.Name = "groupBoxOutput_NIS";
            groupBoxOutput_NIS.Size = new Size(274, 100);
            groupBoxOutput_NIS.TabIndex = 2;
            groupBoxOutput_NIS.TabStop = false;
            groupBoxOutput_NIS.Text = "Вывод данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 35);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Результат:";
            // 
            // textBoxResult_NIS
            // 
            textBoxResult_NIS.Location = new Point(6, 53);
            textBoxResult_NIS.Name = "textBoxResult_NIS";
            textBoxResult_NIS.ReadOnly = true;
            textBoxResult_NIS.Size = new Size(262, 23);
            textBoxResult_NIS.TabIndex = 8;
            // 
            // buttonQuestion_NIS
            // 
            buttonQuestion_NIS.FlatStyle = FlatStyle.Flat;
            buttonQuestion_NIS.Location = new Point(450, 376);
            buttonQuestion_NIS.Name = "buttonQuestion_NIS";
            buttonQuestion_NIS.Size = new Size(63, 62);
            buttonQuestion_NIS.TabIndex = 3;
            buttonQuestion_NIS.Text = "?";
            buttonQuestion_NIS.UseVisualStyleBackColor = true;
            buttonQuestion_NIS.Click += buttonQuestion_NIS_Click;
            // 
            // buttonDoneResult_NIS
            // 
            buttonDoneResult_NIS.BackgroundImageLayout = ImageLayout.None;
            buttonDoneResult_NIS.FlatStyle = FlatStyle.System;
            buttonDoneResult_NIS.Location = new Point(530, 376);
            buttonDoneResult_NIS.Name = "buttonDoneResult_NIS";
            buttonDoneResult_NIS.Size = new Size(182, 62);
            buttonDoneResult_NIS.TabIndex = 4;
            buttonDoneResult_NIS.Text = "Выполнить";
            buttonDoneResult_NIS.UseVisualStyleBackColor = true;
            buttonDoneResult_NIS.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 450);
            Controls.Add(buttonDoneResult_NIS);
            Controls.Add(buttonQuestion_NIS);
            Controls.Add(groupBoxOutput_NIS);
            Controls.Add(groupBoxInput_NIS);
            Controls.Add(groupBoxTask_NIS);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 15 | Нефедов И. С.";
            groupBoxTask_NIS.ResumeLayout(false);
            groupBoxTask_NIS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask_NIS).EndInit();
            groupBoxInput_NIS.ResumeLayout(false);
            groupBoxInput_NIS.PerformLayout();
            groupBoxOutput_NIS.ResumeLayout(false);
            groupBoxOutput_NIS.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_NIS;
        private GroupBox groupBoxInput_NIS;
        private GroupBox groupBoxOutput_NIS;
        private TextBox textBoxTask_NIS;
        private Label label1;
        private TextBox textBoxX_NIS;
        private Label label4;
        private TextBox textBoxResult_NIS;
        private Button buttonQuestion_NIS;
        private Button buttonDoneResult_NIS;
        private PictureBox pictureBoxTask_NIS;
    }
}