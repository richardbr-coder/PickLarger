using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PickLarger
{
    public partial class Form1 : Form
    {
        int correct = 0, incorrect = 0;
        int[] a = new int[100];
        int[] b = new int[100];
        Random r = new Random();
        int x, y, ptr;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (x >= y)
                correct++;
            else
                incorrect++;
            if (ptr == 100)
                reset();
            else
            {
                ptr++;
                x = a[ptr];
                y = b[ptr];
            }
            MessageBox.Show("value1: " + x + " value2: " + y + "\nCorrect Guesses: " + correct + " Incorrect guesses: " + incorrect, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void button2_Click(object sender, EventArgs e)
        {
            if (y >= x)
                correct++;
            else
                incorrect++;
            if (ptr == 100)
                reset();
            else
            {
                ptr++;
                x = a[ptr];
                y = b[ptr];
            }
            MessageBox.Show("value1: " + x + " value2: " + y + "\nCorrect Guesses: " + correct + " Incorrect guesses: " + incorrect, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reset()
        {
            ptr = 0;
            for (int i = 0; i < 100; i++)
            {
                a[i] = r.Next(100);
                b[i] = r.Next(100);
            }
            x = a[0];
            y = b[0];

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            reset();
        }
    }
}

