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
        public void AdoptPet(string id)
        {
            var petExists = PetExists(p => p.Id == id);
            // do something to get pet info
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
