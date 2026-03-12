using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //makes the wind be able to trigger the blowable objects
        if (other.GetComponent<IBlowable>() != null)
        {
            IBlowable blow = other.GetComponent<IBlowable>();
            blow.Blown(gameObject);
        }
    }
}
