
namespace WinFormsApp1
{
    partial class Matrix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blank,
            this.D2,
            this.D3,
            this.D4,
            this.D5,
            this.D6,
            this.D7,
            this.D8,
            this.D9,
            this.D10});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(467, 388);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // blank
            // 
            this.blank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.blank.HeaderText = " ";
            this.blank.MinimumWidth = 6;
            this.blank.Name = "blank";
            this.blank.ReadOnly = true;
            this.blank.Width = 42;
            // 
            // D2
            // 
            this.D2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D2.HeaderText = "0";
            this.D2.MinimumWidth = 6;
            this.D2.Name = "D2";
            this.D2.ReadOnly = true;
            this.D2.Width = 46;
            // 
            // D3
            // 
            this.D3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D3.HeaderText = "1";
            this.D3.MinimumWidth = 6;
            this.D3.Name = "D3";
            this.D3.ReadOnly = true;
            this.D3.Width = 46;
            // 
            // D4
            // 
            this.D4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D4.HeaderText = "2";
            this.D4.MinimumWidth = 6;
            this.D4.Name = "D4";
            this.D4.ReadOnly = true;
            this.D4.Width = 46;
            // 
            // D5
            // 
            this.D5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D5.HeaderText = "3";
            this.D5.MinimumWidth = 6;
            this.D5.Name = "D5";
            this.D5.ReadOnly = true;
            this.D5.Width = 46;
            // 
            // D6
            // 
            this.D6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D6.HeaderText = "4";
            this.D6.MinimumWidth = 6;
            this.D6.Name = "D6";
            this.D6.ReadOnly = true;
            this.D6.Width = 46;
            // 
            // D7
            // 
            this.D7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D7.HeaderText = "5";
            this.D7.MinimumWidth = 6;
            this.D7.Name = "D7";
            this.D7.ReadOnly = true;
            this.D7.Width = 46;
            // 
            // D8
            // 
            this.D8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D8.HeaderText = "6";
            this.D8.MinimumWidth = 6;
            this.D8.Name = "D8";
            this.D8.ReadOnly = true;
            this.D8.Width = 46;
            // 
            // D9
            // 
            this.D9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D9.HeaderText = "7";
            this.D9.MinimumWidth = 6;
            this.D9.Name = "D9";
            this.D9.ReadOnly = true;
            this.D9.Width = 46;
            // 
            // D10
            // 
            this.D10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.D10.HeaderText = "8";
            this.D10.MinimumWidth = 6;
            this.D10.Name = "D10";
            this.D10.ReadOnly = true;
            this.D10.Width = 46;
            // 
            // Matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 412);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Matrix";
            this.Text = "Matrix";
            this.Load += new System.EventHandler(this.Matrix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn blank;
        private System.Windows.Forms.DataGridViewTextBoxColumn D2;
        private System.Windows.Forms.DataGridViewTextBoxColumn D3;
        private System.Windows.Forms.DataGridViewTextBoxColumn D4;
        private System.Windows.Forms.DataGridViewTextBoxColumn D5;
        private System.Windows.Forms.DataGridViewTextBoxColumn D6;
        private System.Windows.Forms.DataGridViewTextBoxColumn D7;
        private System.Windows.Forms.DataGridViewTextBoxColumn D8;
        private System.Windows.Forms.DataGridViewTextBoxColumn D9;
        private System.Windows.Forms.DataGridViewTextBoxColumn D10;
    }
}