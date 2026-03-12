using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //allows the player to stab with sword
        if (other.GetComponent<IStabbable>() != null)
        {
            IStabbable stabbable = other.GetComponent<IStabbable>();
            stabbable.Stab(gameObject);
        }
    }
}
