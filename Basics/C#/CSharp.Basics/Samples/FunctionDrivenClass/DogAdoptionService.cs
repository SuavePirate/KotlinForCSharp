using CSharp.Basics.Samples.Constructors;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.FunctionDrivenClass
{
    public class DogAdoptionService
    {
        public void AdoptDog(Dog dog)
        {
            // run some business logic to adopt the dog
        }

        public AdoptableDog AdoptDog(AdoptableDog dog)
        {
            dog.IsAdopted = true;
            return dog;
        }
    }

    public class AdoptableDog
    {
        public string Name { get; set; }
        public bool IsAdopted { get; set; }
        public AdoptableDog(string name)
        {
            Name = name;
        }
    }
}
