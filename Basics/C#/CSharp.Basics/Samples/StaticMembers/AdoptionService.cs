using CSharp.Basics.Samples.Generics;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.StaticMembers
{
    public class AdoptionService
    {
        public void InstanceAdopt(AdoptablePet pet)
        {
            pet.IsAdopted = true;
        }

        public static void StaticAdopt(AdoptablePet pet)
        {
            pet.IsAdopted = true;
        }
    }

    class Runner
    {
        // ...
        void Run()
        {
            AdoptionService.StaticAdopt(new AdoptablePet
            {
                IsAdopted = false
            });

            new AdoptionService().InstanceAdopt(new AdoptablePet
            {
                IsAdopted = false
            });
        }
    }

}
