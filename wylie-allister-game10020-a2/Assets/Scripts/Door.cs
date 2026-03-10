using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Door : MonoBehaviour
{
    bool locked = true;
    public GameObject doorPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lock(bool isLocked)
    {
        locked = isLocked;
        LockCheck();
    }

    void LockCheck()
    {
        if (!locked)
        {
            doorPrefab.SetActive(false);
        }
    }
}
