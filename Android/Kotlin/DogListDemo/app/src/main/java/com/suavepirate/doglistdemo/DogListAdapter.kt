package com.suavepirate.doglistdemo

import android.content.Context
import android.support.v7.widget.RecyclerView
import android.view.LayoutInflater
import android.view.ViewGroup

class DogListAdapter(val dogs: List<AdoptableDog>, context: Context) : RecyclerView.Adapter<DogItemViewHolder>() {
    val inflater = LayoutInflater.from(context)

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): DogItemViewHolder {
        val view = inflater.inflate(R.layout.dog_list_item, parent, false)
        return DogItemViewHolder(view)
    }

    override fun getItemCount(): Int {
        return dogs.count()
    }

    override fun onBindViewHolder(holder: DogItemViewHolder, position: Int) {
        holder.update(dogs[position])
    }
}