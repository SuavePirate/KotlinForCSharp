package com.suavepirate.doglistdemo

import android.support.v7.widget.RecyclerView
import android.view.View
import android.widget.TextView

class DogItemViewHolder(itemView: View) : RecyclerView.ViewHolder(itemView) {
    val nameTextView: TextView = itemView.findViewById(R.id.nameLabel)
    val ageTextView: TextView = itemView.findViewById(R.id.ageLabel)
    val adoptedTextView: TextView = itemView.findViewById(R.id.adoptedLabel)

    fun update(dog: AdoptableDog) {
        nameTextView.text = dog.name
        ageTextView.text = "${dog.age} years old"
        adoptedTextView.text = if(dog.isAdopted) "Adopted" else "Available"
    }
}