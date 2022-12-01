using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

namespace CSVDataHandler
{
    public class Handler
    {
        public StreamReader reader;
        public CsvReader csv;
        public Handler(string path)
        {
            this.reader = new StreamReader(path);
            this.csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<PersonMap>();
        }
        public IEnumerable<Person>  Data()
        {
            var data = this.csv.GetRecords<Person>();
            return data;
        }
        
    }
    public class Person
    {
        public int UserId { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int AnnualSalary { get; set; }
        public bool Purchased { get; set; }
    }
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Map(p => p.UserId).Index(0);
            Map(p => p.Gender).Index(1);
            Map(p => p.Age).Index(2);
            Map(p => p.AnnualSalary).Index(3);
            Map(p => p.Purchased).Index(4);
        }
    }
}