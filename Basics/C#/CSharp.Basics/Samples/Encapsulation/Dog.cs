using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.Encapsulation
{
    public class Dog
    {
        public string Name { get; set; }
        protected int _age;
        private Breed _breed;
        private class Breed
        {
            public string Name { get; set; }
        }
    }
}
