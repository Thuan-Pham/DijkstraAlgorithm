
namespace WinFormsApp1
{
    partial class Dijkstra
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Locations = new System.Windows.Forms.ListBox();
            this.Find = new System.Windows.Forms.GroupBox();
            this.Distance = new System.Windows.Forms.Label();
            this.Show = new System.Windows.Forms.Label();
            this.FindWay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.To = new System.Windows.Forms.ComboBox();
            this.From = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Find.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Locations);
            this.groupBox1.Location = new System.Drawing.Point(13, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locations List";
            // 
            // Locations
            // 
            this.Locations.FormattingEnabled = true;
            this.Locations.ItemHeight = 20;
            this.Locations.Location = new System.Drawing.Point(6, 26);
            this.Locations.Name = "Locations";
            this.Locations.Size = new System.Drawing.Size(148, 384);
            this.Locations.TabIndex = 0;
            this.Locations.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Find
            // 
            this.Find.Controls.Add(this.Distance);
            this.Find.Controls.Add(this.Show);
            this.Find.Controls.Add(this.FindWay);
            this.Find.Controls.Add(this.label2);
            this.Find.Controls.Add(this.To);
            this.Find.Controls.Add(this.From);
            this.Find.Controls.Add(this.label1);
            this.Find.Location = new System.Drawing.Point(179, 54);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(483, 148);
            this.Find.TabIndex = 1;
            this.Find.TabStop = false;
            this.Find.Text = "Find the shortest way";
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(120, 117);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(0, 20);
            this.Distance.TabIndex = 6;
            // 
            // Show
            // 
            this.Show.AutoSize = true;
            this.Show.Location = new System.Drawing.Point(120, 93);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(0, 20);
            this.Show.TabIndex = 5;
            // 
            // FindWay
            // 
            this.FindWay.Location = new System.Drawing.Point(6, 89);
            this.FindWay.Name = "FindWay";
            this.FindWay.Size = new System.Drawing.Size(103, 29);
            this.FindWay.TabIndex = 4;
            this.FindWay.Text = "Find";
            this.FindWay.UseVisualStyleBackColor = true;
            this.FindWay.Click += new System.EventHandler(this.FindWay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // To
            // 
            this.To.FormattingEnabled = true;
            this.To.Location = new System.Drawing.Point(214, 38);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(122, 28);
            this.To.TabIndex = 2;
            // 
            // From
            // 
            this.From.FormattingEnabled = true;
            this.From.Location = new System.Drawing.Point(55, 38);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(122, 28);
            this.From.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(43, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(593, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIJKSTRA ALGORITHM TO FIND \r\nTHE SHORTEST PATH OF TOURIST LOCATIONS IN HO CHI MIN" +
    "H CITY";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::WinFormsApp1.Properties.Resources._318487841_479426044295747_1496603914131831976_n;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources._318487841_479426044295747_1496603914131831976_n1;
            this.pictureBox1.InitialImage = global::WinFormsApp1.Properties.Resources._318487841_479426044295747_1496603914131831976_n;
            this.pictureBox1.Location = new System.Drawing.Point(179, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(483, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 481);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show Matrix";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.groupBox1);
            this.Name = "Dijkstra";
            this.Text = "Dijkstra Algorithm";
            this.Load += new System.EventHandler(this.Dijkstra_Load);
            this.groupBox1.ResumeLayout(false);
            this.Find.ResumeLayout(false);
            this.Find.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox Locations;
        private System.Windows.Forms.GroupBox Find;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox To;
        private System.Windows.Forms.ComboBox From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FindWay;
        private System.Windows.Forms.Label Show;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

