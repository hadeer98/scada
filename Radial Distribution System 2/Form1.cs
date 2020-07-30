using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radial_Distribution_System_2
{
    public partial class Form1 : Form
    {
        // bool nbs8click = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.AutoScrollMinSize = new Size(1500, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 4, "8");
            f2.Show();
            this.Invalidate();
            this.Update();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // this.Hide();
            Form2 f2 = new Form2(this, 4, "7");
            f2.Show();
            this.Invalidate();
            this.Update();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 5, "5");
            f2.Show();
            this.Invalidate();
            this.Update();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 4, "18");
            f2.Show();
            this.Invalidate();
            this.Update();
        }



        private void button7_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 3, "11");
            f2.Show();

            this.Invalidate();
            this.Update();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 3, "10");
            f2.Show();
            this.Invalidate();
            this.Update();

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 3, "9");
            f2.Show();
            this.Invalidate();
            this.Update();


        }

        private void button8_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 5, "6");
            f2.Show();
            this.Invalidate();
            this.Update();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 5, "4");
            f2.Show();
            this.Invalidate();
            this.Update();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 5, "13");
            f2.Show();
            this.Invalidate();
            this.Update();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 5, "17");
            f2.Show();
            this.Invalidate();
            this.Update();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 6, "3");
            f2.Show();
            this.Invalidate();
            this.Update();

        }

        private void button13_Click(object sender, EventArgs e)
        {

            //this.Hide();
            Form2 f2 = new Form2(this, 6, "12");
            f2.Show();
            this.Invalidate();
            this.Update();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            //this.Hide();
            Form2 f2 = new Form2(this, 6, "14");
            f2.Show();
            this.Invalidate();
            this.Update();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            //this.Hide();
            Form2 f2 = new Form2(this, 5, "15");
            f2.Show();
            this.Invalidate();
            this.Update();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 6, "16");
            f2.Show();
            this.Invalidate();
            this.Update();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 8, "2");
            f2.Show();
            this.Invalidate();
            this.Update();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Form2 f2 = new Form2(this, 9, "1");
            f2.Show();
            this.Invalidate();
            this.Update();
        }
    }
}

