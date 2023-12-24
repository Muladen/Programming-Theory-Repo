using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal //INHERITENCE
{

    void Start()
    {
        animalName = "FISH";
    }

    protected override string Talk()//POLYMORPHISM
    {
        return "BLUB";
    }
}
