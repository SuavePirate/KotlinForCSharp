package com.suavepirate.kotlinbasics.samples.functionDrivenClass

import com.suavepirate.kotlinbasics.samples.dataClass.Dog



data class AdoptableDog(val name: String) {
    var isAdopted: Boolean = false;
}

class DogAdoptionService {
    fun adoptDog(dog: Dog) {
        // run some business logic to adopt the dog
    }

    fun adoptDog(dog: AdoptableDog): AdoptableDog {
        dog.isAdopted = true
        return dog
    }
}

fun testAdoptions() {
    DogAdoptionService().adoptDog(Dog("Ryder", 2, "Mix Breed")) // void / Unit
    DogAdoptionService().adoptDog(AdoptableDog("Ryder")) // AdoptableDog
}