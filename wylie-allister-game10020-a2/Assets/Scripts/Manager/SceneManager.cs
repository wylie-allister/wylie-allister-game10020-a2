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

    Vector3 currentAngle = new Vector3(0f, 90f, 0f);
    // Start is called before the first frame update
    private void Start()
    {
        fan.OnFanHit.AddListener(RotateFan);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UnlockDoor()
    {
        //if brazier unlit count == 4 unlock door, else lock door
    }

    void RotateFan(Fan fanState)
    {
        Debug.Log("Ping");

        fanState.transform.Rotate(currentAngle);
    }
}
