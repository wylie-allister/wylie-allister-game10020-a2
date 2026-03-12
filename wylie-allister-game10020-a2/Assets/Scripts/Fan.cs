using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fan : MonoBehaviour, IStabbable
{
    Vector3 currentAngle;

    public GameObject collider;

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

    public void EnableCollider(Fan fan)
    {
        fan.collider.SetActive(true);
    }

    public void Stab(GameObject go)
    {
            OnFanHit.Invoke(this);
        
    }
}
