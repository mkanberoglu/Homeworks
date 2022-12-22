namespace ChasingButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*arkadaþlar ödeviniz fare imleci ile buton kovalamak olacak.
         * ekranda bir butonunuz olacak fare ile üzerine geldiðimde bir adým ilerleyecek ekranýn sonuna geldiðinde bir alt satýra geçecek
         * (sol üst köþeden baþlamýþsanýz satýr sonundan aþaðý inecek ve saðdan sola gitmeye baþlayacak).
         * 7. satýrýn sonunda ekrarna oyun bitti diye mesaj basacak.
         */
        private void button1_MouseHover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
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
        public void CheckRowEnd()
        {

        }
    }
}