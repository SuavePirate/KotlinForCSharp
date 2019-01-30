package com.suavepirate.kotlinbasics.samples.staticObjects

import com.suavepirate.kotlinbasics.samples.generics.AdoptablePet

object AdoptionHelper {
    fun adoptPet(pet: AdoptablePet) {
        pet.isAdopted = true;
    }
}

fun run() {
    AdoptionHelper.adoptPet(AdoptablePet(false))
}