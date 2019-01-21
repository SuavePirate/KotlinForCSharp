package com.suavepirate.kotlinbasics.samples


class PetAdoptionService {
    var pets: List<AdoptablePet>? = null

    fun adoptPet(id: String) {
        val petExists = petExists { p -> p.id == id };
        // do something to get pet info
    }
    fun petExists(predicate: (AdoptablePet) -> Boolean): Boolean {
        return pets!!.any(predicate)
    }
}

data class AdoptablePet(val id: String, val isAdopted: Boolean)