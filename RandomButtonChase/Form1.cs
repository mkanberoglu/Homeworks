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
            timer1.Stop();
            button1.Location = new Point(rnd.Next(1, this.Width - 150), rnd.Next(1, this.Height - 46));
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("On saniye hareketsiz kalýndý oyun kapatýlýyor ...");
            this.Close();
        }
    }
}