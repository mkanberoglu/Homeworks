using CSVDataHandler;
namespace DLLUseCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h = new Handler("C:\\Users\\mkanb\\source\\repos\\Homeworks\\DataHandling\\car_data.csv");
            foreach (var person in h.Data())
            {
                Console.WriteLine($"------------------- \n\rPerson Id :{person.UserId} \n\rPerson Gender :{person.Gender} \n\rPerson Purchased :{person.Purchased} \n\rPerson AnnualSalary :{person.AnnualSalary} ");
            }
        }
    }
}