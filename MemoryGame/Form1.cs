namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Image> listImage = new List<Image>();
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public void RastgeleResimSec()
        {
            listImage.Clear();
            List<Image> list = new List<Image>();

            for (int i = 0; i < formImageList.Images.Count; i++)
            {
                list.Add(formImageList.Images[i]);
            }
            for (int i = 0; i < pictureBoxes.Count / 2; i++)
            {
                int index = random.Next(0, list.Count);

                Image img = list[index];

                listImage.Add(img);
                listImage.Add(img);

                list.Remove(img);
            }
            listImage = listImage.OrderBy(x => random.Next()).ToList();
        }
        private void SetPictureBoxes()
        {
            pictureBoxes.Clear();

            foreach (var item in Controls)
            {
                if (item is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)item;

                    pictureBox.Click += pictureBox_Click;

                    pictureBox.Visible = true;

                    pictureBox.Image = null;

                    pictureBoxes.Add(pictureBox);
                }
            }
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            SetPictureBoxes();
            RastgeleResimSec();
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (listImage.Count <= 0) return;

            if (timer1.Enabled) return;

            PictureBox pictureBox = (PictureBox)sender;
            int index = pictureBoxes.IndexOf(pictureBox);
            pictureBox.Image = listImage[index];
            int count = GetOpenedImage();

            if (count >= 2)
            {
                int differentCount = GetOpenedDifferentCount();
                timer1.Start();
            }
        }

        private void RemoveOpenedImages()
        {
            List<PictureBox> removeds = new List<PictureBox>();

            foreach (var item in pictureBoxes)
            {
                if (item.Image != null)
                {
                    item.Enabled = false;
                    
                    listImage.Remove(item.Image);
                    removeds.Add(item);
                }
            }

            foreach (var item in removeds)
            {
                pictureBoxes.Remove(item);
            }
        }

        private void CloseAllImages()
        {
            foreach (var item in pictureBoxes)
            {
                item.Image = null;
            }
        }

        private int GetOpenedImage()
        {
            int count = 0;

            foreach (var item in pictureBoxes)
            {
                if (item.Image != null)
                {
                    count++;
                }
            }

            return count;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            int count = GetOpenedDifferentCount();

            if (count == 1)
            {
                RemoveOpenedImages();
            }
            else
            {
                CloseAllImages();
            }

            timer1.Stop();

            if (pictureBoxes.Count == 0)
            {
                MessageBox.Show("Kazandýnýz...");
            }


        }


        private int GetOpenedDifferentCount()
        {
            List<Image> list = new List<Image>();


            foreach (var item in pictureBoxes)
            {
                if (item.Image != null)
                {
                    if (!list.Contains(item.Image))
                    {
                        list.Add(item.Image);
                    }
                }
            }

            return list.Count;
        }
    }
}
