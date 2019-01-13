package com.suavepirate.kotlinbasics.samples.async

import com.google.gson.Gson
import com.google.gson.reflect.TypeToken
import com.suavepirate.kotlinbasics.samples.functionDrivenClass.AdoptableDog
import java.net.URL
import kotlinx.coroutines.*

class DogAdoptionService {
    fun getAdoptableDogs(): List<AdoptableDog> {
        var json = URL("http://someurl.com").readText()
        val listType = object : TypeToken<List<AdoptableDog>>() { }.type
        return Gson().fromJson(json, listType)
    }

    fun getAdoptableDogsInBackground() {
        var dogs: List<AdoptableDog>? = null
        GlobalScope.launch {
            dogs = getAdoptableDogs()
        }
    }
}