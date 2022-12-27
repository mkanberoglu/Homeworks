using Animals.Interfaces;

namespace Animals.Types
{
    internal class Birds : Animal, IFly, ITalk, IWalk
    {
        public Birds()
        {
            this.kind = "Animal";
            this.family = "Bird";
        }

        public string Fly()
        {
            return $"{this.kind} type {this.family} named {this.name} flies ...";
        }

        public string Talk()
        {
            return $"{this.kind} type {this.family} named {this.name} talks ...";
        }

        public string Walk()
        {
            return $"{this.kind} type {this.family} named {this.name} walks ...";
        }
    }
}
