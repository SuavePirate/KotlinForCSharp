using CSharp.Basics.Samples.FunctionDrivenClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.Abstract
{
    public abstract class AdoptionService
    {
        public abstract void AdoptDog(AdoptableDog dog);
        public void AdoptDogs(List<AdoptableDog> dogs)
        {
            foreach(var dog in dogs)
            {
                AdoptDog(dog);
            }
        }
    }

    public class DogAdoptionService : AdoptionService
    {
        public override void AdoptDog(AdoptableDog dog)
        {
            dog.IsAdopted = true;
        }
    }
}
