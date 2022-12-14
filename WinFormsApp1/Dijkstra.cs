using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using WinFormsApp1;

namespace WinFormsApp1
{
    public partial class Dijkstra : Form
    {
        public Dijkstra()
        {
            InitializeComponent();
            label3.Font = new Font("Murtuza", 10);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dijkstra_Load(object sender, EventArgs e)
        {
            string[] VertexData = File.ReadAllLines(@"VertexList.txt");
            foreach (var line in VertexData)
            {
                string[] s = line.Split(" ");
                string str = s[0].Substring(0,1);
                Locations.Items.Add(str+" "+s[0].Substring(1));
                From.Items.Add(s[0].Substring(1));
                To.Items.Add(s[0].Substring(1));
            }

        }

        private void FindWay_Click(object sender, EventArgs e)
        {
            Graph theGraph = new Graph();
            theGraph.result = "";
            theGraph.startToCurrent = 0;
            int from = From.SelectedIndex;
            int to = To.SelectedIndex;
            if (from == -1 || to == -1)
                MessageBox.Show("Vui long chon diem bat dau va ket thuc!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            theGraph.Path(from, to);
            if (theGraph.startToCurrent ==0)
            {
                MessageBox.Show("Trung dia diem!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Show.Text = theGraph.result;
                Distance.Text = ">>Distance: " + theGraph.startToCurrent.ToString("#.##") + "km";
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix matrix = new Matrix();
            matrix.Show();
        }
    }
}
