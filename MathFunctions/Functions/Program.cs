using System;

namespace Functions
{
    class Functions
    {
        public static void Main(string[] args)
        {
            //-------------Mutlak Değer-------------
            //Console.WriteLine(MutlakDeger(-123));
            //Console.WriteLine(MutlakDeger(-478912789412));
            //Console.WriteLine(MutlakDeger(-0.8132m));
            //Console.WriteLine(MutlakDeger(-0.5f));
            //Console.WriteLine(MutlakDeger(4));
            //Console.WriteLine(MutlakDeger(0));
            //-------------Yuvarlama-------------
            //Console.WriteLine(Yuvarla(-0.4999999f));
            //Console.WriteLine(Yuvarla(-0.5999999f));
            //Console.WriteLine(Yuvarla(0.0));
            //Console.WriteLine(Yuvarla(-0.599999944646684m));
            //Console.WriteLine(Yuvarla(-0.5999999456456451234489d));
            //Console.WriteLine(Yuvarla(0.499999944646684m));
            //Console.WriteLine(Yuvarla(0.5999999456456451234489d));
            //-------------Kuvvet Alma-------------
            //Console.WriteLine(KuvvetAl(5, 3));
            //Console.WriteLine(KuvvetAl(0, 3));
            //Console.WriteLine(KuvvetAl(5, 0));
            //Console.WriteLine(KuvvetAl(0, 0));
            //Console.WriteLine(KuvvetAl(5, -2));
        }
        public static double KuvvetAl(float sayi, float us) 
        {
            
            if(sayi == 0 && us == 0) 
            {
                Console.WriteLine("0 üssü 0 tanımsızdır...");
            }
            else if(us < 0) 
            {
                sayi = 1 / sayi;
            }
        
            double temp = 1;
            for(int i = 0; i < MutlakDeger(us); i++) 
            {
                temp *= sayi;
            }
            return temp;
        }
        
        
        
        
        public static int Yuvarla(float sayi) 
        {
            if (sayi > 0) 
            {
                return (int)(sayi + 0.5);
            }
            else 
            {
                return (int)(sayi - 0.5);
            }
        }
        public static int Yuvarla(double sayi)
        {
            if (sayi > 0)
            {
                return (int)(sayi + 0.5);
            }
            else
            {
                return (int)(sayi - 0.5);
            }
        }
        public static int Yuvarla(decimal sayi)
        {
            if (sayi > 0)
            {
                return (int)(sayi + 0.5m);
            }
            else
            {
                return (int)(sayi - 0.5m);
            }
        }
        public static int MutlakDeger(int sayi)
        {
            if (sayi < 0)
            {
                return -sayi;
            }
            return sayi;
        }
        public static float MutlakDeger(float sayi)
        {
            if (sayi < 0)
            {
                return -sayi;
            }
            return sayi;
        }
        public static double MutlakDeger(double sayi)
        {
            if (sayi < 0)
            {
                return -sayi;
            }
            return sayi;
        }
        public static decimal MutlakDeger(decimal sayi)
        {
            if (sayi < 0)
            {
                return -sayi;
            }
            return sayi;
        }
        public static long MutlakDeger(long sayi)
        {
            if (sayi < 0)
            {
                return -sayi;
            }
            return sayi;
        }
    }
}