using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serving_exercise
{
    public partial class Score_display : Form
    {
        public Score_display(int Solutions, double Score, int Question)
        {
            InitializeComponent();
            label3.Text += "   " + Score;
            label2.Text += "  " + Solutions + "/" + Question;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
