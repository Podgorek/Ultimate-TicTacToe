namespace WinFormsApp1
{
    public partial class TwoTextBoxes : Form
    {
        public static List<string> names = new List<string>();
        public TwoTextBoxes()
        {
            InitializeComponent();
        }
        public static int num_of_players;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(194, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "player1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(194, 27);
            textBox2.TabIndex = 2;
            textBox2.Text = "player2";
            // 
            // button1
            // 
            button1.Location = new Point(242, 205);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TwoTextBoxes
            // 
            ClientSize = new Size(557, 302);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TwoTextBoxes";
            Text = "Ultimate Tic Tac Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        private void TwoTextBoxes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            names.Add(textBox1.Text);
            names.Add(textBox2.Text);
            Application.Exit();
        }

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
