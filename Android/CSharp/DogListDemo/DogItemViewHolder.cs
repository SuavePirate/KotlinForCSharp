using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using DogListDemo.Models;

namespace DogListDemo
{
    public class DogItemViewHolder : RecyclerView.ViewHolder
    {
        public TextView NameTextView { get; set; }
        public TextView AgeTextView { get; set; }
        public TextView AdoptedTextView { get; set; }
        public DogItemViewHolder(View itemView) : base(itemView)
        {
            NameTextView = itemView.FindViewById<TextView>(Resource.Id.NameLabel);
            AgeTextView = itemView.FindViewById<TextView>(Resource.Id.AgeLabel);
            AdoptedTextView = itemView.FindViewById<TextView>(Resource.Id.AdoptedLabel);
        }

        public void Update(AdoptableDog dog)
        {
            NameTextView.Text = dog.Name;
            AgeTextView.Text = $"{dog.Age} years old";
            AdoptedTextView.Text = dog.IsAdopted ? "Adopted" : "Available";
        }
    }
}