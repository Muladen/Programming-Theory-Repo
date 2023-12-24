using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal //INHERITENCE
{

    void Start()
    {
        animalName = "DOG";
    }

    protected override string Talk()//POLYMORPHISM
    {
        return "WOOF";
    }
}
