using OfficeOpenXml;
namespace ExcelData
{
    class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data();
            var data = d.Calculate();
            foreach (KeyValuePair<string, float> entry in data)
            {
                Console.WriteLine($"İsim :{entry.Key}\nNot Ortalaması :{entry.Value}");
                Console.WriteLine("------------------------------------------------------");
            }

        }
    }
    public class Data
    {
        public List<string> name;
        public List<string> weekName;
        public List<float> score;
        public List<float> factor;
        public float[] points;
        public Dictionary<string, float> dict;
        public List<KeyValuePair<string, float>> Calculate()
        {
            this.points = new float[weekName.Count];
            this.dict = new Dictionary<string, float>();
            name.RemoveAt(0);
            for (int i = 0; i < weekName.Count; i++)
            {
                for (int j = 0; j < weekName.Count; j++) 
                {
                    points[i] += score[i * weekName.Count + j] * factor[j];
                }
                points[i] /= 3;
                dict.Add(name[i], points[i]);
            }
            //dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            var list = dict.OrderBy(x => x.Value).ToList();
            list.Reverse();
            return list;
        }
        public Data()
        {
            this.name = new List<string>();
            this.weekName = new List<string>();
            this.score = new List<float>();
            this.factor = new List<float>();

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage xlPackage = new ExcelPackage(new FileInfo("C:\\Users\\mkanb\\source\\repos\\Homeworks\\ExcelData\\notes.xlsx"));
            var workSheet = xlPackage.Workbook.Worksheets.First();
            int rowCount = workSheet.Dimension.End.Row;
            int colCount = workSheet.Dimension.End.Column;
            string strValue = "";
            float flValue ;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    if (i == 1)
                    {
                        if (i == 1 && j == 1)
                        {
                            continue;
                        }
                        else
                        {
                            strValue = workSheet.Cells[i, j].Value == null ? string.Empty : workSheet.Cells[i, j].Value.ToString();
                            AddWeekName(strValue);
                        }
                        
                    }
                    if (j == 1)
                    {
                        if (i == 1 && j == 1)
                        {
                            continue;
                        }
                        else
                        {
                            strValue = workSheet.Cells[i, j].Value == null ? string.Empty : workSheet.Cells[i, j].Value.ToString();
                            AddName(strValue);
                        }
                    }
                    if(i == 2 && j > 1)
                    {
                        strValue = workSheet.Cells[i, j].Value == null ? string.Empty : workSheet.Cells[i, j].Value.ToString();
                        bool success = float.TryParse(strValue, out flValue);
                        if (success)
                        {
                            AddFactor(flValue);
                        }
                        else 
                        {
                            Console.WriteLine("Değer floata dönüştürülemiyor ...");
                            Environment.Exit(0);
                        }                            
                    }
                    if(i > 2 && j > 1)
                    {
                        strValue = workSheet.Cells[i, j].Value == null ? string.Empty : workSheet.Cells[i, j].Value.ToString();
                        bool success = float.TryParse(strValue, out flValue);
                        if (success)
                        {
                            AddScore(flValue);
                        }
                        else
                        {
                            Console.WriteLine("Değer floata dönüştürülemiyor ...");
                            Environment.Exit(0);
                        }
                    }
                }
            }
        }
        public void AddName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name");
            }
            else
            {
                this.name.Add(name);
            }
        }
        public void AddWeekName(string weekName)
        {
            if (string.IsNullOrEmpty(weekName))
            {
                Console.WriteLine("Hafta adı boş olamaz !");
                Environment.Exit(0);
            }
            else 
            {
                this.weekName.Add(weekName);
            }
        }
        public void AddScore(float score)
        {
            if (score == null)
            {
                this.score.Add(0);
            }
            else if (score < 0 || score > 100)
            {
                Console.WriteLine($"Bir kişinin bir haftası boş girilmiştir");
                Environment.Exit(0);
            }
            else
            {
                this.score.Add(score);
            }
        }
        public void AddFactor(float factor)
        {
            if (factor == null)
            {
                Console.WriteLine($"Bir haftanın katsayısıx boş girilmiştir, program kapatılıyor");
                Environment.Exit(0);
            }
            else if (factor < 1 || factor > 5)
            {
                Console.WriteLine($"Bir haftanın katsayısı yanlış girilmiştir, program kapatılıyor");
                Environment.Exit(0);
            }
            else
            {
                this.factor.Add(factor);
            }
        }
    }
}