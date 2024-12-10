namespace Tyuiu.NefedovIS.Sprint6.Task7.V14
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            panel1 = new Panel();
            buttonExit_NIS = new Button();
            buttonOk_NIS = new Button();
            textBoxAbout_NIS = new TextBox();
            pictureBox_NIS = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_NIS).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonExit_NIS);
            panel1.Controls.Add(buttonOk_NIS);
            panel1.Controls.Add(textBoxAbout_NIS);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(183, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(398, 254);
            panel1.TabIndex = 3;
            // 
            // buttonExit_NIS
            // 
            buttonExit_NIS.Location = new Point(285, 202);
            buttonExit_NIS.Name = "buttonExit_NIS";
            buttonExit_NIS.Size = new Size(101, 44);
            buttonExit_NIS.TabIndex = 2;
            buttonExit_NIS.Text = "Окей";
            buttonExit_NIS.UseVisualStyleBackColor = true;
            buttonExit_NIS.Click += buttonExit_NIS_Click;
            // 
            // buttonOk_NIS
            // 
            buttonOk_NIS.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk_NIS.Location = new Point(467, 354);
            buttonOk_NIS.Name = "buttonOk_NIS";
            buttonOk_NIS.Size = new Size(112, 45);
            buttonOk_NIS.TabIndex = 1;
            buttonOk_NIS.Text = "Окей";
            buttonOk_NIS.UseVisualStyleBackColor = true;
            // 
            // textBoxAbout_NIS
            // 
            textBoxAbout_NIS.BorderStyle = BorderStyle.None;
            textBoxAbout_NIS.Dock = DockStyle.Fill;
            textBoxAbout_NIS.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAbout_NIS.Location = new Point(5, 5);
            textBoxAbout_NIS.Multiline = true;
            textBoxAbout_NIS.Name = "textBoxAbout_NIS";
            textBoxAbout_NIS.ReadOnly = true;
            textBoxAbout_NIS.Size = new Size(388, 244);
            textBoxAbout_NIS.TabIndex = 0;
            textBoxAbout_NIS.TextChanged += textBoxAbout_NIS_TextChanged;
            // 
            // pictureBox_NIS
            // 
            pictureBox_NIS.Location = new Point(6, 5);
            pictureBox_NIS.Name = "pictureBox_NIS";
            pictureBox_NIS.Size = new Size(168, 245);
            pictureBox_NIS.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_NIS.TabIndex = 4;
            pictureBox_NIS.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 254);
            Controls.Add(panel1);
            Controls.Add(pictureBox_NIS);
            MinimumSize = new Size(597, 293);
            Name = "FormAbout";
            Text = "О программе";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_NIS).EndInit();
            ResumeLayout(false);
        }

        private Panel panel1;
        private Button buttonOk_NIS;
        private TextBox textBoxAbout_NIS;
        private PictureBox pictureBox_NIS;
        private Button buttonExit_NIS;
    }
}