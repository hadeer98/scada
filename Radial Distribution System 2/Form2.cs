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
    public partial class Form2 : Form
    {
        Form f1;
        int n;
        bool flag = true;
        bool Switch_flag = true;
        TextBox[, ,] txt;
        int counter = 0;
        bool[] switches;

        int feeder;

        //List<switches> swt = new List<switches>();
        public Form2(Form f1, int num, string x)
        {
            this.f1 = f1;
            n = num;
            txt = new TextBox[3, n, 12];
            InitializeComponent();
            label2.Text = x;
            switches = new bool[n * 2];
            feeder = Int32.Parse(x);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.AutoScrollMinSize = new Size(1200, 1900);
            this.AutoScroll = true;
            for (int i = 0; i < 2 * n; i++)
            {
                switches[i] = true;
            }
        }

        protected override void OnPaint(PaintEventArgs pea)
        {
            int count = 0;
            Graphics grfx = pea.Graphics;
            flag = true;

            for (int i = 0; i < n; i++)
            {
                DoPage(grfx, ForeColor, 5, count, 100, i + 1, i == n - 1);
                count += 200;
                flag = false;
            }
            firstTime = false;

        }
        bool firstTime = true;

        protected void DoPage(Graphics grfx, Color clr, int cx, int cy, int x, int i, bool end)
        {
            int yy = this.AutoScrollPosition.Y;
            int xx = this.AutoScrollPosition.X;
            if (flag)
            {
                grfx.DrawLines(new Pen(clr),
                       new Point[]
            {
                new Point(10*cx+x+xx,15*cx+yy),new Point(50*cx+x+xx,15*cx+yy)/*,new Point(20*cx+x+xx,15*cx+yy),new Point(20*cx+x+xx,ClientSize.Height-1)*/

            });
            }
            grfx.DrawLines(new Pen(Color.Blue),
                       new Point[]
            {
                new Point(20*cx+x+xx,15*cx+cy+yy),new Point(20*cx+x+xx,25*cx+cy+yy)

            });
            grfx.DrawLines(new Pen(Color.Blue),
                       new Point[]
            {
                new Point(20*cx+x+xx,35*cx+cy+yy),new Point(20*cx+x+xx,15*cx+yy+cy+200)

            });
            grfx.DrawLines(new Pen(Color.Blue),
            new Point[]
            {
                new Point(20*cx+x+xx,25*cx+cy+yy),new Point(25*cx+x+xx,25*cx+cy+yy),new Point(30*cx+x+xx,20*cx+cy+yy)
   
            });
            grfx.DrawLines(new Pen(clr),
            new Point[]{
                new Point(30*cx+x+xx,25*cx+cy+yy),new Point(40*cx+x+xx,25*cx+cy+yy)
            });

            grfx.DrawLines(new Pen(Color.Blue),
            new Point[]
{
     new Point(30*cx+x+xx,30*cx+cy+yy),new Point(25*cx+x+xx,35*cx+cy+yy),new Point(20*cx+x+xx,35*cx+cy+yy)
   
});
            grfx.DrawLines(new Pen(clr),//phigh,qhigh
   new Point[]
{
     new Point(30*cx+x+xx,35*cx+cy+yy),new Point(40*cx+x+xx,35*cx+cy+yy)
   
});
            grfx.DrawLines(new Pen(clr),
            new Point[]
{
     new Point(40*cx+x+xx,20*cx+cy+yy),new Point(40*cx+x+xx,40*cx+cy+yy)
   
});
            grfx.DrawLines(new Pen(clr),
            new Point[]
{
     new Point(40*cx+x+xx,30*cx+cy+yy),new Point(60*cx+x+xx,30*cx+cy+yy)
   
});
            grfx.DrawLines(new Pen(clr),
            new Point[]
{
     new Point(77*cx+x+xx,30*cx+cy+yy),new Point(100*cx+x+xx,30*cx+cy+yy)
   
});


            grfx.DrawLines(new Pen(clr),
               new Point[]
         {
          new Point(100*cx+x+xx,20*cx+cy+yy),new Point(100*cx+x+xx,40*cx+cy+yy),
         });


            Graphics g = grfx;
            Pen p = new Pen(Brushes.DarkGreen, 5);
            p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(p, 100 * cx + x + xx, 30 * cx + cy + yy, 107 * cx + x + xx, 30 * cx + cy + yy);


            if (switches[2 * (i - 1)])
            {
                grfx.DrawArc(new Pen(clr), 16 * cx + x + xx, 20 * cx + cy + yy, 15 * cx, 15 * cx, 0, -75);
            }
            if (switches[2 * i - 1])
            {
                grfx.DrawArc(new Pen(clr), 16 * cx + x + xx, 30 * cx + cy + yy, 15 * cx, 15 * cx, 0, -75);

            }

            counter += 2;
            grfx.DrawEllipse(new Pen(Color.Red), 60 * cx + x + xx, 25 * cx + cy + yy, 10 * cx, 10 * cx);
            grfx.DrawEllipse(new Pen(Color.Red), 67 * cx + x + xx, 25 * cx + cy + yy, 10 * cx, 10 * cx);
            Brush brush = new SolidBrush(ForeColor);
            StringFormat strfmt = new StringFormat();
            //grfx.DrawString("Zcable"+" "+i, Font, brush, 10*cx+xx, 25*cx+cy+yy, strfmt);
            grfx.DrawString("Ih" + " " + i, Font, brush, 5 * cx + x + xx, 29 * cx + cy + yy, strfmt);
            grfx.DrawString("Vh" + " " + i, Font, brush, 4 * cx + x + xx, 34 * cx + cy + yy, strfmt);
            //grfx.DrawString("Ztr" + " " + i, Font, brush, 62 * cx + x + xx, 20 * cx + cy + yy, strfmt);
            grfx.DrawString("Il" + " " + i, Font, brush, 90 * cx + x + xx, 25 * cx + cy + yy, strfmt);
            grfx.DrawString("Vl" + " " + i, Font, brush, 97 * cx + x + xx, 15 * cx + cy + yy, strfmt);
            grfx.DrawString("S" + " " + i, Font, brush, 107 * cx + x + xx, 28 * cx + cy + yy, strfmt);
            grfx.DrawString("PLoad" + " " + i, Font, new SolidBrush(Color.DarkGreen), 100 * cx + x + xx, 31 * cx + cy + yy, strfmt);
            grfx.DrawString("QLoad" + " " + i, Font, new SolidBrush(Color.DarkGreen), 100 * cx + x + xx, 35 * cx + cy + yy, strfmt);
            if (flag)
            {
                grfx.DrawString("Phigh" + " " + i, Font, new SolidBrush(Color.DarkViolet), 15 * cx + xx, 17 * cx + cy + yy, strfmt);
                grfx.DrawString("Qhigh" + " " + i, Font, new SolidBrush(Color.DarkViolet), 15 * cx + xx, 20 * cx + cy + yy, strfmt);
            }
            if (i + 1 <= n)
            {
                grfx.DrawString("Phigh" + " " + (i + 1), Font, new SolidBrush(Color.DarkViolet), 30 * cx + x + xx, 38 * cx + cy + yy, strfmt);
                grfx.DrawString("Qhigh" + " " + (i + 1), Font, new SolidBrush(Color.DarkViolet), 30 * cx + x + xx, 41 * cx + cy + yy, strfmt);
            }

            DrawText(130, cx, cy, x, i, yy, xx, 0);
            DrawText(155, cx, cy, x, i, yy, xx, 1);
            DrawText(180, cx, cy, x, i, yy, xx, 2);
            if (end)
            {
                // code here
            }
            if (firstTime)
            {
                Button btn = new Button();
                btn.Name = "Zcable" + i;
                btn.Text = "Zcable" + i;
                btn.Location = new Point(15 * cx + xx, 24 * cx + cy + yy);
                //btn.Size = new Size(3 * 20, 3 * 20);
                btn.BackColor = System.Drawing.Color.White;
                btn.Click += delegate(object sender, EventArgs e) { btn_Click(sender, e, i); };
                this.Controls.Add(btn);


                Button btn2 = new Button();
                btn2.Name = "Ztr" + i;
                btn2.Text = "Ztr" + i;
                btn2.Location = new Point(82 * cx + xx, 18 * cx + cy + yy);
                //btn.Size = new Size(5 * 20, 5 * 20);
                btn2.BackColor = System.Drawing.Color.White;
                btn2.Click += delegate(object sender, EventArgs e) { btn2_Click(sender, e, i); };
                this.Controls.Add(btn2);
            }
            StringFormat str = new StringFormat();
            grfx.DrawString("Vh" + " " + i, Font, brush, 115 * cx + x + xx, 10 * cx + cy + yy, str);
            grfx.DrawString("Vl" + " " + i, Font, brush, 115 * cx + x + xx, 13 * cx + cy + yy, str);
            grfx.DrawString("Ih" + " " + i, Font, brush, 115 * cx + x + xx, 16 * cx + cy + yy, str);
            grfx.DrawString("Il" + " " + i, Font, brush, 115 * cx + x + xx, 19 * cx + cy + yy, str);
            grfx.DrawString("Ph" + " " + i, Font, new SolidBrush(Color.DarkViolet), 115 * cx + x + xx, 22 * cx + cy + yy, str);
            grfx.DrawString("Qh" + " " + i, Font, new SolidBrush(Color.DarkViolet), 115 * cx + x + xx, 25 * cx + cy + yy, str);
            grfx.DrawString("pl" + " " + i, Font, new SolidBrush(Color.DarkGreen), 115 * cx + x + xx, 28 * cx + cy + yy, str);
            grfx.DrawString("Ql" + " " + i, Font, new SolidBrush(Color.DarkGreen), 115 * cx + x + xx, 31 * cx + cy + yy, str);
            grfx.DrawString("PlossCable" + " " + i, Font, new SolidBrush(Color.Blue), 115 * cx + x + xx, 34 * cx + cy + yy, str);
            grfx.DrawString("QlossCable" + " " + i, Font, new SolidBrush(Color.Blue), 115 * cx + x + xx, 37 * cx + cy + yy, str);
            grfx.DrawString("PlossTr" + " " + i, Font, new SolidBrush(Color.Red), 115 * cx + x + xx, 40 * cx + cy + yy, str);
            grfx.DrawString("QlossTr" + " " + i, Font, new SolidBrush(Color.Red), 115 * cx + x + xx, 43 * cx + cy + yy, str);

        }

        void btn_Click(object sender, EventArgs e, int i)
        {
            Form3 f3 = new Form3(this, i, n, feeder);
            f3.Show();
        }
        void btn2_Click(object sender, EventArgs e, int i)
        {
            Form4 f4 = new Form4(this, i, n, feeder);
            f4.Show();

        }
        bool afterdrawing = false;
        protected void DrawText(int Xpoint, int cx, int cy, int x, int i, int yy, int xx, int phase)
        {

            i--;
            int y = 10;
            if (firstTime)
            {


                for (int f = 0; f < 12; f++)
                {
                    if (txt[phase, i, f] == null)
                    {
                        txt[phase, i, f] = new TextBox();
                    }
                    //if(!(phase==0&&i==0))
                    txt[phase, i, f].ReadOnly = true;
                    txt[phase, i, f].Location = new Point(Xpoint * cx + x + xx, y * cx + cy + yy);
                    txt[phase, i, f].Size = new Size(5 * 20, 3 * 20);
                    this.Controls.Add(txt[phase, i, f]);

                    y += 3;
                }

            }
            afterdrawing = true;


        }


        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            //f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            int yy = -this.AutoScrollPosition.Y + e.Y;
            int xx = -this.AutoScrollPosition.X + e.X;
            int cx = 5;
            int x = 100;
            if (xx >= 23.5 * cx + x && xx <= 31 * cx + x)
            {
                int y = yy % 200;
                if (y >= 30 * cx && y <= 37.5 * cx)
                {

                    int ind = yy / 100;
                    if (ind >= 0 && ind < switches.Length)
                    {
                        switches[ind] = !switches[ind];
                    }
                    Refresh();
                }
                else if (y >= 20 * cx && y <= 27.5 * cx)
                {

                    int ind = yy / 100 - 1;
                    if (ind >= 0 && ind < switches.Length)
                    {
                        switches[ind] = !switches[ind];
                    }

                    this.Invalidate();
                }
                else
                {
                    this.Text = "";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Random r = new Random();
            // this.Text = r.Next().ToString();
            if (firstTime)
                return;
            if (!afterdrawing) return;

            // this.Text = this.Controls.Count.ToString();
            Random rnd = new Random();
            using (var feader = new PMUEntities())
            {
                var busesId = (from b in feader.buses
                               where b.feederId == feeder
                               select b.busID);
                var arr=busesId.ToArray();
                //double rr;
                for (int j = 0; j < n; j++)
                {
                    for (int phase = 0; phase < 3; phase++)
                    {
                        for (int i = 0; i < 12; i++)
                        {
                           //rr =rnd.NextDouble() * 10;
                           txt[phase, j, i].Text = (rnd.NextDouble() * 10).ToString("0.0000");
                            var id = Guid.NewGuid();
                        }
                        if(phase==0)
                        {
                            var table = feader.Set<Phase1>();
                            table.Add(new Phase1 { busID = arr[j],feederid=feeder, dataTime = DateTime.Now, VhM = double.Parse(txt[phase, j, 0].Text), VlM = double.Parse(txt[phase, j, 1].Text), IhM = double.Parse(txt[phase, j, 2].Text), IlM = double.Parse(txt[phase, j, 3].Text), ph = double.Parse(txt[phase, j, 4].Text), Pl = double.Parse(txt[phase, j, 5].Text), Qh = double.Parse(txt[phase, j, 6].Text), Ql = double.Parse(txt[phase, j, 7].Text), Plosscable = double.Parse(txt[phase, j, 8].Text), Qlosscable = double.Parse(txt[phase, j, 9].Text), Plosstr = double.Parse(txt[phase, j, 10].Text), Qlosstr = double.Parse(txt[phase, j, 11].Text) });
                            feader.SaveChanges();
                        }
                        else if (phase==1)
                        {
                            var table = feader.Set<Phase2>();
                            table.Add(new Phase2 { busID = arr[j],feederid=feeder,dataTime = DateTime.Now, VhM = double.Parse(txt[phase, j, 0].Text), VlM = double.Parse(txt[phase, j, 1].Text), IhM = double.Parse(txt[phase, j, 2].Text), IlM = double.Parse(txt[phase, j, 3].Text), ph = double.Parse(txt[phase, j, 4].Text), Pl = double.Parse(txt[phase, j, 5].Text), Qh = double.Parse(txt[phase, j, 6].Text), Ql = double.Parse(txt[phase, j, 7].Text), Plosscable = double.Parse(txt[phase, j, 8].Text), Qlosscable = double.Parse(txt[phase, j, 9].Text), Plosstr = double.Parse(txt[phase, j, 10].Text), Qlosstr = double.Parse(txt[phase, j, 11].Text) });
                            feader.SaveChanges();
                        }
                        else
                        {
                            var table = feader.Set<Phase3>();
                            table.Add(new Phase3 { busID = arr[j],feederid=feeder, dataTime = DateTime.Now, VhM = double.Parse(txt[phase, j, 0].Text), VlM = double.Parse(txt[phase, j, 1].Text), IhM = double.Parse(txt[phase, j, 2].Text), IlM = double.Parse(txt[phase, j, 3].Text), ph = double.Parse(txt[phase, j, 4].Text), Pl = double.Parse(txt[phase, j, 5].Text), Qh = double.Parse(txt[phase, j, 6].Text), Ql = double.Parse(txt[phase, j, 7].Text), Plosscable = double.Parse(txt[phase, j, 8].Text), Qlosscable = double.Parse(txt[phase, j, 9].Text), Plosstr = double.Parse(txt[phase, j, 10].Text), Qlosstr = double.Parse(txt[phase, j, 11].Text) });
                            feader.SaveChanges();
                        }
                    }
                }
               
                //var table = feader.Set<phase1>();
                //table.Add(new phase1 {busID=3 });
                //feader.SaveChanges();
                //INSERT INTO [dbo].[Phase1] ([busID],[dataTime],[VhM],[VhA],[VlM],[Vla],[IhM],[IhA],[IlM],[IlA]) VALUES(3,'1/1/1990 1:1:3.020',10,20,30,40,50,60,70,80)
            }

        }

    }

}
