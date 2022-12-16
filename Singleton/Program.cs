using System.Drawing;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Singleton nesne formatı:");
                Console.WriteLine(SingletonImage.Instance.img.RawFormat);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Lazy singleton nesne formatı:");
                Console.WriteLine(LazySingletonImage.Instance.img.RawFormat);
            }
            catch(Exception e) 
            { 
                Console.WriteLine(e.Message); 
            }

        }
    }
    public sealed class SingletonImage
    {
        private static SingletonImage instance = null;
        public Image img;
        
        private SingletonImage()
        {
            this.img = (Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\Singleton\unity.png"));
        }

        public static SingletonImage Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonImage();
                }
                return instance;
            }
        }
    }
    public sealed class LazySingletonImage
    {
        private static readonly Lazy<LazySingletonImage> lazyInstance =
            new Lazy<LazySingletonImage>(() =>
            {
                return new LazySingletonImage();
            });
        public Image img;

        public static LazySingletonImage Instance { get { return Lazy.Value; } }

        public static Lazy<LazySingletonImage> Lazy => lazyInstance;

        private LazySingletonImage()
        {
            this.img = (Image.FromFile(@"C:\Users\mkanb\source\repos\Homeworks\Singleton\unity.png"));
        }
    }
}