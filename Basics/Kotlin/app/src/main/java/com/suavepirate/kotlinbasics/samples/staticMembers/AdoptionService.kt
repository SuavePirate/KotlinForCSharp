package com.suavepirate.kotlinbasics.samples.staticMembers

import com.suavepirate.kotlinbasics.samples.generics.AdoptablePet

class AdoptionService {
    fun instanceAdopt(pet: AdoptablePet) {
        pet.isAdopted = true
    }

    // static
    companion object {
        fun staticAdopt(pet: AdoptablePet) {
            pet.isAdopted = true
        }
    }
}

fun run() {
    AdoptionService.staticAdopt(AdoptablePet(false))
    AdoptionService().instanceAdopt(AdoptablePet(false))
}