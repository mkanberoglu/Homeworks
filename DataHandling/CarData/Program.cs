using Microsoft.VisualBasic;
using TxtDataRead;
namespace CarData
{
    class Program
    {
        static void Main(string[] args)
        {
            DataHandler h = new DataHandler("C:\\Users\\mkanb\\source\\repos\\Homeworks\\DataHandling\\car_data.txt");
            Console.WriteLine($"Average age of females ---> {h.CustomerAverageAge("Female")}");
            Console.WriteLine($"Average age of males ---> {h.CustomerAverageAge("Male")}");
            Console.WriteLine(h.HighestAnnualSalary("Female"));
            Console.WriteLine(h.HighestAnnualSalary("Male"));
        }
    }
    public class DataHandler
    {
        List<TxtDataRead.CarInfo> data;
        public DataHandler(string path)
        {
           this.data = BanaVeriGetir.Getir(path);
        }
        public float CustomerAverageAge(string gender)
        {
            float sum = 0;
            int count = 0;
            for(int i = 0; i < data.Count; i++)
            {
                if (data[i].Purchased == 1 && data[i].Gender == gender)
                {
                    sum += data[i].Age;
                    count++;
                }
            }
            return sum/count;
        }
        public string HighestAnnualSalary(string gender)
        {
            int userId = 0;
            int age = 0;
            int highestSalary = 0;
            for(int i = 0; i < data.Count; i++)
            {
                if (data[i].Gender == gender && data[i].AnnualSalary > highestSalary)
                {
                    userId = data[i].User_ID;
                    age = data[i].Age;
                    highestSalary = data[i].AnnualSalary;
                }
            }
            string msg = $"Highest annual salary of {gender}s :{highestSalary}\n\rUser Id :{userId} Age :{age}";
            return msg;
        }
    }
}