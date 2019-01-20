using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace CSharp.Basics.Samples.TypeInference
{
    public class DogAdoptionService
    {
        public List<AdoptablePet> Pets { get; set; }
        public void GetPetInfo(string id)
        {
            var petExists = PetExists(p => p.Id == id);
            String explicitPetName = "Bentley";
            var petName = "Bentley"; // inferred string
        }

        public bool PetExists(Expression<Func<AdoptablePet, bool>> predicate)
        {
            return Pets.Any(predicate.Compile());
        }
    }

    public class AdoptablePet
    {
        public string Id { get; set; }
        public bool IsAdopted { get; set; }
    }
}
