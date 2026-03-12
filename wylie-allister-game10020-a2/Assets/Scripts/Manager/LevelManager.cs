using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{

    public Character character;

    public Cloud cloud;
    public Fan fan;
    public Door door;
    public UIManager ui;

    public GameObject sword;
    public GameObject doorOb;
    public GameObject brazierHolder;
    public GameObject wind;
    bool isSwordEnabled = false;

    Vector3 currentAngle = new Vector3(0f, 90f, 0f);

    public int brazierUnlitCount = 0;


    // Start is called before the first frame update
    private void Start()
    {
       
        //rotates fan when you hit it
        fan.OnFanHit.AddListener(RotateFan);

        //unlocks door and updates ui when 4 braziers are out
        door.OnBrazierCount.AddListener(UnlockDoor);
        door.OnBrazierCount.AddListener(ui.UpdateDoorUI);
        //Enables wind when 4 braziers are out
        fan.OnBrazierCompletion.AddListener(EnableCollider);
        fan.OnBrazierCompletion.AddListener(ui.UpdateCloudUI);

        //blows out a brazier and updates ui
 foreach (Transform child in brazierHolder.transform)
        {
            Brazier brazier = child.GetComponent<Brazier>();
        brazier.OnBrazierOut.AddListener(BlowOutBrazier);
        brazier.OnBrazierOut.AddListener(ui.UpdateBrazierCount);

        }
 //disables sword by default
        sword.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        EnableSword();

    }

    public void EnableSword()
    {
        //enables sword when pressing E
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
        //disables the door, invokes fan solidifier event
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
        //blows out brazier and increases count
        brazier.LightOut();
        brazierUnlitCount++;
    }

    void EnableCollider(Fan fan)
    {
        //enables wind to solidify cloud block
        wind.SetActive(true);
    }
}
