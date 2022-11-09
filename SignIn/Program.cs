using System;

namespace SignIn 
{
    class Program 
    {       
        public static void Main(string[] args)
        {
            //Console.WriteLine();
            KayıtOl();
        }
        public static void KayıtOl() 
        {
            Console.WriteLine("Hoşgeldiniz lütfen kullanıcı adınızı giriniz :");
            string KullaniciAdi = Console.ReadLine();
            Console.WriteLine("Lütfen şifrenizi giriniz :");
            string Sifre = Console.ReadLine();
            Console.WriteLine("Giriş sayfasına yönlendiriliyorsunuz ...");
            //Console.WriteLine(KullaniciAdi);
            //Console.WriteLine(Sifre);
            GirisYap(KullaniciAdi, Sifre);
        }
        public static void GirisYap(string userName, string password)
        {
            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Kullanıcı adı giriniz :");
                string kullaniciAdi = Console.ReadLine();
                Console.WriteLine("Sifrenizi giriniz :");
                string sifre = Console.ReadLine();
                if (userName == kullaniciAdi && password == sifre) 
                {
                    foreach(char c in kullaniciAdi)
                    {
                        Console.WriteLine(c);
                    }
                    Console.WriteLine("Giriş işlemi başarılı ...");
                    return;
                }
                else 
                {
                    Console.WriteLine("Kullanıcı adı yada şifre hatalı kalan hak :{0}", 2 - i);
                }
            }
            string hataMesajı = "Hesabınız bloke oldu";
            foreach (char c in hataMesajı.Reverse()) 
            {
                Console.WriteLine(c);
            }
        }
    }
}