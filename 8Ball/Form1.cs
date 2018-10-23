using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8Ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randGen = new Random();
            int number = randGen.Next(1, 7);

            switch (number)
            {
                case 1:
                    label1.Text = "yes";
                    break;
                case 2:
                    label1.Text = "no";
                    break;
                case 3:
                    label1.Text = "maybe";
                    break;
                case 4:
                    label1.Text = "possibly";
                    break;
                case 5:
                    label1.Text = "i don't know";
                    break;

                case 6:
                    label1.Text = "Chris";
                    break;
            }
        }
    }
}
