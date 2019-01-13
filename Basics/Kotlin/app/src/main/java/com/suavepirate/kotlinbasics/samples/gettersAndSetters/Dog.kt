package com.suavepirate.kotlinbasics.samples.gettersAndSetters

import java.util.*

class Dog {
    var name: String? = null
    var birthDate: Date = Date()
    var breed: String? = null
    val age: Int
        get() = (((Date().time - birthDate.time) / (1000 * 60 * 60 * 24)) / 365) as Int
}