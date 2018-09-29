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
    public partial class Form1 : Form
    {
        int i = 0;
        int pv = 0;
        int sv = 0;
        public Form1()
        {
            InitializeComponent();
			checkedListBox1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox6.Visible = true;
            groupBox7.Visible = true;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (checkedListBox1.SelectedItem == "Un planeta")
            {
                if (checkedListBox2.SelectedItem == "Un planeta")
                {

                    label8.Text = "1";
                    label9.Text = "1";
                    i++;
                }
                else
                {
                    label8.Text = "1";
                    pv++;
                }
            }

            if (checkedListBox2.SelectedItem == "Un planeta")
            {

                label9.Text = "1";
                sv++;
            }

            groupBox6.Visible = false;
            groupBox7.Visible = false;
            groupBox9.Visible = true;
            groupBox8.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkedListBox3.SelectedItem == "H2O")
            {
                if (checkedListBox4.SelectedItem == "H2O")
                {

                    if (i == 1)
                    {

                        label8.Text = "2";
                        label9.Text = "2";
                    }
                    
                }
                else
                {
                    if (pv == 1)
                    {
                        label8.Text = "2";
                        MessageBox.Show("Felicidades, el jugador A ha ganado el juego");

                    }
                    else {
                        label8.Text = "1";
                    }
                }
            }

            if (checkedListBox4.SelectedItem == "H2O")
            {
                if (sv == 1)
                {
                    label9.Text = "2";
                    MessageBox.Show("Felicidades, el jugador B ha ganado el juego");
                }
                else
                {
                    label9.Text = "1";
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            button4.Size = new Size(Width= 1160, Height= 741);
;        }


	}
}
