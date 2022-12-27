namespace ChasingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
        }
        public void RightoftheScreen(Button b)
        {
            //Checking if the button is in the end of the line
            if (b.Location.X + 70 > Size.Width)
            {
                b.Location = new Point(b.Location.X - 1, b.Location.Y);
                Walker(b);
            }
        }
        public void Walker(Button b) 
        {
            for(int i = 0; i < 30; i++) 
            {
                b.Location = new Point(b.Location.X, b.Location.Y + 1);
            }
        }
        public void LeftoftheScreen(Button b)
        {
            //Checking if the button is in the begining of the line
            if (b.Location.X < 0)
            {
                b.Location = new Point(b.Location.X + 1, b.Location.Y);
                Walker(b);
                
            }
        }
        public void MoveRight(Button b)
        {
            b.Location = new Point(b.Location.X + 1, b.Location.Y);
        }
        public void MoveLeft(Button b)
        {
            b.Location = new Point(b.Location.X - 1, b.Location.Y);
        }
        private void Walk()
        {
            Button b = button1;
            int yAxis = b.Location.Y;
            switch (yAxis)
            {
                case 0:
                    MoveRight(b);
                    RightoftheScreen(b);
                    break;
                case 30:
                    MoveLeft(b);
                    LeftoftheScreen(b);
                    break;
                case 60:
                    MoveRight(b);
                    RightoftheScreen(b);
                    break;
                case 90:
                    MoveLeft(b);
                    LeftoftheScreen(b);
                    break;
                case 120:
                    MoveRight(b);
                    RightoftheScreen(b);
                    break;
                case 150:
                    MoveLeft(b);
                    LeftoftheScreen(b);
                    break;
                case 180:
                    MoveRight(b);
                    RightoftheScreen(b);
                    break;
                    
                case 210:
                    b.Location = new Point(0, 0);
                    MessageBox.Show("Oyun bitti tebrikler ...");
                    
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Walk();
        }
    }
}