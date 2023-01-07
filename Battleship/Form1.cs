namespace Battleship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> playerShipLocations;
        List<string> enemyShipLocations;
        public void PlaceShip()
        {
            Random random = new Random();
            random.Next();
        }
    }
}