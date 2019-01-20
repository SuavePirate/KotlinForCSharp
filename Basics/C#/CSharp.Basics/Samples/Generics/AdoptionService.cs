using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.Generics
{
    public class PetAdoptionService<T> where T : AdoptablePet
    {
        public void AdoptPet(T pet)
        {
            pet.IsAdopted = true;
        }
    }

    public class AdoptablePet
    {
        public bool IsAdopted { get; set; }
    }
}
