using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value<100);
            progressBar1.Value = progressBar1.Value + 10;
            label1.Text = "CARGANDO EL SISTEMA AL " + progressBar1.Value + "%";        
            else
        { 
           timer1.Enabled=false;
            MessageBox.Show("CARGA COMPLETA");
            this.Close();
    }
}
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show()

        }