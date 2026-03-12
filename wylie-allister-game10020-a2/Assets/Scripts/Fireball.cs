using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fireball : MonoBehaviour
{
    public float fireSpeed = 5f;
    bool isMoving = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moves fireball if not blocked
        if (isMoving)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - fireSpeed * Time.deltaTime);
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        //kills player
        if (collision.gameObject.name == "Player")
        {
           SceneManager.LoadScene("MainScene");
        }

        //resets position of fireball when offscreen
        if (collision.gameObject.tag == "Reset")
        {
            this.transform.position = new Vector3 (transform.position.x, transform.position.y, 4.50f);
        }

        //stops fireball
        if (collision.gameObject.name == "Solidifier")
        {
            isMoving = false;
        }
    }
}
