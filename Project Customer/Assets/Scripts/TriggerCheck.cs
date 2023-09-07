using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collectable")
        {
            other.GetComponent<Collectable>().Collect();
        }
    }
}
