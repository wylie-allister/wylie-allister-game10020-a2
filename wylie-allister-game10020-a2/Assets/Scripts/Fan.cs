using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fan : MonoBehaviour, IStabbable
{
    Vector3 currentAngle;

    [HideInInspector]
    public UnityEvent<Fan> OnFanHit;
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
            Debug.Log("Ping!");
            OnFanHit.Invoke(this);
        
    }
}
