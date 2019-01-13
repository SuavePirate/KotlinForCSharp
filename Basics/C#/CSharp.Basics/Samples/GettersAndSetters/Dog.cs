using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Basics.Samples.GettersAndSetters
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get => (DateTime.Now - BirthDate).Days / 365;
        }
    }
}
