namespace ButtonGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Walk();
        }
        Point p = new Point(150, 150);
        public void RightoftheScreen(System.Windows.Forms.Button b)
        {
            //Checking if the button is in the end of the line
            if (b.Location.X + 30 >= Size.Width)
            {
                b.Location = new Point(b.Location.X, b.Location.Y + 30);
            }
        }
        public void LeftoftheScreen(System.Windows.Forms.Button b)
        {
            //Checking if the button is in the begining of the line
            if (b.Location.X - 45 >= 0)
            {
                b.Location = new Point(b.Location.X, b.Location.Y + 30);
            }
        }
        public void MoveRight(System.Windows.Forms.Button b)
        {
            b.Location = new Point(b.Location.X + 30, b.Location.Y);
        }
        public void MoveLeft(System.Windows.Forms.Button b)
        {
            b.Location = new Point(b.Location.X - 30, b.Location.Y);
        }
        public void MoveDown(Button b)
        {
            b.Location = new Point(b.Location.X, b.Location.Y + 30);
        }
        public void MoveUp(Button b)
        {
            b.Location = new Point(b.Location.X, b.Location.Y - 30);
        }
        private void Walk()
        {
            int xAxis = this.button1.Location.X;
            int yAxis = this.button1.Location.Y;
            switch (yAxis)
            {
                case 0:
                    MoveRight(this.button1);
                    RightoftheScreen(this.button1);
                    break;
                case 30:
                    MoveLeft(this.button1);
                    LeftoftheScreen(this.button1);
                    break;
                case 210:
                    this.button1.Location = new Point(0, 0);
                    //MessageBox.Show("Oyun bitti tebrikler ...");
                    break;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Walk();
        }
    }
}