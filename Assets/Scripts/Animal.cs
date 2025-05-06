using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    public abstract int CountLegs();
}

// INHERITANCE
public class Dog : Animal
{
    private int legsCount = 4;

    // POLYMORPHISM
    public override int CountLegs()
    {
        return legsCount;
    }

    // ENCAPSULATION
    public int NumberOfLegs
    {
        get
        {
            return legsCount;
        }

        private set
        {
            legsCount = value;
        }
    }

    public void Bark()
    {
        // ABSTRACTION
        Debug.Log(BarkInUSString());
        Debug.Log(BarkInJapanString());
    }

    public string BarkInUSString()
    {
        return "bowwow";
    }

    public string BarkInJapanString()
    {
        return "‚í‚ñ‚í‚ñ";
    }
}
