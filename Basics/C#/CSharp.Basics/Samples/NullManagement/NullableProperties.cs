using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.NullManagement
{
    public class Dog
    {
        public string Name { get; set; }
        public Breed Breed { get; set; }
        public int BreedLifespan => Breed?.AverageLifespan ?? 0;
        public int DangerousBreedLifespan => Breed.AverageLifespan.Value;
    }

    public class Breed
    {
        public string Name { get; set; }
        public int? AverageLifespan { get; set; }
    }
}
