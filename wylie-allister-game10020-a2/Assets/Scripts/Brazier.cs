using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Brazier : MonoBehaviour, IStabbable, IBlowable
{

    public GameObject flame;

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

    public void Stab (GameObject go)
    {
        flame.SetActive(true);
    }

    public void Blown(GameObject go)
    {
        OnBrazierOut.Invoke(this);
    }
}
