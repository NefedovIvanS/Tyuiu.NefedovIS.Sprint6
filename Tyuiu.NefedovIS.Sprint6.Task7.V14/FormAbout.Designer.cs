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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            panel1 = new Panel();
            buttonExit_SBI = new Button();
            buttonOk_SBI = new Button();
            textBoxAbout_SBI = new TextBox();
            pictureBox_SBI = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SBI).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonExit_SBI);
            panel1.Controls.Add(buttonOk_SBI);
            panel1.Controls.Add(textBoxAbout_SBI);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(183, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(398, 254);
            panel1.TabIndex = 3;
            // 
            // buttonExit_SBI
            // 
            buttonExit_SBI.Location = new Point(285, 202);
            buttonExit_SBI.Name = "buttonExit_SBI";
            buttonExit_SBI.Size = new Size(101, 44);
            buttonExit_SBI.TabIndex = 2;
            buttonExit_SBI.Text = "Окей";
            buttonExit_SBI.UseVisualStyleBackColor = true;
            buttonExit_SBI.Click += buttonExit_SBI_Click;
            // 
            // buttonOk_SBI
            // 
            buttonOk_SBI.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonOk_SBI.Location = new Point(467, 354);
            buttonOk_SBI.Name = "buttonOk_SBI";
            buttonOk_SBI.Size = new Size(112, 45);
            buttonOk_SBI.TabIndex = 1;
            buttonOk_SBI.Text = "Окей";
            buttonOk_SBI.UseVisualStyleBackColor = true;
            // 
            // textBoxAbout_SBI
            // 
            textBoxAbout_SBI.BorderStyle = BorderStyle.None;
            textBoxAbout_SBI.Dock = DockStyle.Fill;
            textBoxAbout_SBI.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxAbout_SBI.Location = new Point(5, 5);
            textBoxAbout_SBI.Multiline = true;
            textBoxAbout_SBI.Name = "textBoxAbout_SBI";
            textBoxAbout_SBI.ReadOnly = true;
            textBoxAbout_SBI.Size = new Size(388, 244);
            textBoxAbout_SBI.TabIndex = 0;
            textBoxAbout_SBI.Text = resources.GetString("textBoxAbout_SBI.Text");
            // 
            // pictureBox_SBI
            // 
            pictureBox_SBI.Image = (Image)resources.GetObject("pictureBox_SBI.Image");
            pictureBox_SBI.Location = new Point(6, 5);
            pictureBox_SBI.Name = "pictureBox_SBI";
            pictureBox_SBI.Size = new Size(168, 245);
            pictureBox_SBI.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_SBI.TabIndex = 4;
            pictureBox_SBI.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 254);
            Controls.Add(panel1);
            Controls.Add(pictureBox_SBI);
            MinimumSize = new Size(597, 293);
            Name = "FormAbout";
            Text = "О программе";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox_SBI).EndInit();
            ResumeLayout(false);
        }


        private Panel panel1;
        private Button buttonOk_SBI;
        private TextBox textBoxAbout_SBI;
        private PictureBox pictureBox_SBI;
        private Button buttonExit_SBI;
    }
}