using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public GameObject doorPrefab;
    public Brazier brazier;

    public UnityEvent<Door> OnBrazierCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (brazier.brazierUnlitCount >= 4)
        {
            OnBrazierCount.Invoke(this);
        }
    }


    public void LockCheck()
    {
            doorPrefab.SetActive(false);
        
    }


}
