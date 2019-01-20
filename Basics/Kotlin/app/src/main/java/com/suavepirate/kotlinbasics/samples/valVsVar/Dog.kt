package com.suavepirate.kotlinbasics.samples.valVsVar

class Dog {
    var name: String? = null
    val readonlyName: String = "A name"

    fun bark() {
        val sound = "boof!"
        var sound2 = "roof!"

        sound2 = "woof!" // ok
        //sound = "woof" // not ok
    }
}