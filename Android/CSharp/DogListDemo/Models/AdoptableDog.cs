using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace DogListDemo.Models
{
    public class AdoptableDog
    {
        public string Name { get; set; }
        public string OriginalLocation { get; set; }
        public int Age { get; set; }
        public bool IsAdopted { get; set; }

        public AdoptableDog()
        {
        }

        public AdoptableDog(string name, int age, bool isAdopted)
        {
            Name = name;
            Age = age;
            IsAdopted = isAdopted;
        }
    }
}