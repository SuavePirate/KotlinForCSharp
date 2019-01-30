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
    public class DogListAdapter : RecyclerView.Adapter
    {
        private readonly AdoptableDog[] _dogs;
        private readonly LayoutInflater _inflater;
        public DogListAdapter(AdoptableDog[] dogs, Context context)
        {
            _dogs = dogs;
            _inflater = LayoutInflater.From(context);
        }
        public override int ItemCount => _dogs.Length;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            (holder as DogItemViewHolder).Update(_dogs[position]);
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var view = _inflater.Inflate(Resource.Layout.dog_list_item, parent, false);
            return new DogItemViewHolder(view);
        }
    }
}