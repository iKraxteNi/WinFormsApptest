using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void butSuma_Click(object sender, EventArgs e)
        { 
            
            
            try
            {
                
                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);
                float z = float.Parse(textBox3.Text);
                textBox4Wynik.Text = (x + y + z).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("nie podano liczb lub zostawiono pole puste  ");
            }
        }

        private void butIloczyn_Click(object sender, EventArgs e)
        {
            try
            {

                float x = float.Parse(textBox1.Text);
                float y = float.Parse(textBox2.Text);
                float z = float.Parse(textBox3.Text);
                textBox4Wynik.Text = (x * y * z).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("nie podano liczb lub zostawiono pole puste ");
            }

        }
    }
}
