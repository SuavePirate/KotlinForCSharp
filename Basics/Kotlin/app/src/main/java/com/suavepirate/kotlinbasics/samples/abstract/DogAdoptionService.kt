package com.suavepirate.kotlinbasics.samples.abstract

import com.suavepirate.kotlinbasics.samples.generics.AdoptablePet

abstract class AdoptionService {
    abstract fun adoptPet(pet: AdoptablePet)
    fun adoptPets(pets: List<AdoptablePet>) {
        for(pet in pets) {
            adoptPet(pet)
        }
    }
}

class DogAdoptionService : AdoptionService() {
    override fun adoptPet(pet: AdoptablePet) {
        pet.isAdopted = true
    }
}