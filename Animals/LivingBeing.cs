namespace Animals
{
    internal abstract class LivingBeing
    {
        public string name;
        public string kind;
        public string family;
        public string Breathe()
        {
            return $"{this.name} adlı hayvan {this.kind} türünün {this.family} ailesine üyedir ...";
        }
    }
}
