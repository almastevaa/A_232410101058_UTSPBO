namespace A_232410101058_utsbo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login login1 = new Login();
            this.Hide();
            this.Show();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Aesthetric", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(421, 56);
            label2.Name = "label2";
            label2.Size = new Size(305, 67);
            label2.TabIndex = 2;
            label2.Text = "WELCOME";
            // 
            // button1
            // 
            button1.Location = new Point(496, 149);
            button1.Name = "button1";
            button1.Size = new Size(147, 48);
            button1.TabIndex = 3;
            button1.Text = "Tugas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(496, 236);
            button2.Name = "button2";
            button2.Size = new Size(147, 48);
            button2.TabIndex = 4;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(496, 328);
            button3.Name = "button3";
            button3.Size = new Size(147, 48);
            button3.TabIndex = 5;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(54, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 307);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Landing Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label2;
        private Button button1;
        private Button button2;

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private Button button3;

        private void button3_Click_1(object sender, EventArgs e)
        {
            Login login1 = new Login();
            this.Hide();
            login1.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tugas tugas1 = new Tugas();
            this.Hide();
            tugas1.ShowDialog();
            this.Show();
        }

        private PictureBox pictureBox1;
    }
}
