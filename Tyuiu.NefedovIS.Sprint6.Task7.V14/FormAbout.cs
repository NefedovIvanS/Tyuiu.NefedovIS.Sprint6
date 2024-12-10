using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.NefedovIS.Sprint6.Task7.V14
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }
        private void buttonExit_NIS_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxAbout_NIS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}