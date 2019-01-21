package com.suavepirate.kotlinbasics.samples.dynamic

class PetAdoptionService {

    // not supported in jvm
    fun adoptPet(pet: dynamic) {
        pet.isAdopted = true
    }
}