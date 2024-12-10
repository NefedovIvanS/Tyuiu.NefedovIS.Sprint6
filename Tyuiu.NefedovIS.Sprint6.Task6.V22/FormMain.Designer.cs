namespace Tyuiu.NefedovIS.Sprint6.Task6.V22
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
            buttonHelp_NIS = new Button();
            buttonDone_NIS = new Button();
            buttonOpenFile_NIS = new Button();
            panel2 = new Panel();
            panelTask_NIS = new Panel();
            groupBoxTask_NIS = new GroupBox();
            textBoxTask_NIS = new TextBox();
            panel4 = new Panel();
            panelInput_NIS = new Panel();
            groupBoxInput_NIS = new GroupBox();
            textBoxInput_NIS = new TextBox();
            panelOutput_NIS = new Panel();
            groupBoxOutput_NIS = new GroupBox();
            textBoxOutput_NIS = new TextBox();
            splitter_NIS = new Splitter();
            toolTip_NIS = new ToolTip(components);
            openFileDialog_NIS = new OpenFileDialog();
            panelButtons_NIS.SuspendLayout();
            panelTask_NIS.SuspendLayout();
            groupBoxTask_NIS.SuspendLayout();
            panel4.SuspendLayout();
            panelInput_NIS.SuspendLayout();
            groupBoxInput_NIS.SuspendLayout();
            panelOutput_NIS.SuspendLayout();
            groupBoxOutput_NIS.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_NIS
            // 
            panelButtons_NIS.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_NIS.Controls.Add(buttonHelp_NIS);
            panelButtons_NIS.Controls.Add(buttonDone_NIS);
            panelButtons_NIS.Controls.Add(buttonOpenFile_NIS);
            panelButtons_NIS.Controls.Add(panel2);
            panelButtons_NIS.Dock = DockStyle.Top;
            panelButtons_NIS.Location = new Point(0, 0);
            panelButtons_NIS.Name = "panelButtons_NIS";
            panelButtons_NIS.Size = new Size(800, 68);
            panelButtons_NIS.TabIndex = 0;
            // 
            // buttonHelp_NIS
            // 
            buttonHelp_NIS.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_NIS.BackColor = Color.Transparent;
            buttonHelp_NIS.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_NIS.Image = Properties.Resources.help;
            buttonHelp_NIS.Location = new Point(715, 3);
            buttonHelp_NIS.Name = "buttonHelp_NIS";
            buttonHelp_NIS.Size = new Size(78, 62);
            buttonHelp_NIS.TabIndex = 4;
            toolTip_NIS.SetToolTip(buttonHelp_NIS, "Открыть справку");
            buttonHelp_NIS.UseVisualStyleBackColor = false;
            buttonHelp_NIS.Click += buttonHelp_Click;
            // 
            // buttonDone_NIS
            // 
            buttonDone_NIS.BackColor = Color.Transparent;
            buttonDone_NIS.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDone_NIS.Enabled = false;
            buttonDone_NIS.Image = Properties.Resources.accept;
            buttonDone_NIS.Location = new Point(87, 3);
            buttonDone_NIS.Name = "buttonDone_NIS";
            buttonDone_NIS.Size = new Size(78, 62);
            buttonDone_NIS.TabIndex = 3;
            toolTip_NIS.SetToolTip(buttonDone_NIS, "Вывести первое слово каждой строки в результирующею строку");
            buttonDone_NIS.UseVisualStyleBackColor = false;
            buttonDone_NIS.Click += buttonDone_Click;
            // 
            // buttonOpenFile_NIS
            // 
            buttonOpenFile_NIS.BackColor = Color.Transparent;
            buttonOpenFile_NIS.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile_NIS.Image = Properties.Resources.page_find;
            buttonOpenFile_NIS.Location = new Point(3, 3);
            buttonOpenFile_NIS.Name = "buttonOpenFile_NIS";
            buttonOpenFile_NIS.Size = new Size(78, 62);
            buttonOpenFile_NIS.TabIndex = 2;
            toolTip_NIS.SetToolTip(buttonOpenFile_NIS, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_NIS.UseVisualStyleBackColor = false;
            buttonOpenFile_NIS.Click += buttonOpenFile_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 76);
            panel2.TabIndex = 1;
            // 
            // panelTask_NIS
            // 
            panelTask_NIS.Controls.Add(groupBoxTask_NIS);
            panelTask_NIS.Dock = DockStyle.Top;
            panelTask_NIS.Location = new Point(0, 68);
            panelTask_NIS.Name = "panelTask_NIS";
            panelTask_NIS.Padding = new Padding(5);
            panelTask_NIS.Size = new Size(800, 101);
            panelTask_NIS.TabIndex = 1;
            // 
            // groupBoxTask_NIS
            // 
            groupBoxTask_NIS.Controls.Add(textBoxTask_NIS);
            groupBoxTask_NIS.Dock = DockStyle.Fill;
            groupBoxTask_NIS.Location = new Point(5, 5);
            groupBoxTask_NIS.Name = "groupBoxTask_NIS";
            groupBoxTask_NIS.RightToLeft = RightToLeft.No;
            groupBoxTask_NIS.Size = new Size(790, 91);
            groupBoxTask_NIS.TabIndex = 0;
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
            textBoxTask_NIS.Size = new Size(784, 69);
            textBoxTask_NIS.TabIndex = 0;
            textBoxTask_NIS.Text = resources.GetString("textBoxTask_NIS.Text");
            // 
            // panel4
            // 
            panel4.Controls.Add(panelInput_NIS);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 169);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 281);
            panel4.TabIndex = 2;
            // 
            // panelInput_NIS
            // 
            panelInput_NIS.Controls.Add(groupBoxInput_NIS);
            panelInput_NIS.Dock = DockStyle.Left;
            panelInput_NIS.Location = new Point(0, 0);
            panelInput_NIS.Name = "panelInput_NIS";
            panelInput_NIS.Padding = new Padding(5);
            panelInput_NIS.Size = new Size(390, 281);
            panelInput_NIS.TabIndex = 3;
            // 
            // groupBoxInput_NIS
            // 
            groupBoxInput_NIS.Controls.Add(textBoxInput_NIS);
            groupBoxInput_NIS.Dock = DockStyle.Fill;
            groupBoxInput_NIS.Location = new Point(5, 5);
            groupBoxInput_NIS.Name = "groupBoxInput_NIS";
            groupBoxInput_NIS.Size = new Size(380, 271);
            groupBoxInput_NIS.TabIndex = 0;
            groupBoxInput_NIS.TabStop = false;
            groupBoxInput_NIS.Text = "Ввод:";
            // 
            // textBoxInput_NIS
            // 
            textBoxInput_NIS.BorderStyle = BorderStyle.None;
            textBoxInput_NIS.Dock = DockStyle.Fill;
            textBoxInput_NIS.Location = new Point(3, 19);
            textBoxInput_NIS.Multiline = true;
            textBoxInput_NIS.Name = "textBoxInput_NIS";
            textBoxInput_NIS.ReadOnly = true;
            textBoxInput_NIS.Size = new Size(374, 249);
            textBoxInput_NIS.TabIndex = 0;
            // 
            // panelOutput_NIS
            // 
            panelOutput_NIS.Controls.Add(groupBoxOutput_NIS);
            panelOutput_NIS.Dock = DockStyle.Right;
            panelOutput_NIS.Location = new Point(396, 169);
            panelOutput_NIS.Name = "panelOutput_NIS";
            panelOutput_NIS.Padding = new Padding(5);
            panelOutput_NIS.Size = new Size(404, 281);
            panelOutput_NIS.TabIndex = 3;
            // 
            // groupBoxOutput_NIS
            // 
            groupBoxOutput_NIS.Controls.Add(textBoxOutput_NIS);
            groupBoxOutput_NIS.Dock = DockStyle.Fill;
            groupBoxOutput_NIS.Location = new Point(5, 5);
            groupBoxOutput_NIS.Name = "groupBoxOutput_NIS";
            groupBoxOutput_NIS.Size = new Size(394, 271);
            groupBoxOutput_NIS.TabIndex = 0;
            groupBoxOutput_NIS.TabStop = false;
            groupBoxOutput_NIS.Text = "Вывод:";
            // 
            // textBoxOutput_NIS
            // 
            textBoxOutput_NIS.BorderStyle = BorderStyle.None;
            textBoxOutput_NIS.Dock = DockStyle.Fill;
            textBoxOutput_NIS.Location = new Point(3, 19);
            textBoxOutput_NIS.Multiline = true;
            textBoxOutput_NIS.Name = "textBoxOutput_NIS";
            textBoxOutput_NIS.ReadOnly = true;
            textBoxOutput_NIS.Size = new Size(388, 249);
            textBoxOutput_NIS.TabIndex = 0;
            // 
            // splitter_NIS
            // 
            splitter_NIS.Location = new Point(390, 169);
            splitter_NIS.Name = "splitter_NIS";
            splitter_NIS.Size = new Size(3, 281);
            splitter_NIS.TabIndex = 4;
            splitter_NIS.TabStop = false;
            // 
            // openFileDialog_NIS
            // 
            openFileDialog_NIS.FileName = "openFileDialog_NIS";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitter_NIS);
            Controls.Add(panelOutput_NIS);
            Controls.Add(panel4);
            Controls.Add(panelTask_NIS);
            Controls.Add(panelButtons_NIS);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 22 | Нефедов И. С. ";
            panelButtons_NIS.ResumeLayout(false);
            panelTask_NIS.ResumeLayout(false);
            groupBoxTask_NIS.ResumeLayout(false);
            groupBoxTask_NIS.PerformLayout();
            panel4.ResumeLayout(false);
            panelInput_NIS.ResumeLayout(false);
            groupBoxInput_NIS.ResumeLayout(false);
            groupBoxInput_NIS.PerformLayout();
            panelOutput_NIS.ResumeLayout(false);
            groupBoxOutput_NIS.ResumeLayout(false);
            groupBoxOutput_NIS.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelButtons_NIS;
        private Panel panel2;
        private Button buttonOpenFile_NIS;
        private Panel panelTask_NIS;
        private Button buttonDone_NIS;
        private Button buttonHelp_NIS;
        private GroupBox groupBoxTask_NIS;
        private TextBox textBoxTask_NIS;
        private Panel panel4;
        private Panel panelInput_NIS;
        private Panel panelOutput_NIS;
        private GroupBox groupBoxInput_NIS;
        private TextBox textBoxInput_NIS;
        private GroupBox groupBoxOutput_NIS;
        private TextBox textBoxOutput_NIS;
        private Splitter splitter_NIS;
        private ToolTip toolTip_NIS;
        private OpenFileDialog openFileDialog_NIS;
    }
}