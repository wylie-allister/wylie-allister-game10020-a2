using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{

    public Character character;

    public Cloud cloud;
    public Fan fan;
    //this is the problem
    //public Brazier brazier;
    public Door door;
    public UIManager ui;

    public GameObject sword;
    public GameObject doorOb;
    public GameObject brazierHolder;
    bool isSwordEnabled = false;

    Vector3 currentAngle = new Vector3(0f, 90f, 0f);

    public int brazierUnlitCount = 0;


    // Start is called before the first frame update
    private void Start()
    {
       

        fan.OnFanHit.AddListener(RotateFan);

        door.OnBrazierCount.AddListener(UnlockDoor);
        door.OnBrazierCount.AddListener(ui.UpdateDoorUI);
        fan.OnBrazierCompletion.AddListener(fan.EnableCollider);
        fan.OnBrazierCompletion.AddListener(ui.UpdateCloudUI);

 foreach (Transform child in brazierHolder.transform)
        {
            Brazier brazier = child.GetComponent<Brazier>();
        brazier.OnBrazierOut.AddListener(BlowOutBrazier);
        brazier.OnBrazierOut.AddListener(ui.UpdateBrazierCount);

        }
        sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        EnableSword();

    }

    public void EnableSword()
    {
        if (isSwordEnabled && Input.GetKeyDown(KeyCode.E))
        {
            isSwordEnabled = false;
            sword.SetActive(false);
        }
        else if (!isSwordEnabled && Input.GetKeyDown(KeyCode.E))
        {
            isSwordEnabled = true;
            sword.SetActive(true);
        }
    }

    void UnlockDoor(Door door)
    {
        door.LockCheck();
        fan.OnBrazierCompletion.Invoke(fan);

    }

    void RotateFan(Fan fanState)
    {
        //rotate fan on hit
            fanState.transform.Rotate(currentAngle);
        
    }

    void BlowOutBrazier(Brazier brazier)
    {
        Debug.Log("Double Pong");
        brazier.LightOut();
        brazierUnlitCount++;
    }
}
