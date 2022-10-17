using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManagerDemo
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }


        private int _startPoint = 0;

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _startPoint += 5;
            progressBar1.Value = _startPoint;
            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                
                new FrmLogin().Show();
                this.Hide();
            }

        }
    }
}
