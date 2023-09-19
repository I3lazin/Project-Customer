using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;
using Unity.VisualScripting;

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
        if (other.tag == "FirstPerson")
        {
            ChangeCamera(2);

        }
        if (other.tag == "ThirdPerson")
        {
            ChangeCamera(0);
        }

        void ChangeCamera(int value)
        {
            foreach (var obj in GetComponentsInChildren<CinemachineVirtualCamera>())
            {
                if (obj.name == "CM vcam2")
                {
                    obj.GetComponent<CinemachineVirtualCamera>().Priority = value;
                }
            }
        }
    }
}
