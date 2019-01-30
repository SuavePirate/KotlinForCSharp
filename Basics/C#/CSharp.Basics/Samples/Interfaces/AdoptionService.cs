using CSharp.Basics.Samples.FunctionDrivenClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.Interfaces
{
    public interface IAdoptionService
    {
        void AdoptDog(AdoptableDog dog);

        // C# 7 doesn't have intercace implementations
        void AdoptDogs(List<AdoptableDog> dogs);
    }

    public class DogAdoptionService : IAdoptionService
    {
        public void AdoptDog(AdoptableDog dog)
        {
            dog.IsAdopted = true;
        }

        public void AdoptDogs(List<AdoptableDog> dogs)
        {
            foreach(var dog in dogs)
            {
                AdoptDog(dog);
            }
        }
    }
}
