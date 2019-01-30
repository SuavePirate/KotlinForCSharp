package com.suavepirate.kotlinbasics.samples.extensions

class AdoptionService {
    fun adoptDog(dog: AdoptableDog) {
        dog.adopt()
    }
}

// extension functions
fun AdoptableDog.adopt() {
    this.isAdopted = true
}

// extension properties
val AdoptableDog.name : String
    get() = "${this.firstName} ${this.lastName}"

// companion object extensions

fun AdoptableDog.Companion.getShelters() {
    // ...
}

data class AdoptableDog(var firstName: String, var lastName: String, var isAdopted: Boolean) {
    companion object {}
}