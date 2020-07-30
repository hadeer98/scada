using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radial_Distribution_System_2
{
    public partial class Form3 : Form
    {
        Form f2;
        int num;
        int feederno;
        public Form3(Form f2, int i,int n,int feeder)
        {
            this.f2 = f2;
            InitializeComponent();
            this.Text += i.ToString();
            num = n;
            feederno = feeder;
        }
        string cs = @"Data Source=DESKTOP-P2FPNS2;Initial Catalog=PMU;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";

        private void Form3_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(cs))
            {
                sqlcon.Open();
                string cmdstring = string.Format("SELECT busID,type,voltage,frequency,insulation,Zs,Zm,Ys,Ym,length FROM [PMU].[dbo].[buses] where feederId={0}", feederno);
                SqlDataAdapter sqldata = new SqlDataAdapter(cmdstring, sqlcon);
                DataTable dt = new DataTable();
                sqldata.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        
    }
}
