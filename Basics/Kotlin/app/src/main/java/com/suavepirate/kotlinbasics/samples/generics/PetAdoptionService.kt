package com.suavepirate.kotlinbasics.samples.generics

class PetAdoptionService<T : AdoptablePet> {
    fun adoptPet(pet: T) {
        pet.isAdopted = true
    }
}

class AdoptablePet(var isAdopted: Boolean)