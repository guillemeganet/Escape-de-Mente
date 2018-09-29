using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;


namespace Precarga
{
    public partial class Precarga : Form

    {
        public Precarga()
        {
            InitializeComponent();
			timer1.Enabled = true;
			progressBar1.Value = 0;
			timer1.Interval = 750;
        }


		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void timer1_Tick_1(object sender, EventArgs e)
		{
			if (progressBar1.Value < 100)
			{
				progressBar1.Value = progressBar1.Value + 10;
				label1.Text = "CARGANDO EL SISTEMA AL " + progressBar1.Value + "%";
			}
			else
			{
				timer1.Stop();
				Form1 pr = new Form1();
				pr.Show();
				this.Hide();
				

			}
		}
	}
}