package com.suavepirate.kotlinbasics.samples.tuples

class DogAdoptionService {
    fun adopt(data: Pair<Dog, Shelter>) {
        data.first.isAdopted = true
    }
}

data class Dog(var isAdopted: Boolean)
class Shelter()