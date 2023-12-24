using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Animal : MonoBehaviour
{
    public TextMeshProUGUI nameText;

    private string m_animalName = "Animal";
    public string animalName //ENCAPSULATION
    {
        get { return m_animalName; }
        set
        {
            if (value.Length == 0)
            {
                Debug.LogError("You must set a name!");

            }
            else
            {
                m_animalName = value;
            }
        }
        
    }

    protected void DisplayText() //ABSTRACTION
    { 
        nameText.text = "My name is " + m_animalName + " and i say " + Talk();
    }

    protected abstract string Talk();//POLYMORPHISM

    private void OnMouseDown() 
    {
        DisplayText();
    }
}
