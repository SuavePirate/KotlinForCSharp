using CSharp.Basics.Samples.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.StaticObjects
{
    public static class AdoptionHelper
    {
        public static void AdoptPet(AdoptablePet pet)
        {
            pet.IsAdopted = true;
        }
    }
}
