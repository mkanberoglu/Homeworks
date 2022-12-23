namespace ChasingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*arkada�lar �deviniz fare imleci ile buton kovalamak olacak.
         * ekranda bir butonunuz olacak fare ile �zerine geldi�imde bir ad�m ilerleyecek ekran�n sonuna geldi�inde bir alt sat�ra ge�ecek
         * (sol �st k��eden ba�lam��san�z sat�r sonundan a�a�� inecek ve sa�dan sola gitmeye ba�layacak).
         * 7. sat�r�n sonunda ekrarna oyun bitti diye mesaj basacak.
         */
        public void RightoftheScreen(Button b)
        {
            //Checking if the button is in the end of the line
            if (b.Location.X + 71 > Size.Width)
            {
                b.Location = new Point(b.Location.X - 70, b.Location.Y + 30);
            }
        }
        public void LeftoftheScreen(Button b)
        {
            //Checking if the button is in the begining of the line
            if (b.Location.X < 0)
            {
                b.Location = new Point(b.Location.X + 70, b.Location.Y + 30);
            }
        }
        public void MoveRight(Button b)
        {
            b.Location = new Point(b.Location.X + 70, b.Location.Y);
        }
        public void MoveLeft(Button b)
        {
            b.Location = new Point(b.Location.X - 70, b.Location.Y);
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
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
                    MessageBox.Show("Oyun bitti tebrikler ...");
                    b.Location = new Point(0, 0);
                    break;
            }
            /*
            if (b.Location.Y < 30)
            {
                b.Location = new Point(b.Location.X + 70, b.Location.Y);
                if (b.Location.X + 100 > Size.Width)
                {
                    b.Location = new Point(b.Location.X - 70, b.Location.Y + 45);
                }
            }
            else if (b.Location.Y > 30 && b.Location.Y < 60)
            {
                b.Location = new Point(b.Location.X - 70, b.Location.Y);
                if (b.Location.X < 0)
                {
                    b.Location = new Point(b.Location.X + 70, b.Location.Y + 45);
                }
            }
            else if (b.Location.Y > 60 && b.Location.Y < 120)
            {
                b.Location = new Point(b.Location.X + 70, b.Location.Y);
                if (b.Location.X + 100 > Size.Width)
                {
                    b.Location = new Point(b.Location.X - 70, b.Location.Y + 45);
                }
            }
            else if (b.Location.Y > 120 && b.Location.Y < 150)
            {
                b.Location = new Point(b.Location.X - 70, b.Location.Y);
                if (b.Location.X < 0)
                {
                    b.Location = new Point(b.Location.X + 70, b.Location.Y + 45);
                }
            }
            else if (b.Location.Y > 150 && b.Location.Y < 190)
            {
                b.Location = new Point(b.Location.X + 70, b.Location.Y);
                if (b.Location.X + 100 > Size.Width)
                {
                    b.Location = new Point(b.Location.X - 70, b.Location.Y + 45);
                }
            }
            else if (b.Location.Y > 190 && b.Location.Y < 250)
            {
                b.Location = new Point(b.Location.X - 70, b.Location.Y);
                if (b.Location.X < 0)
                {
                    b.Location = new Point(b.Location.X + 70, b.Location.Y + 45);
                }
            }
            else if (b.Location.Y > 250 && b.Location.Y < 300)
            {
                b.Location = new Point(b.Location.X + 70, b.Location.Y);
                if (b.Location.X + 100 > Size.Width)
                {
                    b.Location = new Point(b.Location.X - 70, b.Location.Y + 45);
                }
            }
            else if (b.Location.Y > 300)
            {
                MessageBox.Show("Oyun bitti tebrikler ...");
                b.Location = new Point(0, 0);
            }
            /*
            
            else
            {
                b.Location = new Point(b.Location.X + 75);
            }*/
        }
    }
}