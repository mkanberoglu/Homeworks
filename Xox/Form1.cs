namespace Xox
{
    public partial class Form1 : Form
    {
        private string player = "X";
        public Form1()
        {
            InitializeComponent();
            label1.Text = player;
 
        }
        private int openCount = 0;
        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(!string.IsNullOrEmpty(b.Text)) return;
            b.Text = player;
            openCount++;

            if(player == "X")
            {
                player = "O";
            }
            else { player = "X"; }
            label1.Text = player;
            if(openCount >= 3)
            {
                CheckMatches();
            }
        }
        private void CheckMatches()
        {
            //Birinci button
            if(button1.Text == button4.Text && button4.Text == button7.Text && !string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button4.Text) && !string.IsNullOrEmpty(button7.Text))
            {
                DialogResult dialogResult = MessageBox.Show($"{button1.Text} kazandý oyun bitti ... \n\rTekrar oynamak ister misiniz ?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (button1.Text == button2.Text && button2.Text == button3.Text && !string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button2.Text) && !string.IsNullOrEmpty(button3.Text))
            {
                DialogResult dialogResult = MessageBox.Show($"{button1.Text} kazandý oyun bitti ... \n\rTekrar oynamak ister misiniz ?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (button1.Text == button5.Text && button5.Text == button9.Text && !string.IsNullOrEmpty(button1.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button9.Text))
            {
                DialogResult dialogResult = MessageBox.Show($"{button1.Text} kazandý oyun bitti ... \n\rTekrar oynamak ister misiniz ?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            //Ýkinci button
            else if (button2.Text == button5.Text && button5.Text == button8.Text && !string.IsNullOrEmpty(button2.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button8.Text))
            {
                DialogResult dialogResult = MessageBox.Show($"{button1.Text} kazandý oyun bitti ... \n\rTekrar oynamak ister misiniz ?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            //Üçüncü button
            else if (button3.Text == button6.Text && button6.Text == button9.Text && !string.IsNullOrEmpty(button3.Text) && !string.IsNullOrEmpty(button6.Text) && !string.IsNullOrEmpty(button9.Text) )
            {
                DialogResult dialogResult = MessageBox.Show($"{button1.Text} kazandý oyun bitti ... \n\rTekrar oynamak ister misiniz ?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            else if (button3.Text == button5.Text && button5.Text == button7.Text && !string.IsNullOrEmpty(button3.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button7.Text) )
            {
                DialogResult dialogResult = MessageBox.Show($"{button1.Text} kazandý oyun bitti ... \n\rTekrar oynamak ister misiniz ?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            //Dördüncü button
            else if (button4.Text == button5.Text && button5.Text == button6.Text && !string.IsNullOrEmpty(button4.Text) && !string.IsNullOrEmpty(button5.Text) && !string.IsNullOrEmpty(button6.Text))
            {
                DialogResult dialogResult = MessageBox.Show($"{button1.Text} kazandý oyun bitti ... \n\rTekrar oynamak ister misiniz ?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
            //Beþinci button
            //Altýncý button
            //Yedinci button
            else if (button7.Text == button8.Text && button8.Text == button9.Text && !string.IsNullOrEmpty(button7.Text) && !string.IsNullOrEmpty(button8.Text) && !string.IsNullOrEmpty(button9.Text) )
            {
                DialogResult dialogResult = MessageBox.Show($"{button1.Text} kazandý oyun bitti ... \n\rTekrar oynamak ister misiniz ?", "Game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
            }
        }
    }
}