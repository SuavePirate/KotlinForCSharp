package com.suavepirate.kotlinbasics.samples.encapsulation

open class Dog {
    var name: String? = null
    private var breed: Breed? = null
    protected var age: Int? = null
    private data class Breed(val name: String)
}