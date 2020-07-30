using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Radial_Distribution_System_2
{
    public partial class showdata : Form
    {
        public showdata()
        {
            InitializeComponent();
        }
        string cs = @"Data Source=DESKTOP-P2FPNS2;Initial Catalog=PMU;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon=new SqlConnection(cs))
            {
                sqlcon.Open();
                SqlDataAdapter sqldata=new SqlDataAdapter("SELECT * FROM [PMU].[dbo].[Phase1]",sqlcon);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void showdata_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pMUDataSet3.buses' table. You can move, or remove it, as needed.
            this.busesTableAdapter2.Fill(this.pMUDataSet3.buses);
            // TODO: This line of code loads data into the 'pMUDataSet2.buses' table. You can move, or remove it, as needed.
            this.busesTableAdapter.Fill(this.pMUDataSet2.buses);
            // TODO: This line of code loads data into the 'pMUDataSet.Feeder' table. You can move, or remove it, as needed.
            this.feederTableAdapter.Fill(this.pMUDataSet.Feeder);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.feederTableAdapter.FillBy(this.pMUDataSet.Feeder);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.busesTableAdapter.FillBy(this.pMUDataSet2.buses);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.busesTableAdapter.FillBy1(this.pMUDataSet2.buses);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void busdata_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (busdata.SelectedIndex == -1)
            {
                textBox1.Text = string.Empty;
            }
            else
            {
                textBox1.Text += busdata.SelectedItem.ToString()+" - ";
            }
        }

        
    }
}
