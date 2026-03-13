using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public GameObject doorPrefab;
    public GameObject exit;
    public LevelManager lm;

    public UnityEvent<Door> OnBrazierCount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //invokes door open if 4 braziers are out
        if (lm.brazierUnlitCount >= 4)
        {
            OnBrazierCount.Invoke(this);
        }
    }


    public void LockCheck()
    {
        //disables door 
            doorPrefab.SetActive(false);
        exit.SetActive(true);
        
    }


}
