using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drinks
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
           
            for (int i = 0; i < 101; i++)
            { 
                progressBar1.Increment(1);
                Thread.Sleep(50);
            }
            this.Close();
        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    progressBar1.Increment(1);
        //    if (progressBar1.Value == 100) timer1.Stop();
        //}
        //private void timer1_Tick(object sender, EventArgs e)
        //{
            //progressBar1.Increment(5);
            // label2.Text = (5*counter).ToString();
            //if (progressBar1.Value == progressBar1.Maximum)
            //{
            //    timer1.Stop();
            //    this.Close();
            //}
        //}
    }
}
