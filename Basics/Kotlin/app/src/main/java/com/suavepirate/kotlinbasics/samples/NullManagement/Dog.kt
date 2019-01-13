package com.suavepirate.kotlinbasics.samples.NullManagement

data class Dog(val name: String) {
    var breed: Breed? = null
    val breedLifespan
        get() = breed?.averageLifeSpan ?: 0
    val dangerousBreedLifespan
        get() = breed!!.averageLifeSpan!!
}

data class Breed(val name: String, val averageLifeSpan: Int?)