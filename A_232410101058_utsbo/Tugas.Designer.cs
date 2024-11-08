namespace A_232410101058_utsbo
{
    partial class Tugas
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
            dataGridView1 = new DataGridView();
            Judul = new DataGridViewTextBoxColumn();
            Deskripsi = new DataGridViewTextBoxColumn();
            Deadline = new DataGridViewTextBoxColumn();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Judul, Deskripsi, Deadline });
            dataGridView1.Location = new Point(189, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 59);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Judul
            // 
            Judul.HeaderText = "Judul";
            Judul.MinimumWidth = 6;
            Judul.Name = "Judul";
            Judul.Width = 125;
            // 
            // Deskripsi
            // 
            Deskripsi.HeaderText = "Deskripsi";
            Deskripsi.MinimumWidth = 6;
            Deskripsi.Name = "Deskripsi";
            Deskripsi.Width = 125;
            // 
            // Deadline
            // 
            Deadline.HeaderText = "Deadline";
            Deadline.MinimumWidth = 6;
            Deadline.Name = "Deadline";
            Deadline.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Aesthetric", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(292, 30);
            label1.Name = "label1";
            label1.Size = new Size(209, 67);
            label1.TabIndex = 1;
            label1.Text = "Tugas";
            label1.Click += label1_Click;
            // 
            // Tugas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Tugas";
            Text = "Tugas";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewTextBoxColumn Deskripsi;
        private DataGridViewTextBoxColumn Deadline;
        private Label label1;
    }
}