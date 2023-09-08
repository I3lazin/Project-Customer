using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "collectable")
        {
            other.GetComponent<Collectable>().Collect();
        } 
        if (other.tag == "End")
        {
            SceneManager.LoadScene("Dasha");
        }
    }
}
