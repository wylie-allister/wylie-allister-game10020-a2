using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fan : MonoBehaviour, IStabbable
{

    [HideInInspector]
    public UnityEvent<Fan> OnFanHit;
    public UnityEvent<Fan> OnBrazierCompletion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
    }


    public void Stab(GameObject go)
    {
        //rotates on stabbing
            OnFanHit.Invoke(this);
    }
}
