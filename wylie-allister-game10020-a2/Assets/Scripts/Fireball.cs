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
        if (isMoving)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - fireSpeed * Time.deltaTime);
        }

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
           SceneManager.LoadScene("MainScene");
        }

        if (collision.gameObject.tag == "Reset")
        {
            this.transform.position = new Vector3 (transform.position.x, transform.position.y, 4.50f);
        }

        if (collision.gameObject.name == "Solidifier")
        {
            isMoving = false;
        }
    }
}
