using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SceneManager : MonoBehaviour
{

    public Character character;

    public Cloud cloud;
    public Fan fan;
    public Brazier brazier;
    public Door door;

    public GameObject sword;
    bool isSwordEnabled = false;

    Vector3 currentAngle = new Vector3(0f, 90f, 0f);
    // Start is called before the first frame update
    private void Start()
    {
        fan.OnFanHit.AddListener(RotateFan);

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

    void UnlockDoor()
    {
        //if brazier unlit count == 4 unlock door, else lock door
    }

    void RotateFan(Fan fanState)
    {
        //rotate fan on hit
            fanState.transform.Rotate(currentAngle);
        
    }
}
