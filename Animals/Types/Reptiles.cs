using Animals.Interfaces;

namespace Animals.Types
{
    internal class Reptiles : Animal, ISwim, ITalk, ICrowl
    {
        public Reptiles()
        {
            this.kind = "Animal";
            this.family = "Reptile";
        }

        public string Swim()
        {
            return $"{this.kind} type {this.family} named {this.name} swims ...";
        }

        public string Talk()
        {
            return $"{this.kind} type {this.family} named {this.name} talks ...";
        }

        public string Crowl()
        {
            return $"{this.kind} type {this.family} named {this.name} crowls ...";
        }
    }
}

