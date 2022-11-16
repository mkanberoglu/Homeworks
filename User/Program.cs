using System;

namespace UserClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Destinations yer1 = new Destinations("Türkiye", "Gaziantep", 5);
            Destinations yer2 = new Destinations("Türkiye", "Elazığ", 1);
            Destinations yer3 = new Destinations("Japonya", "Tokyo", 4);
            List<Destinations> dest = new List<Destinations>();
            dest.Add(yer1);
            dest.Add(yer2);
            dest.Add(yer3);


            User user1 = new User("Mert", "Kanberoğlu", "564164846488", new DateTime(1965, 11, 15), new Dictionary<int, string>() { { 0, "05646564564" } }, dest);
            UserInfo usrInfo = new UserInfo();
            Console.WriteLine(usrInfo.Info(user1));
        }
    }
    class User
    {
        //------------Fields------------
        string ad;
        string soyad;
        string tc;
        DateTime dogumTarihi;
        Dictionary<int, string> telefonNo;
        List<Destinations> gezilenYerler;
        //------------Set&Get------------
        public void SetAd(string Ad) { this.ad = Ad; }
        public string GetAd() { return this.ad; }
        public void SetSoyAd(string SoyAd) { this.soyad = SoyAd; }
        public string GetSoyAd() { return this.soyad; }
        public void SetTc(string Tc) { this.tc = Tc; }
        public string GetTc() { return this.tc; }
        public void SetDogumTarihi(DateTime DogumTarihi) { this.dogumTarihi = DogumTarihi; }
        public DateTime GetDogumTarihi() { return this.dogumTarihi; }
        public void SetTelefonNo(Dictionary<int, string> telno) { this.telefonNo = telno; }
        public Dictionary<int, string> GetTelefonNo() { return this.telefonNo; }
        public void SetGezilenYerler(List<Destinations> yer) { this.gezilenYerler = yer; }
        public List<Destinations> GetGezilenYerler() { return this.gezilenYerler; }
        //------------Constructor------------
        public User(string Ad, string Soyad, string Tc, DateTime DogumTarihi, Dictionary<int, string> telno, List<Destinations> GezilenYerler)
        {
            this.ad = Ad;
            this.soyad = Soyad;
            this.tc = Tc;
            this.dogumTarihi = DogumTarihi;
            this.telefonNo = telno;
            this.gezilenYerler = GezilenYerler;
        }
    }
    class UserInfo
    {
        public string ShowDestinations(User usr)
        {
            string ifade = "";
            foreach (Destinations dest in usr.GetGezilenYerler())
            {
                ifade = ifade + "\n\rGezilen Ülke:" + dest.Country + "\n\rGezilen Şehir:" + dest.City + "\n\rVerilen Puan:" + dest.Point + "\n\r---------------";
            }
            return ifade;
        }
        public string Info(User usr)
        {
            string ifade = ShowDestinations(usr);
            return "---Kullanıcı Bilgileri--- \n\rAdı:" + usr.GetAd() + "\n\rSoyadı:" + usr.GetSoyAd() + "\n\rTc:" + usr.GetTc() + "\n\rDoğumTarihi:" + usr.GetDogumTarihi() + "\n\rTelefon Numarası:" + usr.GetTelefonNo()[0] + "\n\r---Kullanıcının Gezdiği Yerler---" + ifade;
        }
    }
    class Destinations
    {
        public string Country { get; set; }
        public string City { get; set; }
        public byte Point { get; set; }
        public Destinations(string country, string city, byte point)
        {
            this.Country = country;
            this.City = city;
            this.Point = point;
        }

    }
}