using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.Extensions
{
    public class AdoptionService
    {
        public void AdoptDog(AdoptableDog dog)
        {
            dog.Adopt();
        }
    }

    public static class AdoptableExtensions
    {
        public static void Adopt(this AdoptableDog dog)
        {
            dog.IsAdopted = true;
        }
    }

    public class AdoptableDog
    {
        public bool IsAdopted { get; set; }
    }
}
