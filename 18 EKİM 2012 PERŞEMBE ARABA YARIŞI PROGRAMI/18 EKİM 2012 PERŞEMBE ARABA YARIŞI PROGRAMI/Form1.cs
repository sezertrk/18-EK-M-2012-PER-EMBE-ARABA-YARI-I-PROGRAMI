using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _18_EKİM_2012_PERŞEMBE_ARABA_YARIŞI_PROGRAMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int artis1 = 0;
        int artis2 = 0;
        int artis3 = 0;
        int artis4 = 0;


        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd1 = new Random();
            artis1 = rnd1.Next(0, 10);
            artis2 = rnd1.Next(0, 10);
            artis3 = rnd1.Next(0, 10);
            artis4 = rnd1.Next(0, 10);
            if (button1.Left >= 500) 
            {
                timer1.Stop();
                MessageBox.Show(button1.Text + "Kazanmıştır");
            }
            else if (button2.Left >= 500)
            {
                timer1.Stop();
                MessageBox.Show(button2.Text + "Kazanmıştır");
            }
            else if (button3.Left >= 500)
            {
                timer1.Stop();
                MessageBox.Show(button3.Text + "Kazanmıştır");
            }
            else if (button4.Left >= 500)
            {
                timer1.Stop();
                MessageBox.Show(button4.Text + "Kazanmıştır");
            }
            button1.Left += artis1;
            button2.Left += artis2;
            button3.Left += artis3;
            button4.Left += artis4;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        
    }
}
