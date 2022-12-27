namespace Animals
{
    internal class Animal : LivingBeing
    {
        public Animal()
        {
        }
        public string Eat()
        {
            return $"{this.name} eats ...";
        }
    }
}
