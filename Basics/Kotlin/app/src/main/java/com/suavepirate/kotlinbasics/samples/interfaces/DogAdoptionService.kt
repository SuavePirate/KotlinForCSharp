package com.suavepirate.kotlinbasics.samples.interfaces

interface DogAdoptionService {
    fun adoptDog(dog: AdoptableDog)
    fun adoptDogs(dogs: List<AdoptableDog>) {
        for(dog in dogs) {
            adoptDog(dog)
        }
    }
}

class DogAdoptionServiceImpl() : DogAdoptionService {
    override fun adoptDog(dog: AdoptableDog) {
        dog.isAdopted = true
    }
}

data class AdoptableDog(val name: String, var isAdopted: Boolean)