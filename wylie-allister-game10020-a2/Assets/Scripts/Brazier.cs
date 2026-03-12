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

    public int brazierUnlitCount = 0;


    [HideInInspector]
    public UnityEvent<Brazier> OnBrazierOut;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LightOut()
    {
        this.flame.SetActive(false);
    }

    public void Stab (GameObject go)
    {
        this.flame.SetActive(true);
        this.hasTriggered = false;
    }

    public void Blown(GameObject go)
    { 
        if (!this.hasTriggered)
        {
            OnBrazierOut.Invoke(this);
            this.hasTriggered = true;
        }
    }
}
