using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Brazier : MonoBehaviour, IStabbable, IBlowable
{

    public GameObject flame;

    bool hasTriggered = false;


    [HideInInspector]
    public UnityEvent<Brazier> OnBrazierOut;

    public void LightOut()
    {
        //diables flame
        this.flame.SetActive(false);
    }

    public void Stab (GameObject go)
    {
        //enables flame when stabbed
        this.flame.SetActive(true);
        this.hasTriggered = false;
    }

    public void Blown(GameObject go)
    { 
        //triggers the blown out event when fan goes over it
        if (!this.hasTriggered)
        {
            OnBrazierOut.Invoke(this);
            this.hasTriggered = true;
        }
    }
}
