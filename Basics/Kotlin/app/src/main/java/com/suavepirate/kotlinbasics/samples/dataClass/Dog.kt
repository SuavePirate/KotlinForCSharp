package com.suavepirate.kotlinbasics.samples.dataClass

data class Dog(val name: String, val age: Int, val breed: String)

val dog1 = Dog("Bentley", 5, "Staffordshire Terrier")

val dog1Copy = dog1.copy()

val areSame = dog1 == dog1Copy // true
