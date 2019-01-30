package com.suavepirate.kotlinbasics.samples.asyncStream

import com.suavepirate.kotlinbasics.samples.pojo.Dog
import kotlinx.coroutines.*


fun CoroutineScope.asyncName(dog: Dog) = async {
    delay(200)
    dog.name
}

fun CoroutineScope.asyncNames(dogs: List<Dog>): List<Deferred<String?>> {
    return dogs.map {d -> asyncName(d)}
}

fun main(dogs: List<Dog>) = runBlocking {
    val names = asyncNames(dogs)
    for(name in names) {
        println(name.await())
    }
}