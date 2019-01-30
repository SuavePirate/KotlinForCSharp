package com.suavepirate.kotlinbasics.samples.ranges

import com.suavepirate.kotlinbasics.samples.pojo.Dog

fun getNamesByRange(dogs: List<Dog>) {
    val range = 1..4
    for(dog in dogs.subList(range.first, range.last)) {
        print(dog.name)
    }
}