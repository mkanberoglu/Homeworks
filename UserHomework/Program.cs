using System;

namespace UserClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(UserInfo.Info());
            
        }
    }
    class User
    {
        //------------Fields------------
        string ad;
        string soyad;
        byte yas;
        float bakiye;
        List<VisitedPlaces> gezilenYerler;
        //------------Set&Get------------
        public void SetAd(string Ad) { this.ad = Ad; }
        public string GetAd() { return this.ad; }
        public void SetSoyAd(string SoyAd) { this.soyad = SoyAd; }
        public string GetSoyAd() { return this.soyad; }
        public void SetYas(byte Yas) { this.yas = Yas; }
        public byte GetYas() { return this.yas; }
        public void SetBakiye(float bakiye) { this.bakiye = bakiye; }
        public float GetBakiye() { return this.bakiye; }
        public void SetGezilenYerler(List<VisitedPlaces> yer) { this.gezilenYerler = yer; }
        public List<VisitedPlaces> GetGezilenYerler() { return this.gezilenYerler; }
        //------------Constructor------------
        public User(string Ad, string Soyad, byte Yas, float bakiye, List<VisitedPlaces> GezilenYerler)
        {
            this.ad = Ad;
            this.soyad = Soyad;
            this.yas = Yas;
            this.bakiye = bakiye;
            this.gezilenYerler = GezilenYerler;
        }
    }
    class UserInfo
    {
        public static string Info() 
        {
            VisitedPlaces yer1 = new VisitedPlaces("Almanya", "Berlin", 52345, new Dictionary<int, string>() { { 0, "Enis Baykara" }, { 1, "Mert Deliyürek" }, { 2, "Recep Çalışkan" }, { 3, "Ebru Geçkalan" } });

            List<VisitedPlaces> dest = new List<VisitedPlaces>();
            dest.Add(yer1);

            User user1 = new User("Mert", "Kanberoğlu", 26, 156.5f, dest);
            string peop = "";
            foreach (string s in dest[0].PeopleMet.Values)
            {
                peop += s + ", ";
            }
            peop = peop.Remove(peop.Length - 2);
            return user1.GetAd() + " " + user1.GetSoyAd() + " " + dest[0].Country + ", " + dest[0].City + "'de " + dest[0].PeopleMet.Count + " kişi ile tanıştı bunlar sırasıyla; " + peop + "'dır .";
        }
    }
    class VisitedPlaces
    {
        public string Country { get; set; }
        public string City { get; set; }
        public int PostCode{ get; set; }
        public Dictionary<int, string> PeopleMet{ get; set; }
        public VisitedPlaces(string country, string city, int postCode, Dictionary<int, string> peopleMet)
        {
            this.Country = country;
            this.City = city;
            this.PostCode = postCode;
            this.PeopleMet = peopleMet;
        }

    }
}