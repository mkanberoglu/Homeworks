namespace RandomButtonChase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(rnd.Next(1, this.Width - 150), rnd.Next(1, this.Height - 46));
        }
    }
}