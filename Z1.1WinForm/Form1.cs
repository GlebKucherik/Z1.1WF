using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Z1._1WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Area = 0.0;
        double Pi = Math.PI;
        double Rad = 0.0;
        double In()
        {
            if(Double.TryParse(textBox1.Text, out Area))
            {
                return Math.Sqrt(Area / Pi);
            }
            else
            {
                MessageBox.Show("Что-то не то");
                return 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rad = In();
            label3.Text = Rad.ToString();
        }
    }
}
