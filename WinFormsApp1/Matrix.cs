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
    public partial class Matrix : Form
    {
        public Matrix()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataGridView DataGridView = new DataGridView();
        private void Matrix_Load(object sender, EventArgs e)
        {
            Graph theGraph = new Graph();
            theGraph.DisplayMatrix();
            for (int i = 0; i < 9; i++)
            {
                string[] row = new string[10];
                row[0] = i.ToString();
                for (int j = 1 ; j < 10; j++)
                {
                    if (theGraph.adjMat[i, j] == 1000000)
                        row[j] = "inf";
                    else
                        row[j] = theGraph.adjMat[i, j].ToString();
                }
                dataGridView1.Rows.Add(row);
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
