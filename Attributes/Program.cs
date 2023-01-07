using System.Reflection;
using System.Security.Principal;

namespace Attributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Data d = new Data(65, 50, 99, 105);
            Console.WriteLine(Writer.Write(d));
        }
    }
    #region Attribute
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyControl : Attribute
    {
        public int maxValue;
        public PropertyControl(int maxValue)
        {
            this.maxValue = maxValue;
        }
    }
    #endregion
    #region Data Class
    public class Data
    {
        [PropertyControl(maxValue: 100)]
        public int first { get; set; }
        public int second { get; set; }
        [PropertyControl(maxValue: 100)]
        public int third { get; set; }
        [PropertyControl(maxValue: 100)]
        public int fourth { get; set; }
        public Data(int first, int second, int third, int fourth)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.fourth = fourth;
        }
    }
    #endregion
    #region Writer Function
    public class Writer
    {
        public static string Write(object obj)
        {
            string msg = null;
            var t = typeof(Data);
            var pi = t.GetProperties();
            foreach (var p in pi)
            {
                var attr = (PropertyControl)p.GetCustomAttribute(typeof(PropertyControl));
                if (attr != null && attr.maxValue >= (int)p.GetValue(obj))
                {
                    msg += p.Name + " :";
                    msg += p.GetValue(obj) + "\n\r";
                }
            }


            return msg;
        }
    }
    #endregion
}