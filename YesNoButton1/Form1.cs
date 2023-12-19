namespace YesNoButton1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks, I knew you were stupid 🤝💀!");
            Close();
        }
        private void No_btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int x = random.Next(0, ClientSize.Width - No_btn.Width);
            int y = random.Next(0, ClientSize.Height - No_btn.Height);
            No_btn.Location = new Point(x, y);
        }
    }
}
