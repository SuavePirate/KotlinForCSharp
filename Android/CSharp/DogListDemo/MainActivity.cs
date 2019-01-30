using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using DogListDemo.Models;

namespace DogListDemo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            var fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;

            var recycler = FindViewById<RecyclerView>(Resource.Id.DogRecyclerView);
            var dogs = new AdoptableDog[] {
                new AdoptableDog("Bentley", 5, true),
                new AdoptableDog("Ryder", 2, true),
                new AdoptableDog("Belle", 7, true),
                new AdoptableDog("Tootsie", 5, true),
                new AdoptableDog("Smokey", 5, true),
                new AdoptableDog("Biscuit", 1, true),
                new AdoptableDog("Jazzy", 15, true),
                new AdoptableDog("Hunter", 3, false)
            };
            recycler.SetLayoutManager(new LinearLayoutManager(this, LinearLayoutManager.Vertical, false));
            recycler.SetAdapter(new DogListAdapter(dogs, this));
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            var view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

