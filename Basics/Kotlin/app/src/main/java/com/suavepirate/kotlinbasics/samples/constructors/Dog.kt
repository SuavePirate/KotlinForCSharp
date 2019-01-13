package com.suavepirate.kotlinbasics.samples.constructors


class Dog() {
    constructor(name: String?, age: Int?, breed: String?) : this() {
        this.name = name
        this.age = age
        this.breed = breed
    }
    var name: String? = null
    var age: Int? = null
    var breed: String? = null
}