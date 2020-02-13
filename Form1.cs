using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int abc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAge.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter Age");
            }
            else if (Convert.ToInt32(txtAge.Text) > 18)
            {
                MessageBox.Show("Valid Age");
            }
            else
            {
                abc++;
                if (abc >= 3)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Invalid Age");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi");
        }
    }
}
