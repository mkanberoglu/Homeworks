namespace MemoryGame
{   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.imGen = new ImageHelper();
            pictureBox1.Image = imGen.backgroundImage;
            pictureBox2.Image = imGen.backgroundImage;
            pictureBox3.Image = imGen.backgroundImage;
            pictureBox4.Image = imGen.backgroundImage;
            pictureBox5.Image = imGen.backgroundImage;
            pictureBox6.Image = imGen.backgroundImage;
            pictureBox7.Image = imGen.backgroundImage;
            pictureBox8.Image = imGen.backgroundImage;
            this.shuffledImages = imGen.images;
            this.containers = new List<Container> { new Container(0, 0, imGen.images[0]), new Container(1, 0, imGen.images[1]),
                new Container(2, 0, imGen.images[2]), new Container(3, 0, imGen.images[3]), new Container(4, 0, imGen.images[4]),
                new Container(5, 0, imGen.images[5]), new Container(6, 0, imGen.images[6]), new Container(7, 0, imGen.images[7]) };
            this.pairs = FindPairs();
            this.openedImages = 0;
            this.pics = new List<int>();
            this.picsBoxList = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7, pictureBox8 };
        }
        public Dictionary<int, int> FindPairs()
        {
            Dictionary<int, int> pairs1 = new Dictionary<int, int>();
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (containers[i].image.PropertyIdList == containers[j].image.PropertyIdList)
                    {
                        pairs1.Add(i, j);
                        continue;
                    }
                }
            }
            return pairs1;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (/*resme�zel*/containers[0].status == 0) 
            {
                /*butona�zel*/pictureBox1.Image = /*resme�zel*/containers[0].image;
                /*resme�zel*/containers[0].status = 1;
                /*resme�zel*/pics.Add(0);
                openedImages++;
                if(openedImages > 1)
                {
                    if(containers[/*resme�zel*/pairs[0]].status == 1)
                    {
                        containers[/*resme�zel*/pairs[0]].status = 2;
                        /*resme�zel*/containers[0].status = 2;
                        openedImages -= 2;
                    }
                    else
                    {
                        picsBoxList[pics[0]].Image = imGen.backgroundImage;
                        picsBoxList[pics[1]].Image = imGen.backgroundImage;
                        containers[pics[0]].status = 0;
                        containers[pics[1]].status = 0;
                        pics = new List<int>(2);
                        openedImages -= 2;
                    }
                }
                
            }
            else if(containers[0].status == 1)
            {
                pictureBox1.Image= imGen.backgroundImage;
                containers[0].status = 0;
                openedImages--;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (/*resme�zel*/containers[1].status == 0)
            {
                /*butona�zel*/
                pictureBox2.Image = /*resme�zel*/containers[1].image;
                /*resme�zel*/
                containers[1].status = 1;
                /*resme�zel*/
                pics.Add(1);
                openedImages++;
                if (openedImages > 1)
                {
                    if (containers[/*resme�zel*/pairs[1]].status == 1)
                    {
                        containers[/*resme�zel*/pairs[1]].status = 2;
                        /*resme�zel*/
                        containers[1].status = 2;
                        openedImages -= 2;
                    }
                    else
                    {
                        picsBoxList[pics[0]].Image = imGen.backgroundImage;
                        picsBoxList[pics[1]].Image = imGen.backgroundImage;
                        containers[pics[0]].status = 0;
                        containers[pics[1]].status = 0;
                        pics = new List<int>(2);
                        openedImages -= 2;
                    }
                }

            }
            else if (containers[1].status == 1)
            {
                pictureBox2.Image = imGen.backgroundImage;
                containers[1].status = 0;
                openedImages--;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (/*resme�zel*/containers[2].status == 0)
            {
                /*butona�zel*/
                pictureBox3.Image = /*resme�zel*/containers[2].image;
                /*resme�zel*/
                containers[2].status = 1;
                /*resme�zel*/
                pics.Add(2);
                openedImages++;
                if (openedImages > 1)
                {
                    if (containers[/*resme�zel*/pairs[2]].status == 1)
                    {
                        containers[/*resme�zel*/pairs[2]].status = 2;
                        /*resme�zel*/
                        containers[2].status = 2;
                        openedImages -= 2;
                    }
                    else
                    {
                        picsBoxList[pics[0]].Image = imGen.backgroundImage;
                        picsBoxList[pics[1]].Image = imGen.backgroundImage;
                        containers[pics[0]].status = 0;
                        containers[pics[1]].status = 0;
                        pics = new List<int>(2);
                        openedImages -= 2;
                    }
                }

            }
            else if (containers[2].status == 1)
            {
                pictureBox3.Image = imGen.backgroundImage;
                containers[2].status = 0;
                openedImages--;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (/*resme�zel*/containers[3].status == 0)
            {
                /*butona�zel*/
                pictureBox4.Image = /*resme�zel*/containers[3].image;
                /*resme�zel*/
                containers[3].status = 1;
                /*resme�zel*/
                pics.Add(3);
                openedImages++;
                if (openedImages > 1)
                {
                    if (containers[/*resme�zel*/pairs[3]].status == 1)
                    {
                        containers[/*resme�zel*/pairs[3]].status = 2;
                        /*resme�zel*/
                        containers[3].status = 2;
                        openedImages -= 2;
                    }
                    else
                    {
                        picsBoxList[pics[0]].Image = imGen.backgroundImage;
                        picsBoxList[pics[1]].Image = imGen.backgroundImage;
                        containers[pics[0]].status = 0;
                        containers[pics[1]].status = 0;
                        pics = new List<int>(2);
                        openedImages -= 2;
                    }
                }

            }
            else if (containers[3].status == 1)
            {
                pictureBox4.Image = imGen.backgroundImage;
                containers[3].status = 0;
                openedImages--;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (/*resme�zel*/containers[4].status == 0)
            {
                /*butona�zel*/
                pictureBox5.Image = /*resme�zel*/containers[4].image;
                /*resme�zel*/
                containers[4].status = 1;
                /*resme�zel*/
                pics.Add(4);
                openedImages++;
                if (openedImages > 1)
                {
                    if (containers[/*resme�zel*/pairs[4]].status == 1)
                    {
                        containers[/*resme�zel*/pairs[4]].status = 2;
                        /*resme�zel*/
                        containers[4].status = 2;
                        openedImages -= 2;
                    }
                    else
                    {
                        picsBoxList[pics[0]].Image = imGen.backgroundImage;
                        picsBoxList[pics[1]].Image = imGen.backgroundImage;
                        containers[pics[0]].status = 0;
                        containers[pics[1]].status = 0;
                        pics = new List<int>(2);
                        openedImages -= 2;
                    }
                }

            }
            else if (containers[4].status == 1)
            {
                pictureBox5.Image = imGen.backgroundImage;
                containers[4].status = 0;
                openedImages--;
                
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (/*resme�zel*/containers[5].status == 0)
            {
                /*butona�zel*/
                pictureBox6.Image = /*resme�zel*/containers[5].image;
                /*resme�zel*/
                containers[5].status = 1;
                /*resme�zel*/
                pics.Add(5);
                openedImages++;
                if (openedImages > 1)
                {
                    if (containers[/*resme�zel*/pairs[5]].status == 1)
                    {
                        containers[/*resme�zel*/pairs[5]].status = 2;
                        /*resme�zel*/
                        containers[5].status = 2;
                        openedImages -= 2;
                    }
                    else
                    {
                        picsBoxList[pics[0]].Image = imGen.backgroundImage;
                        picsBoxList[pics[1]].Image = imGen.backgroundImage;
                        containers[pics[0]].status = 0;
                        containers[pics[1]].status = 0;
                        pics = new List<int>(2);
                        openedImages -= 2;
                    }
                }

            }
            else if (containers[5].status == 1)
            {
                pictureBox6.Image = imGen.backgroundImage;
                containers[5].status = 0;
                openedImages--;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (/*resme�zel*/containers[6].status == 0)
            {
                /*butona�zel*/
                pictureBox7.Image = /*resme�zel*/containers[6].image;
                /*resme�zel*/
                containers[6].status = 1;
                /*resme�zel*/
                pics.Add(6);
                openedImages++;
                if (openedImages > 1)
                {
                    if (containers[/*resme�zel*/pairs[6]].status == 1)
                    {
                        containers[/*resme�zel*/pairs[6]].status = 2;
                        /*resme�zel*/
                        containers[6].status = 2;
                        openedImages -= 2;
                    }
                    else
                    {
                        picsBoxList[pics[0]].Image = imGen.backgroundImage;
                        picsBoxList[pics[1]].Image = imGen.backgroundImage;
                        containers[pics[0]].status = 0;
                        containers[pics[1]].status = 0;
                        pics = new List<int>(2);
                        openedImages -= 2;
                    }
                }

            }
            else if (containers[6].status == 1)
            {
                pictureBox7.Image = imGen.backgroundImage;
                containers[6].status = 0;
                openedImages--;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (/*resme�zel*/containers[7].status == 0)
            {
                /*butona�zel*/
                pictureBox8.Image = /*resme�zel*/containers[7].image;
                /*resme�zel*/
                containers[7].status = 1;
                /*resme�zel*/
                pics.Add(7);
                openedImages++;
                if (openedImages > 1)
                {
                    if (containers[/*resme�zel*/pairs[7]].status == 1)
                    {
                        containers[/*resme�zel*/pairs[7]].status = 2;
                        /*resme�zel*/
                        containers[7].status = 2;
                        openedImages -= 2;
                    }
                    else
                    {
                        picsBoxList[pics[0]].Image = imGen.backgroundImage;
                        picsBoxList[pics[1]].Image = imGen.backgroundImage;
                        containers[pics[0]].status = 0;
                        containers[pics[1]].status = 0;
                        pics = new List<int>(2);
                        openedImages -= 2;
                    }
                }

            }
            else if (containers[7].status == 1)
            {
                pictureBox8.Image = imGen.backgroundImage;
                containers[7].status = 0;
                openedImages--;
            }
        }
    }
    public class ImageHelper
    {
        public Image[] images;
        public Image backgroundImage;
        //public Pair[] pairs;
        //private int pairCount;
        public ImageHelper()
        {
            images = new Image[8];
            images[0] = Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\MemoryGame\assets\four.png");
            images[1] = Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\MemoryGame\assets\four.png");
            images[2] = Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\MemoryGame\assets\three.png");
            images[3] = Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\MemoryGame\assets\three.png");
            images[4] = Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\MemoryGame\assets\two.png");
            images[5] = Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\MemoryGame\assets\two.png");
            images[6] = Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\MemoryGame\assets\one.png");
            images[7] = Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\MemoryGame\assets\one.png");
            this.backgroundImage = Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\MemoryGame\assets\background.png");
            Random random = new Random();
            images = images.OrderBy(x => random.Next()).ToArray();
            //this.pairCount = 0;
            //this.pairs = new Pair[4];
            //int i = 0;
            //while(pairCount < 4)
            //{
                
            //}
        }
    }
    //public class Pair 
    //{
    //    public int x;
    //    public int y;
    //    public Pair(int x, int y)
    //    {
    //        this.x = x;
    //        this.y = y;
    //    }
    //}
    public class Container
    {
        public byte index { get; set; }
        public byte status { get; set; }
        public Image image { get; set; }
        public Container(byte index, byte status, Image image)
        {
            this.index = index;
            this.status = status;
            this.image = image;
        }
    }
}