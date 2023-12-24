using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal //INHERITENCE
{

    void Start()
    {
        animalName = "CAT";
    }

    protected override string Talk()//POLYMORPHISM
    {
        return "MEOW";
    }

    

}
