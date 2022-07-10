using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bodyWeightMeasurements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Graphics g;

        public class recordsBWM
        {
            public float m;
            public DateTime dt;

            public recordsBWM() { }
            public recordsBWM(float pm) {
                this.m = pm;
              
            }
           
        }
        public class bwmc
        {
            public List<recordsBWM> records = new List<recordsBWM>();
         
            public bwmc() { }
            public void addnew(recordsBWM pr) {
                records.Add(pr);
            }
            public void drawGraphic(int start, int end, ref Graphics pg  ) 
            {
                for (int i = start - 1; i < end; i++)
                {
                    pg.DrawLine(new Pen(Color.Black,5), i*10, records[i].m, i*10, 900);
                }
            }
        }

        public bwmc eu = new bwmc();

        private void Form1_Load(object sender, EventArgs e)
        {
            g = CreateGraphics();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                eu.addnew(new recordsBWM(103.0f));
                eu.addnew(new recordsBWM(102.0f));
                eu.addnew(new recordsBWM(101.0f));
                eu.addnew(new recordsBWM(102.0f));
                eu.addnew(new recordsBWM(103.0f));
                eu.addnew(new recordsBWM(104.0f));
                eu.addnew(new recordsBWM(103.0f));
                eu.addnew(new recordsBWM(102.0f));
                eu.addnew(new recordsBWM(101.0f));
                eu.addnew(new recordsBWM(100.0f));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eu.drawGraphic(1, 10, ref this.g);
        }
    }
}
